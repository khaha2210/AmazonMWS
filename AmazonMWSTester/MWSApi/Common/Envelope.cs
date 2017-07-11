﻿using AmazonMWSTester.Feeds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AmazonMWSTester.Common
{
	[XmlRoot(ElementName = "AmazonEnvelope")]
	public class Envelope
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
		public Message Message { get; set; }

		


	}

	[XmlRoot(ElementName = "Message")]
	public class Message
	{
		[XmlElement(ElementName = "MessageID")]
		public int MessageId { get; set; }

		[XmlElement(ElementName = "OperationType")]
		public string OperationType { get; set; }

		[XmlChoiceIdentifier("MessageChoice")]
		[XmlElement("Product",Type = typeof(Product))]
		[XmlElement("Inventory", Type = typeof(Inventory))]
		public MessageChoice Choice { get; set; }

		[XmlIgnore]
		public MessageChoiceType MessageChoice;


	}

	[XmlType(IncludeInSchema = false)]
	public enum MessageChoiceType
	{
		Product,
		Inventory
	}


	public static class OperationType
	{
		public const string Update = "Update";
		public const string Delete = "Delete";
		public const string PartialUpdate = "PartialUpdate";
	}

	public class MessageChoice { }


	public static class MessageType
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