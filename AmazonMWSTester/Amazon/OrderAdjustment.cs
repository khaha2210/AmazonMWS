using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class OrderAdjustment : AmazonMessageChoice
	{
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class OrderAdjustmentAdjustedItem
	{
		private List<AdjustmentBuyerPriceComponent> itemPriceAdjustmentsField; private List<OrderAdjustmentAdjustedItemPromotionAdjustments> promotionAdjustmentsField; private List<AdjustmentDirectPaymentTypeComponent> directPaymentAdjustmentsField; private static System.Xml.Serialization.XmlSerializer serializer;
		[System.Xml.Serialization.XmlElementAttribute("AmazonOrderItemCode", typeof(string))]
		[System.Xml.Serialization.XmlElementAttribute("MerchantOrderItemID", typeof(string), DataType = "normalizedString")]
		[System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
		public string Item { get; set; }
		[System.Xml.Serialization.XmlIgnoreAttribute()] public ItemChoiceType3 ItemElementName { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string MerchantAdjustmentItemID { get; set; }
		public OrderAdjustmentAdjustedItemAdjustmentReason AdjustmentReason { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")] public string QuantityCancelled { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")] public string Quantity { get; set; }
		public OrderAdjustmentAdjustedItem() { this.directPaymentAdjustmentsField = new List<AdjustmentDirectPaymentTypeComponent>(); this.promotionAdjustmentsField = new List<OrderAdjustmentAdjustedItemPromotionAdjustments>(); this.itemPriceAdjustmentsField = new List<AdjustmentBuyerPriceComponent>(); }
		[System.Xml.Serialization.XmlArrayItemAttribute("Component", IsNullable = false)] public List<AdjustmentBuyerPriceComponent> ItemPriceAdjustments { get { return this.itemPriceAdjustmentsField; } set { this.itemPriceAdjustmentsField = value; } }
		[System.Xml.Serialization.XmlElementAttribute("PromotionAdjustments")] public List<OrderAdjustmentAdjustedItemPromotionAdjustments> PromotionAdjustments { get { return this.promotionAdjustmentsField; } set { this.promotionAdjustmentsField = value; } }
		[System.Xml.Serialization.XmlArrayItemAttribute("Component", IsNullable = false)] public List<AdjustmentDirectPaymentTypeComponent> DirectPaymentAdjustments { get { return this.directPaymentAdjustmentsField; } set { this.directPaymentAdjustmentsField = value; } }
		private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(OrderAdjustmentAdjustedItem)); } return serializer; } }
	}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum OrderAdjustmentActionType { Refund, Cancel, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum OrderAdjustmentCODCollectionMethod { DirectPayment, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class AdjustmentBuyerPriceComponent
	{
		private AdjustmentCurrencyAmount amountField; private static System.Xml.Serialization.XmlSerializer serializer; public AdjustmentBuyerPriceComponentType Type { get; set; }
		public AdjustmentBuyerPriceComponent() { this.amountField = new AdjustmentCurrencyAmount(); }
		public AdjustmentCurrencyAmount Amount { get { return this.amountField; } set { this.amountField = value; } }
		private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(AdjustmentBuyerPriceComponent)); } return serializer; } }
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class OrderAdjustmentAdjustedItemPromotionAdjustments
	{
		private List<OrderAdjustmentAdjustedItemPromotionAdjustmentsComponent> componentField; private static System.Xml.Serialization.XmlSerializer serializer; public string PromotionClaimCode { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string MerchantPromotionID { get; set; }
		public OrderAdjustmentAdjustedItemPromotionAdjustments() { this.componentField = new List<OrderAdjustmentAdjustedItemPromotionAdjustmentsComponent>(); }
		[System.Xml.Serialization.XmlElementAttribute("Component")] public List<OrderAdjustmentAdjustedItemPromotionAdjustmentsComponent> Component { get { return this.componentField; } set { this.componentField = value; } }
		private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(OrderAdjustmentAdjustedItemPromotionAdjustments)); } return serializer; } }
	}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
	public enum ItemChoiceType3 { AmazonOrderItemCode, MerchantOrderItemID, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum OrderAdjustmentAdjustedItemAdjustmentReason { NoInventory, CustomerReturn, GeneralAdjustment, CouldNotShip, DifferentItem, Abandoned, CustomerCancel, PriceError, ProductOutofStock, CustomerAddressIncorrect, Exchange, Other, CarrierCreditDecision, RiskAssessmentInformationNotValid, CarrierCoverageFailure, TransactionRecord, Undeliverable, RefusedDelivery, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum AdjustmentBuyerPriceComponentType { Principal, Shipping, Tax, ShippingTax, RestockingFee, RestockingFeeTax, GiftWrap, GiftWrapTax, Surcharge, ReturnShipping, Goodwill, ExportCharge, COD, CODTax, Other, FreeReplacementReturnShipping, }

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class OrderAdjustmentAdjustedItemPromotionAdjustmentsComponent
	{

		private AdjustmentCurrencyAmount amountField;


		public PromotionApplicationType Type { get; set; }


		public OrderAdjustmentAdjustedItemPromotionAdjustmentsComponent()
		{
			this.amountField = new AdjustmentCurrencyAmount();
		}

		public AdjustmentCurrencyAmount Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
			}
		}
	}
}
