using AmazonMWSTester.MWSApi.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.MWSApi
{
	public class MwsClient
	{
		public string SellerId { get; set; }
		public string MwsAuthToken { get; set; }
		public string AwsAccessKeyId { get; set; }
		public string SecretKey { get; set; }

		public MwsClient(string sellerId, string mwsAuthToken, string awsAccessKeyId, string secretKey) {
			this.SellerId = sellerId;
			this.MwsAuthToken = MwsAuthToken;
			this.AwsAccessKeyId = awsAccessKeyId;
			this.SecretKey = secretKey;
		}

		public SubmitFeedResponse SubmitFeed() {
			
		}

	}
}
