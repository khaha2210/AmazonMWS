using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmazonMWSTester.Feeds;
using AmazonMWSTester.Common;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using AmazonMWSTester.MWSApi;
using System.Collections;
using AmazonMWSTester.MWSApi.Results;
using AmazonMWSTester.Amazon;

namespace AmazonMWSTester.MWSApi
{
	class Program
	{
		private static string SellerId = "A34KHB3TRXSAWQ";
		private static string AwsAccessKeyId = "AKIAJ5Z2SMI4J7BZAFTA";
		private static string MwsAuthToken = "amzn.mws.3eae8c90-75bc-b87f-7de2-069ce93f891a";
		private static string SecretKey = "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";
		private static string MarketplaceId = "ATVPDKIKX0DER";

		static void Main(string[] args)
		{
			var client = new MwsClient(SellerId, MwsAuthToken, AwsAccessKeyId, SecretKey,MarketplaceId);

			var shoe = new Shoes()
			{
				ClassificationData = new ShoesClassificationData()
				{
					FabricType = "Dick fabric"
				}
			};

			var productList = new List<Product>();
			var product = new Product()
			{
				SKU = "12345678",
				Condition = new ConditionInfo()
				{
					ConditionType = ConditionType.New,
					ConditionNote = "heheh",
				},
				ProductData = shoe,
				DescriptionData = new ProductDescriptionData()
				{
					Brand = "Test Brand",
					MSRP = new CurrencyAmount()
					{
					currency = BaseCurrencyCode.USD,
					Value = 1000000.00m
					},
					Title = "California Republic Turquoise Palm Men's T-Shirt"
				},
				ProductTaxCode = "A_GEN_NOTAX",
				StandardProductID = new Amazon.StandardProductID()
				{
					Type = StandardProductIDType.ASIN,
					Value = "B00XDF7VNS"
				}
			};

			productList.Add(product);

			var submitFeed = client.SubmitFeed<Product>(productList, AmazonEnvelopeMessageType.Product, DateTime.UtcNow, FeedTypes.ProductFeed, true);
			submitFeed.Wait();

			var submitResult = submitFeed.Result.Result;
			Console.WriteLine(submitResult.SubmitFeedResult.FeedSubmissionInfo.FeedSubmissionId); 


		/*	var product = new Product2("54321", "UPC", "889133008882", "A_GEN_NOTAX", new DescriptionData()
			{
				Brand = "test brand",
				BulletPoint = new List<string> { "bull1","bull2"},
				Description = "test description",
				ItemType = "test type",
				Manufacturer = "test mfg",
				MSRP = new MSRP()
				{
					Currency = "USD",
					Text = "100000.00"
				},
				Title = @"Adidas Yeezy Boost 350 - 7 ""Turtle Dove"" - AQ4832"
			});

			var productList = new List<Product2>();
			productList.Add(product);

			var submitFeed = client.SubmitFeed<Product2>(productList, OperationType2.Update, MessageChoiceType.Product, DateTime.UtcNow, FeedTypes.ProductFeed, true);
			submitFeed.Wait();

			var submitResult = submitFeed.Result.Result;


			Console.WriteLine(submitResult.SubmitFeedResult.FeedSubmissionInfo.FeedSubmissionId);*/




			/*

			var productList = new List<Product>();

			var product = new Product();
			product.SKU = "12345";

			var productId = new StandardProductID
			{
				Type = "UPC",
				Value = "4015643103921"
			};
			product.StandardProductID = productId;
			product.ProductTaxCode = "A_GEN_NOTAX";
			product.DescriptionData = new DescriptionData
			{
				Title = "Test Title",
				Brand = "Test brand",
				Description = "Test description",
				BulletPoint = new List<string> { "Bullet 1", "bullet 2" },
				MSRP = new MSRP
				{
					Currency = "USD",
					Text = "100.00"
				},
				Manufacturer = "Test manufacturer",
				ItemType = "test item type"
			};

			product.ProductData = new ProductData
			{
				Health = new Health()
				{
					ProductType = new ProductType()
					{
						HealthMisc = new HealthMisc()
						{
							Directions = "Test directions",
							Ingredients = "Test ingredients"
						}
					}
				}
			};

			productList.Add(product);
			var result = client.SubmitFeed<Product>(productList, OperationType.Update, MessageChoiceType.Product, new DateTime(2017, 7, 1), FeedTypes.ProductFeed, true);
			result.Wait();

			/*var envelope = new Envelope();
			envelope.noNamespaceSchemaLocation = "amzn-envelope.xsd";

			var header = new Header();
			header.MerchantIdentifier = "A34KHB3TRXSAWQ";
			header.DocumentVersion = "1.0";

			envelope.Header = header;

			var messages = new List<Message>();
			var message = new Message();
			message.MessageId = 1;
			message.OperationType = OperationType.Update;


			var product = new Product();
			product.SKU = "12345";

			var productId = new StandardProductID
			{
				Type = "UPC",
				Value = "4015643103921"
			};
			product.StandardProductID = productId;
			product.ProductTaxCode = "A_GEN_NOTAX";
			product.DescriptionData = new DescriptionData
			{
				Title = "Test Title",
				Brand = "Test brand",
				Description = "Test description",
				BulletPoint = new List<string> { "Bullet 1", "bullet 2" },
				MSRP = new MSRP
				{
					Currency = "USD",
					Text = "100.00"
				},
				Manufacturer = "Test manufacturer",
				ItemType = "test item type"
			};

			product.ProductData = new ProductData
			{
				Health = new Health()
				{
					ProductType = new ProductType()
					{
						HealthMisc = new HealthMisc()
						{
							Directions = "Test directions",
							Ingredients = "Test ingredients"
						}
					}
				}
			};


			message.Choice = product;
			message.MessageChoice = MessageChoiceType.Product;

			messages.Add(message);
			envelope.Message = messages;

			envelope.MessageType = "Product";
			envelope.PurgeAndReplace = true;

			envelope.EffectiveDate = new DateTime(2017, 1, 1);


			var xmlSerializer = new XmlSerializer(typeof(Envelope));



			using (var textWriter = new StringWriter())
			{
				xmlSerializer.Serialize(textWriter, envelope);

				Send(textWriter.ToString());
			}

			*/


		}

		/*public static void Send(string body) {
			var param = new SortedDictionary<string, string>(new SortDecendingBytes());
			param["PurgeAndReplace"] = "false";
			param["FeedType"] = "_POST_PRODUCT_DATA_";
			var x = MwsCommands.SendMws(body, param, "SubmitFeed");

			x.Wait();

		}*/

		
	}
}
