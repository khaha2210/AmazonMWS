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
