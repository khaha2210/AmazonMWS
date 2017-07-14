using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
    public partial class Amazon
    {

    }

	public partial class AmazonVendorOnly
	{
		public CurrencyAmount Cost { get; set; }
	}


	public partial class AmazonOnly
	{

		public string Tier { get; set; }

		public string PurchasingCategory { get; set; }

		public string PurchasingSubCategory { get; set; }

		public string PackagingType { get; set; }

		public AmazonOnlyUnderlyingAvailability UnderlyingAvailability { get; set; }

		public AmazonOnlyReplenishmentCategory ReplenishmentCategory { get; set; }

		public AmazonOnlyDropShipStatus DropShipStatus { get; set; }

		public AmazonOnlyOutOfStockWebsiteMessage OutOfStockWebsiteMessage { get; set; }

	}

	public enum AmazonOnlyUnderlyingAvailability
	{

		/// <remarks/>
		backordered,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("manufacturer-out-of-stock")]
		manufactureroutofstock,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("pre-ordered")]
		preordered,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("2-3-days")]
		Item23days,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("1-2-weeks")]
		Item12weeks,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("4-6-weeks")]
		Item46weeks,
	}

	public enum AmazonOnlyReplenishmentCategory
	{

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("basic-replenishment")]
		basicreplenishment,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("limited-replenishment")]
		limitedreplenishment,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("manufacturer-out-of-stock")]
		manufactureroutofstock,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("new-product")]
		newproduct,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("non-replenishable")]
		nonreplenishable,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("non-stockupable")]
		nonstockupable,

		/// <remarks/>
		obsolete,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("planned-replenishment")]
		plannedreplenishment,
	}

	public enum AmazonOnlyDropShipStatus
	{

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("drop-ship-disabled")]
		dropshipdisabled,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("drop-ship-disabled-by-buyer")]
		dropshipdisabledbybuyer,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("drop-ship-enabled")]
		dropshipenabled,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("drop-ship-enabled-no-auto-pricing")]
		dropshipenablednoautopricing,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("drop-ship-only")]
		dropshiponly,
	}

	public enum AmazonOnlyOutOfStockWebsiteMessage
	{

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("email-me-when-available")]
		emailmewhenavailable,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("out-of-stock")]
		outofstock,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("pre-order-ute")]
		preorderute,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("underlying-availability")]
		underlyingavailability,
	}
}
