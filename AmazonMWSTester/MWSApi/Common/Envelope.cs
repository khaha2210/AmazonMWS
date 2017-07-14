using AmazonMWSTester.Feeds;
using AmazonMWSTester.MWSApi.MessageTypes;
using AmazonMWSTester.MWSApi.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AmazonMWSTester.Common
{
	[XmlRoot(ElementName = "AmazonEnvelope")]
	public class Envelope2
	{
		[XmlAttribute(Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string noNamespaceSchemaLocation { get; set; }





		[XmlElement(ElementName = "Header")]
		public Header Header { get; set; }

		[XmlElement(ElementName = "MessageType")]
		public string MessageType { get; set; }

		[XmlElement(ElementName = "PurgeAndReplace")]
		public bool PurgeAndReplace { get; set; }

		[XmlElement(ElementName = "EffectiveDate")]
		public DateTime EffectiveDate { get; set; }

		[XmlElement(ElementName = "Message")]
		public List<Message2> Message { get; set; }

		public Envelope2() {
			
		}



	}

	[XmlRoot(ElementName = "Message")]
	public class Message2
	{
		[XmlElement(ElementName = "MessageID")]
		public int MessageId { get; set; }

		[XmlElement(ElementName = "OperationType")]
		public string OperationType { get; set; }

		[XmlChoiceIdentifier("MessageChoice")]
		[XmlElement("Product",Type = typeof(Product2))]
		[XmlElement("Inventory", Type = typeof(Inventory))]
		[XmlElement("ProcessingReport", Type = typeof(ProcessingReport2))]
		public MessageChoice2 Choice { get; set; }

		[XmlIgnore]
		public MessageChoiceType MessageChoice;


	}

	[XmlType(IncludeInSchema = false)]
	public enum MessageChoiceType
	{
		Product,
		Inventory,
		ProcessingReport

	}


	public static class OperationType2
	{
		public const string Update = "Update";
		public const string Delete = "Delete";
		public const string PartialUpdate = "PartialUpdate";
	}

	public class MessageChoice2 { }


	public static class MessageType2
	{
		public const string CatPIL = "CatPIL";
		public const string Customer = "Customer";
		public const string FulfillmentCenter = "FulfillmentCenter";
		public const string FulfillmentOrderCancellationRequest = "FulfillmentOrderCancellationRequest";
		public const string FulfillmentOrderRequest = "FulfillmentOrderRequest";
		public const string Image = "Image";
		public const string Inventory = "Inventory";
		public const string Item = "Item";
		public const string Listings = "Listings";
		public const string Loyalty = "Loyalty";
		public const string MultiChannelOrderReport = "MultiChannelOrderReport";
		public const string NavigationReport = "NavigationReport";
		public const string Offer = "Offer";
		public const string OrderAcknowledgement = "OrderAcknowledgement";
		public const string OrderAdjustment = "OrderAdjustment";
		public const string OrderFulfillment = "OrderFulfillment";
		public const string OrderNotificationReport = "OrderNotificationReport";
		public const string OrderReport = "OrderReport";
		public const string Override = "Override";
		public const string Price = "Price";
		public const string ProcessingReport = "ProcessingReport";
		public const string Product = "Product";
		public const string ProductImage = "ProductImage";
		public const string Relationship = "Relationship";
		public const string ReverseItem = "ReverseItem";
		public const string SettlementReport = "SettlementReport";
		public const string Store = "Store";
		public const string WebstoreItem = "WebstoreItem";
	}
}
