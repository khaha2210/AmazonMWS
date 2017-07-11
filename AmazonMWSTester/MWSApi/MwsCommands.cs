using AmazonMWSTester.Common;
using AmazonMWSTester.MWSApi.MessageTypes;
using AmazonMWSTester.MWSApi.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AmazonMWSTester.MWSApi
{
	public class MwsClient
	{
		private static HttpClient Client;


		private static readonly string BaseAddress = "mws.amazonservices.com";
		private static readonly string SignatureVersion = "2";
		private static readonly string ApiVersion = "2009-01-01";
		private static readonly string SignatureMethod = "HmacSHA256";

		private static readonly Regex encoding = new Regex(@"\s*encoding=.*\""");
		private static readonly string dateFormat = "yyyy-MM-dd'T'HH:mm:ss'Z'";

		public static string NamespaceSchemaLocation = "amzn-envelope.xsd";


		public string SellerId { get; set; }
		public string MwsAuthToken { get; set; }
		public string AwsAccessKeyId { get; set; }
		public string SecretKey { get; set; }

		static MwsClient()
		{
			Client = new HttpClient();
		}

		public MwsClient(string sellerId, string mwsAuthToken, string awsAccessKeyId, string secretKey) {
			this.SellerId = sellerId;
			this.MwsAuthToken = mwsAuthToken;
			this.AwsAccessKeyId = awsAccessKeyId;
			this.SecretKey = secretKey;
		}

		public async Task<MwsResponse<SubmitFeedResponse>> SubmitFeed<T>(List<T> messageItems, string operationType, MessageChoiceType messageChoice, DateTime effectiveDate, string feedType, bool purgeAndReplace = false) where T : MessageChoice 
		{
			if (typeof(T).Name != messageChoice.ToString())
				return new MwsResponse<SubmitFeedResponse>
				{
					Error = new ErrorResponse(),
					ExceptionMessage = "Feed items do not match given messageChoice"
				};

			var parameters = new SortedDictionary<string, string>(new SortDecendingBytes());
		
			var envelope = new Envelope();
			envelope.noNamespaceSchemaLocation = NamespaceSchemaLocation;
			envelope.PurgeAndReplace = purgeAndReplace;
			envelope.MessageType = messageChoice.ToString();
			envelope.EffectiveDate = effectiveDate;

			var messages = new List<Message>();
			var currentId = 1;

			foreach (var item in messageItems) {
				if (item.GetType().Name != messageChoice.ToString())
				{
					return null;
				}
				var message = new Message();
				message.MessageChoice = messageChoice;
				message.Choice = item;
				message.OperationType = operationType;
				message.MessageId = currentId++;
				messages.Add(message);
			}


			var header = new Header();
			var currentVersion = 1.0;
			header.DocumentVersion = currentVersion++.ToString("F1");
			header.MerchantIdentifier = this.SellerId;

			envelope.Header = header;
			envelope.Message = messages;

			parameters["PurgeAndReplace"] = purgeAndReplace.ToString().ToLower();
			parameters["FeedType"] = feedType;

			try {
				var result = await SendMws<Envelope>(envelope, parameters, "SubmitFeed");
				var resultText = await result.Content.ReadAsStringAsync();

				var submitFeedResult = MwsUtilities.Deserialize<SubmitFeedResponse>(resultText);

				if (submitFeedResult != null)
					return new MwsResponse<SubmitFeedResponse>
					{
						Result = submitFeedResult
					};

				var submitFeedError = MwsUtilities.Deserialize<ErrorResponse>(resultText);
				
				if (submitFeedError != null)
					return new MwsResponse<SubmitFeedResponse>
					{
						Error = submitFeedError
					};

				return new MwsResponse<SubmitFeedResponse>
				{
					Error = new ErrorResponse(),
					ExceptionMessage = "Unknown Error"
				};

			}
			catch (Exception ex) {
				return new MwsResponse<SubmitFeedResponse>
				{
					Error = new ErrorResponse(),
					ExceptionMessage = ex.ToString()
				};
			}
		}

		public async Task<MwsResponse<ProcessingReport>> GetFeedResult(string feedSubmissionId) {
			var parameters = new SortedDictionary<string, string>(new SortDecendingBytes());
			parameters["FeedSubmissionId"] = feedSubmissionId;
			
			try
			{
				var result = await SendMws<Envelope>(null, parameters, "GetFeedSubmissionResult");
				var resultText = await result.Content.ReadAsStringAsync();

				var getFeedResult = MwsUtilities.Deserialize<Envelope>(resultText);

				if (getFeedResult != null)
					return new MwsResponse<ProcessingReport>
					{
						Result = getFeedResult.Message[0].Choice as ProcessingReport
					};

				var getFeedError = MwsUtilities.Deserialize<ErrorResponse>(resultText);

				if (getFeedError != null)
					return new MwsResponse<ProcessingReport>
					{
						Error = getFeedError
					};

				return new MwsResponse<ProcessingReport>
				{
					Error = new ErrorResponse(),
					ExceptionMessage = "Unknown Error"
				};

			}
			catch (Exception ex)
			{
				return new MwsResponse<ProcessingReport>
				{
					Error = new ErrorResponse(),
					ExceptionMessage = ex.ToString()
				};
			}

		}


		
		private async Task<HttpResponseMessage> SendMws<T>(T bodyObject, SortedDictionary<string, string> parameters, string action)
		{
			var xmlBody = "";
			if (bodyObject != null) {
				xmlBody = MwsUtilities.SerializeXml<T>(bodyObject);
				xmlBody = encoding.Replace(xmlBody, "", 1);

				var contentMd5 = MwsUtilities.HashXml(xmlBody);
				parameters["ContentMD5Value"] = contentMd5;
			}

			

			parameters["AWSAccessKeyId"] = this.AwsAccessKeyId;
			parameters["Action"] = action; //GetFeedSubmissionResult
			parameters["Merchant"] = this.SellerId;
			parameters["MWSAuthToken"] = this.MwsAuthToken;
			parameters["SignatureVersion"] = SignatureVersion;
			parameters["Timestamp"] = DateTime.UtcNow.ToString(dateFormat);
			parameters["Version"] = ApiVersion;
			parameters["SignatureMethod"] = SignatureMethod;
			

			var signedParameters = MwsUtilities.GetSignedQuery(parameters, BaseAddress);
			var signature = MwsUtilities.UrlEncode(MwsUtilities.Sign(signedParameters, this.SecretKey));

			var requestUri = MwsUtilities.AddQueryString("https://mws.amazonservices.com/", parameters);

			var request = new HttpRequestMessage()
			{
				Method = HttpMethod.Post,
				RequestUri = new Uri(requestUri + "Signature=" + signature)
			};

			request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("text/plain"));
			request.Headers.UserAgent.Add(new ProductInfoHeaderValue(new ProductHeaderValue("RicsX", "1.0")));

			request.Content = new StringContent(xmlBody);
			request.Content.Headers.ContentType = new MediaTypeHeaderValue("text/xml");

			try
			{
				var response = await Client.SendAsync(request);
				return response;
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				return null;
			}
		}
	}

	public class FeedTypes {
		public static string ProductFeed = "_POST_PRODUCT_DATA_";

	}
}
