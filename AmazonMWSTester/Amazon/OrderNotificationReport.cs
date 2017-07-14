using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class OrderNotificationReport : AmazonMessageChoice
	{
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class OrderNotificationReportCustomerOrderInfo { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Type { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(OrderNotificationReportCustomerOrderInfo)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class OrderNotificationReportBillingData { private List<OrderNotificationReportBillingDataPaymentData> paymentDataField; private AddressType addressField; private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string BuyerEmailAddress { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string BuyerName { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string BuyerPhoneNumber { get; set; } public OrderNotificationReportBillingData() { this.addressField = new AddressType(); this.paymentDataField = new List<OrderNotificationReportBillingDataPaymentData>(); }[System.Xml.Serialization.XmlElementAttribute("PaymentData")] public List<OrderNotificationReportBillingDataPaymentData> PaymentData { get { return this.paymentDataField; } set { this.paymentDataField = value; } } public AddressType Address { get { return this.addressField; } set { this.addressField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(OrderNotificationReportBillingData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class OrderNotificationReportPromotion { private CurrencyAmount amountField; private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Name { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string ID { get; set; } public OrderNotificationReportPromotion() { this.amountField = new CurrencyAmount(); } public CurrencyAmount Amount { get { return this.amountField; } set { this.amountField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(OrderNotificationReportPromotion)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class OrderNotificationReportFulfillmentData { private AddressType addressField; private static System.Xml.Serialization.XmlSerializer serializer; public FulfillmentMethod FulfillmentMethod { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool FulfillmentMethodSpecified { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string ShipOption { get; set; } public OrderNotificationReportFulfillmentData() { this.addressField = new AddressType(); } public AddressType Address { get { return this.addressField; } set { this.addressField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(OrderNotificationReportFulfillmentData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class OrderNotificationReportItem { private CurrencyAmount itemPriceField; private static System.Xml.Serialization.XmlSerializer serializer; public string AmazonOrderItemCode { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string SKU { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Title { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")] public string Quantity { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string GiftWrapLevel { get; set; } public string GiftMessageText { get; set; } public OrderNotificationReportItem() { this.itemPriceField = new CurrencyAmount(); } public CurrencyAmount ItemPrice { get { return this.itemPriceField; } set { this.itemPriceField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(OrderNotificationReportItem)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum LanguageType { en_US, en_GB, en_CA, fr_CA, fr_FR, de_DE, ja_JP, }

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class OrderNotificationReportBillingDataPaymentData { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Type { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Identifier { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Issuer { get; set; } public string Tail { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "gYearMonth")] public string ExpirationDate { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(OrderNotificationReportBillingDataPaymentData)); } return serializer; } } 
}

}
