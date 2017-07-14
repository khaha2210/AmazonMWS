using AmazonMWSTester.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AmazonMWSTester.Feeds
{
	

	[XmlRoot(ElementName = "StandardProductID")]
	public class StandardProductID
	{
		[XmlElement(ElementName = "Type")]
		public string Type { get; set; }
		[XmlElement(ElementName = "Value")]
		public string Value { get; set; }
	}

	[XmlRoot(ElementName = "MSRP")]
	public class MSRP
	{
		[XmlAttribute(AttributeName = "currency")]
		public string Currency { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "DescriptionData")]
	public class DescriptionData
	{
		[XmlElement(ElementName = "Title")]
		public string Title { get; set; }
		[XmlElement(ElementName = "Brand")]
		public string Brand { get; set; }
		[XmlElement(ElementName = "Description")]
		public string Description { get; set; }
		[XmlElement(ElementName = "BulletPoint")]
		public List<string> BulletPoint { get; set; }
		[XmlElement(ElementName = "MSRP")]
		public MSRP MSRP { get; set; }
		[XmlElement(ElementName = "Manufacturer")]
		public string Manufacturer { get; set; }
		[XmlElement(ElementName = "ItemType")]
		public string ItemType { get; set; }
	}

	[XmlRoot(ElementName = "HealthMisc")]
	public class HealthMisc
	{
		[XmlElement(ElementName = "Ingredients")]
		public string Ingredients { get; set; }
		[XmlElement(ElementName = "Directions")]
		public string Directions { get; set; }
	}

	[XmlRoot(ElementName = "ProductType")]
	public class ProductType
	{
		[XmlElement(ElementName = "HealthMisc")]
		public HealthMisc HealthMisc { get; set; }
	}

	[XmlRoot(ElementName = "Health")]
	public class Health
	{
		[XmlElement(ElementName = "ProductType")]
		public ProductType ProductType { get; set; }
	}

	[XmlRoot(ElementName = "ProductData")]
	public class ProductData
	{
		[XmlElement(ElementName = "Health")]
		public Health Health { get; set; }
	}

	[XmlRoot(ElementName = "Product")]
	public class Product2 : MessageChoice2
	{
		[XmlElement(ElementName = "SKU")]
		public string SKU { get; set; }
		[XmlElement(ElementName = "StandardProductID")]
		public StandardProductID StandardProductID { get; set; }
		[XmlElement(ElementName = "ProductTaxCode")]
		public string ProductTaxCode { get; set; }
		[XmlElement(ElementName = "DescriptionData")]
		public DescriptionData DescriptionData { get; set; }
		[XmlElement(ElementName = "ProductData")]
		public ProductData ProductData { get; set; }

		public Product2() {

		}

		public Product2(string sku, string productIdType, string productIdValue, string taxCode, DescriptionData descriptionData)
		{
			this.SKU = sku;
			this.StandardProductID = new StandardProductID()
			{
				Type = productIdType,
				Value = productIdValue
			};
			this.ProductTaxCode = taxCode;
			this.DescriptionData = descriptionData;

			this.ProductData = new ProductData
			{
				Health = new Health()
				{
					ProductType = new ProductType() 
					{
						HealthMisc = new HealthMisc()
						{
							Directions = "?",
							Ingredients = "?"
						}
					}
				}
			};
		}
	}


	
}
