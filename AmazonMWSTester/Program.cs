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

namespace AmazonMWSTester
{
	class Program
	{
		static void Main(string[] args)
		{

			var envelope = new Envelope();
			envelope.noNamespaceSchemaLocation = "amzn-envelope.xsd";

			var header = new Header();
			header.MerchantIdentifier = "A34KHB3TRXSAWQ";
			header.DocumentVersion = "1.0";

			envelope.Header = header;

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

			envelope.Message = message;

			envelope.MessageType = "Product";
			envelope.PurgeAndReplace = true;

			envelope.EffectiveDate = new DateTime(2017, 1, 1);


			var xmlSerializer = new XmlSerializer(typeof(Envelope));



			using (var textWriter = new StringWriter())
			{
				xmlSerializer.Serialize(textWriter, envelope);

				Send(textWriter.ToString());
			}


	

		}

		public static void Send(string body) {
			var param = new SortedDictionary<string, string>(new SortDecendingBytes());
			param["PurgeAndReplace"] = "false";
			param["FeedType"] = "_POST_PRODUCT_DATA_";
			var x = MWS.SendMws(body, param, "SubmitFeed");

			x.Wait();

		}

		public class SortDecendingBytes : IComparer<string>
		{
			public int Compare(string key1, string key2)
			{
				return string.Compare(key1, key2, StringComparison.Ordinal);
			}
		}
	}
}
