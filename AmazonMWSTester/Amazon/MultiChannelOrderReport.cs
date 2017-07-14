using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class MultiChannelOrderReport : AmazonMessageChoice
	{
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class MultiChannelOrderReportBillingData { private AddressType addressField; private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string BuyerEmailAddress { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string BuyerName { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string BuyerPhoneNumber { get; set; } public MultiChannelOrderReportBillingData() { this.addressField = new AddressType(); } public AddressType Address { get { return this.addressField; } set { this.addressField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(MultiChannelOrderReportBillingData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class MultiChannelOrderReportFulfillmentData { private AddressType addressField; private static System.Xml.Serialization.XmlSerializer serializer; public MultiChannelOrderReportFulfillmentDataFulfillmentChannel FulfillmentChannel { get; set; } public FulfillmentServiceLevel FulfillmentServiceLevel { get; set; } public MultiChannelOrderReportFulfillmentData() { this.addressField = new AddressType(); } public AddressType Address { get { return this.addressField; } set { this.addressField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(MultiChannelOrderReportFulfillmentData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class MultiChannelOrderReportItem { private List<BuyerPriceComponent> itemPriceField; private List<PromotionDataType> promotionField; private static System.Xml.Serialization.XmlSerializer serializer; public string AmazonOrderItemCode { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string MerchantOrderItemID { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string SKU { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Title { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")] public string Quantity { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string GiftWrapLevel { get; set; } public string GiftMessageText { get; set; } public MultiChannelOrderReportItem() { this.promotionField = new List<PromotionDataType>(); this.itemPriceField = new List<BuyerPriceComponent>(); }[System.Xml.Serialization.XmlArrayItemAttribute("Component", IsNullable = false)] public List<BuyerPriceComponent> ItemPrice { get { return this.itemPriceField; } set { this.itemPriceField = value; } }[System.Xml.Serialization.XmlElementAttribute("Promotion")] public List<PromotionDataType> Promotion { get { return this.promotionField; } set { this.promotionField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(MultiChannelOrderReportItem)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum MultiChannelOrderReportOrderStatus { ASSIGNED, COMPLETED, CANCELLED, HOLD, ADJUSTED, PLANNING, PROCESSING, UNFULFILLABLE, INVALID, COMPLETE_PARTIAL, }

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum MultiChannelOrderReportFulfillmentDataFulfillmentChannel { AFN, MFN, }

}
