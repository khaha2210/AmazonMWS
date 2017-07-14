using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class amzn_envelope
	{
	}

	public partial class AmazonMessageChoice
	{
	}

	public partial class AmazonEnvelopeMessage
	{

		public string MessageID { get; set; }

		public AmazonEnvelopeMessageOperationType OperationType { get; set; }

		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool OperationTypeSpecified { get; set; }

		[System.Xml.Serialization.XmlElementAttribute("CatPIL", typeof(CatPIL))]
		[System.Xml.Serialization.XmlElementAttribute("Customer", typeof(Customer))]
		[System.Xml.Serialization.XmlElementAttribute("FulfillmentCenter", typeof(FulfillmentCenter))]
		[System.Xml.Serialization.XmlElementAttribute("FulfillmentOrderCancellationRequest", typeof(FulfillmentOrderCancellationRequest))]
		[System.Xml.Serialization.XmlElementAttribute("FulfillmentOrderRequest", typeof(FulfillmentOrderRequest))]
		[System.Xml.Serialization.XmlElementAttribute("Image", typeof(Image))]
		[System.Xml.Serialization.XmlElementAttribute("Inventory", typeof(Inventory))]
		[System.Xml.Serialization.XmlElementAttribute("Item", typeof(Item))]
		[System.Xml.Serialization.XmlElementAttribute("Listings", typeof(Listings))]
		[System.Xml.Serialization.XmlElementAttribute("Loyalty", typeof(Loyalty))]
		[System.Xml.Serialization.XmlElementAttribute("MultiChannelOrderReport", typeof(MultiChannelOrderReport))]
		[System.Xml.Serialization.XmlElementAttribute("NavigationReport", typeof(NavigationReport))]
		[System.Xml.Serialization.XmlElementAttribute("Offer", typeof(Offer))]
		[System.Xml.Serialization.XmlElementAttribute("OrderAcknowledgement", typeof(OrderAcknowledgement))]
		[System.Xml.Serialization.XmlElementAttribute("OrderAdjustment", typeof(OrderAdjustment))]
		[System.Xml.Serialization.XmlElementAttribute("OrderFulfillment", typeof(OrderFulfillment))]
		[System.Xml.Serialization.XmlElementAttribute("OrderNotificationReport", typeof(OrderNotificationReport))]
		[System.Xml.Serialization.XmlElementAttribute("OrderReport", typeof(OrderReport))]
		[System.Xml.Serialization.XmlElementAttribute("Override", typeof(Override))]
		[System.Xml.Serialization.XmlElementAttribute("Price", typeof(Price))]
		[System.Xml.Serialization.XmlElementAttribute("ProcessingReport", typeof(ProcessingReport))]
		[System.Xml.Serialization.XmlElementAttribute("Product", typeof(Product))]
		[System.Xml.Serialization.XmlElementAttribute("ProductImage", typeof(ProductImage))]
		[System.Xml.Serialization.XmlElementAttribute("Relationship", typeof(Relationship))]
		[System.Xml.Serialization.XmlElementAttribute("ReverseItem", typeof(ReverseItem))]
		[System.Xml.Serialization.XmlElementAttribute("SettlementReport", typeof(SettlementReport))]
		[System.Xml.Serialization.XmlElementAttribute("Store", typeof(Store))]
		[System.Xml.Serialization.XmlElementAttribute("WebstoreItem", typeof(WebstoreItem))]
		public AmazonMessageChoice Item { get; set; }

	}

	public enum AmazonEnvelopeMessageOperationType
	{

		/// <remarks/>
		Update,

		/// <remarks/>
		Delete,

		/// <remarks/>
		PartialUpdate,
	}

	public enum AmazonEnvelopeMessageType
	{
		CatPIL,
		Customer,
		FilfillmentCenter,
		FulfillmentOrderCancellationRequest,
		FilfillmentOrderRequest,
		Image,
		Inventory,
		Item,
		Listings,
		Loyalty,MultiChannelOrderReport,
		NavigationReport,
		Offer,
		OrderAcknowledgement,
		OrderAdjustment,
		OrderFulfillment,
		OrderNotificationReport,
		OrderReport,
		Override,
		Price,
		ProcessingReport,
		Product,
		ProductImage,
		Relationship,
		ReverseItem,
		SettlementReport,
		Store,
		WebstoreItem
	}

}
