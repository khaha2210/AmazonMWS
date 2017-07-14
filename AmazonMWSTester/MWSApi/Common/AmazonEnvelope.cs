using AmazonMWSTester.Common;
using AmazonMWSTester.MWSApi.Common.MessageTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AmazonMWSTester.Common
{
	[XmlRoot(ElementName = "AmazonEnvelope")]
	public class AmazonEnvelope
	{
		[XmlAttribute(Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string noNamespaceSchemaLocation { get; set; }
		[XmlElement(ElementName = "Header")]
		public Header header { get; set; }
		[XmlElement(ElementName = "MessageType")]
		public AmazonEnvelopeMessageType MessageType { get; set; }
		[XmlElement(ElementName = "PurgeAndReplace")]
		public bool PurgeAndReplace { get; set; }
		[XmlElement(ElementName = "EffectiveDate")]
		public DateTime EffectiveDate { get; set; }
		[XmlElement(ElementName = "Message")]
		public AmazonEnvelopeMessage[] Messages { get; set; }
		[XmlElement(ElementName = "MarketplaceName")]
		public string MarketplaceName { get; set; }
	}
	[XmlRoot(ElementName = "AmazonEnvelopeMessage")]
	public class AmazonEnvelopeMessage
	{
		[XmlElement(ElementName = "MessageID")]
		public string MessageId;
		[XmlElement(ElementName = "OperationType")]
		public AmazonEnvelopeMessageOperationType OperationType;

		[XmlChoiceIdentifier("MessageChoice")]
		[XmlElement("Product", Type = typeof(Product))]
		[XmlElement("ProcessingReport", Type = typeof(ProcessingReport))]
		public MessageChoice Item;

		[XmlIgnore]
		public AmazonEnvelopeMessageType MessageChoice;

	}

	public class MessageChoice
	{

	}



	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum AmazonEnvelopeMessageType
	{
		CatPIL,
		Customer,
		FulfillmentCenter,
		FulfillmentOrderCancellationRequest,
		FulfillmentOrderRequest,
		Image,
		Inventory,
		Item,
		Listings,
		Loyalty,
		MultiChannelOrderReport,
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


	[SerializableAttribute()]
	[XmlTypeAttribute(AnonymousType = true)]
	public enum AmazonEnvelopeMessageOperationType
	{
		Update,
		Delete,
		PartialUpdate
	}


	[XmlRoot(ElementName = "StandardProductID")]
	public class StandardProductID
	{
		[XmlElement(ElementName = "StandardProductIDType")]
		private StandardProductIDType Type { get; set; }

		[XmlElement(ElementName = "StandardProductIDType")]
		private string Value { get; set; }
	}


	[SerializableAttribute()]
	[XmlTypeAttribute(AnonymousType = true)]
	public enum StandardProductIDType
	{
		ISBN,
		UPC,
		EAN,
		ASIN,
		GTIN,
		GCID,
		PZN
	}
}
