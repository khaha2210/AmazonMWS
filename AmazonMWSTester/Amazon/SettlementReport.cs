using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class SettlementReport : AmazonMessageChoice
	{
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class SettlementReportSettlementData { private CurrencyAmount totalAmountField; private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")] public string AmazonSettlementID { get; set; } public System.DateTime StartDate { get; set; } public System.DateTime EndDate { get; set; } public System.DateTime DepositDate { get; set; } public SettlementReportSettlementData() { this.totalAmountField = new CurrencyAmount(); } public CurrencyAmount TotalAmount { get { return this.totalAmountField; } set { this.totalAmountField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(SettlementReportSettlementData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class SettlementReportOrder { private List<AmazonFeesFee> shipmentFeesField; private SettlementReportOrderFulfillment fulfillmentField; private List<AmazonFeesFee> orderFeeField; private static System.Xml.Serialization.XmlSerializer serializer; public string AmazonOrderID { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string MerchantOrderID { get; set; } public object ShipmentID { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string MarketplaceName { get; set; } public SettlementReportOrder() { this.orderFeeField = new List<AmazonFeesFee>(); this.fulfillmentField = new SettlementReportOrderFulfillment(); this.shipmentFeesField = new List<AmazonFeesFee>(); }[System.Xml.Serialization.XmlArrayItemAttribute("Fee", typeof(AmazonFeesFee), IsNullable = false)] public List<AmazonFeesFee> ShipmentFees { get { return this.shipmentFeesField; } set { this.shipmentFeesField = value; } } public SettlementReportOrderFulfillment Fulfillment { get { return this.fulfillmentField; } set { this.fulfillmentField = value; } }[System.Xml.Serialization.XmlArrayItemAttribute("Fee", typeof(AmazonFeesFee), IsNullable = false)] public List<AmazonFeesFee> OrderFee { get { return this.orderFeeField; } set { this.orderFeeField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(SettlementReportOrder)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class SettlementReportAdjustment { private SettlementReportAdjustmentFulfillment fulfillmentField; private List<AmazonFeesFee> orderFeeAdjustmentField; private static System.Xml.Serialization.XmlSerializer serializer; public string AmazonOrderID { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string MerchantOrderID { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string AdjustmentID { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string MarketplaceName { get; set; } public SettlementReportAdjustment() { this.orderFeeAdjustmentField = new List<AmazonFeesFee>(); this.fulfillmentField = new SettlementReportAdjustmentFulfillment(); } public SettlementReportAdjustmentFulfillment Fulfillment { get { return this.fulfillmentField; } set { this.fulfillmentField = value; } }[System.Xml.Serialization.XmlArrayItemAttribute("Fee", typeof(AmazonFeesFee), IsNullable = false)] public List<AmazonFeesFee> OrderFeeAdjustment { get { return this.orderFeeAdjustmentField; } set { this.orderFeeAdjustmentField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(SettlementReportAdjustment)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class SettlementReportOtherFee { private CurrencyAmount amountField; private static System.Xml.Serialization.XmlSerializer serializer; public string AmazonOrderID { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string MerchantOrderID { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string MarketplaceName { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string MerchantFulfillmentID { get; set; } public System.DateTime PostedDate { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string ReasonDescription { get; set; } public SettlementReportOtherFee() { this.amountField = new CurrencyAmount(); } public CurrencyAmount Amount { get { return this.amountField; } set { this.amountField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(SettlementReportOtherFee)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class SettlementReportOtherTransaction { private CurrencyAmount amountField; private List<AmazonFeesFee> feesField; private static System.Xml.Serialization.XmlSerializer serializer; public string AmazonOrderID { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string MerchantOrderID { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string MarketplaceName { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string MerchantFulfillmentID { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string TransactionType { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string TransactionID { get; set; } public System.DateTime PostedDate { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string ReasonDescription { get; set; } public SettlementReportOtherTransaction() { this.feesField = new List<AmazonFeesFee>(); this.amountField = new CurrencyAmount(); } public CurrencyAmount Amount { get { return this.amountField; } set { this.amountField = value; } }[System.Xml.Serialization.XmlArrayItemAttribute("Fee", IsNullable = false)] public List<AmazonFeesFee> Fees { get { return this.feesField; } set { this.feesField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(SettlementReportOtherTransaction)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class SettlementReportMiscEvent { private CurrencyAmount amountField; private static System.Xml.Serialization.XmlSerializer serializer; public System.DateTime PostedDate { get; set; } public SettlementReportMiscEvent() { this.amountField = new CurrencyAmount(); } public CurrencyAmount Amount { get { return this.amountField; } set { this.amountField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(SettlementReportMiscEvent)); } return serializer; } } 
}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class SettlementReportOrderFulfillment { private List<SettlementReportOrderFulfillmentItem> itemField; private List<DirectPaymentTypeComponent> directPaymentField; private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string MerchantFulfillmentID { get; set; } public System.DateTime PostedDate { get; set; } public SettlementReportOrderFulfillment() { this.directPaymentField = new List<DirectPaymentTypeComponent>(); this.itemField = new List<SettlementReportOrderFulfillmentItem>(); }[System.Xml.Serialization.XmlElementAttribute("Item")] public List<SettlementReportOrderFulfillmentItem> Item { get { return this.itemField; } set { this.itemField = value; } }[System.Xml.Serialization.XmlArrayItemAttribute("Component", IsNullable = false)] public List<DirectPaymentTypeComponent> DirectPayment { get { return this.directPaymentField; } set { this.directPaymentField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(SettlementReportOrderFulfillment)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class SettlementReportAdjustmentFulfillment { private List<SettlementReportAdjustmentFulfillmentAdjustedItem> adjustedItemField; private List<DirectPaymentTypeComponent> directPaymentField; private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string MerchantFulfillmentID { get; set; } public System.DateTime PostedDate { get; set; } public SettlementReportAdjustmentFulfillment() { this.directPaymentField = new List<DirectPaymentTypeComponent>(); this.adjustedItemField = new List<SettlementReportAdjustmentFulfillmentAdjustedItem>(); }[System.Xml.Serialization.XmlElementAttribute("AdjustedItem")] public List<SettlementReportAdjustmentFulfillmentAdjustedItem> AdjustedItem { get { return this.adjustedItemField; } set { this.adjustedItemField = value; } }[System.Xml.Serialization.XmlArrayItemAttribute("Component", IsNullable = false)] public List<DirectPaymentTypeComponent> DirectPayment { get { return this.directPaymentField; } set { this.directPaymentField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(SettlementReportAdjustmentFulfillment)); } return serializer; } } 
}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class SettlementReportOrderFulfillmentItem
	{

		private List<BuyerPriceComponent> itemPriceField;

		private List<AmazonFeesFee> itemFeesField;

		private List<SettlementReportOrderFulfillmentItemPromotion> promotionField;

		private static System.Xml.Serialization.XmlSerializer serializer;

		public string AmazonOrderItemCode { get; set; }

		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
		public string MerchantOrderItemID { get; set; }

		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
		public string SKU { get; set; }

		[System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
		public string Quantity { get; set; }


		public SettlementReportOrderFulfillmentItem()
		{
			this.promotionField = new List<SettlementReportOrderFulfillmentItemPromotion>();
			this.itemFeesField = new List<AmazonFeesFee>();
			this.itemPriceField = new List<BuyerPriceComponent>();
		}

		[System.Xml.Serialization.XmlArrayItemAttribute("Component", IsNullable = false)]
		public List<BuyerPriceComponent> ItemPrice
		{
			get
			{
				return this.itemPriceField;
			}
			set
			{
				this.itemPriceField = value;
			}
		}

		[System.Xml.Serialization.XmlArrayItemAttribute("Fee", IsNullable = false)]
		public List<AmazonFeesFee> ItemFees
		{
			get
			{
				return this.itemFeesField;
			}
			set
			{
				this.itemFeesField = value;
			}
		}

		[System.Xml.Serialization.XmlElementAttribute("Promotion")]
		public List<SettlementReportOrderFulfillmentItemPromotion> Promotion
		{
			get
			{
				return this.promotionField;
			}
			set
			{
				this.promotionField = value;
			}
		}
	}


	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class SettlementReportOrderFulfillmentItemPromotion
	{

		private CurrencyAmount amountField;

		private static System.Xml.Serialization.XmlSerializer serializer;

		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
		public string MerchantPromotionID { get; set; }

		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
		public string Type { get; set; }


		public SettlementReportOrderFulfillmentItemPromotion()
		{
			this.amountField = new CurrencyAmount();
		}

		public CurrencyAmount Amount
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

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class SettlementReportAdjustmentFulfillmentAdjustedItem
	{

		private List<BuyerPriceComponent> itemPriceAdjustmentsField;

		private List<AmazonFeesFee> itemFeeAdjustmentsField;

		private List<SettlementReportAdjustmentFulfillmentAdjustedItemPromotionAdjustment> promotionAdjustmentField;

		private static System.Xml.Serialization.XmlSerializer serializer;

		public string AmazonOrderItemCode { get; set; }

		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
		public string MerchantOrderItemID { get; set; }

		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
		public string MerchantAdjustmentItemID { get; set; }

		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
		public string SKU { get; set; }


		public SettlementReportAdjustmentFulfillmentAdjustedItem()
		{
			this.promotionAdjustmentField = new List<SettlementReportAdjustmentFulfillmentAdjustedItemPromotionAdjustment>();
			this.itemFeeAdjustmentsField = new List<AmazonFeesFee>();
			this.itemPriceAdjustmentsField = new List<BuyerPriceComponent>();
		}

		[System.Xml.Serialization.XmlArrayItemAttribute("Component", IsNullable = false)]
		public List<BuyerPriceComponent> ItemPriceAdjustments
		{
			get
			{
				return this.itemPriceAdjustmentsField;
			}
			set
			{
				this.itemPriceAdjustmentsField = value;
			}
		}

		[System.Xml.Serialization.XmlArrayItemAttribute("Fee", IsNullable = false)]
		public List<AmazonFeesFee> ItemFeeAdjustments
		{
			get
			{
				return this.itemFeeAdjustmentsField;
			}
			set
			{
				this.itemFeeAdjustmentsField = value;
			}
		}

		[System.Xml.Serialization.XmlElementAttribute("PromotionAdjustment")]
		public List<SettlementReportAdjustmentFulfillmentAdjustedItemPromotionAdjustment> PromotionAdjustment
		{
			get
			{
				return this.promotionAdjustmentField;
			}
			set
			{
				this.promotionAdjustmentField = value;
			}
		}
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class SettlementReportAdjustmentFulfillmentAdjustedItemPromotionAdjustment
	{

		private CurrencyAmount amountField;

		private static System.Xml.Serialization.XmlSerializer serializer;

		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
		public string MerchantPromotionID { get; set; }

		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
		public string Type { get; set; }


		public SettlementReportAdjustmentFulfillmentAdjustedItemPromotionAdjustment()
		{
			this.amountField = new CurrencyAmount();
		}

		public CurrencyAmount Amount
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
