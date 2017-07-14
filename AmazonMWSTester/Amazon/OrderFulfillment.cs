using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class OrderFulfillment : AmazonMessageChoice
	{
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class OrderFulfillmentFulfillmentData { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute("CarrierCode", typeof(CarrierCode))]
[System.Xml.Serialization.XmlElementAttribute("CarrierName", typeof(string), DataType = "normalizedString")] public object Item { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string ShippingMethod { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string ShipperTrackingNumber { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(OrderFulfillmentFulfillmentData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class OrderFulfillmentItem { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute("AmazonOrderItemCode", typeof(string))]
[System.Xml.Serialization.XmlElementAttribute("MerchantOrderItemID", typeof(string), DataType = "normalizedString")]
[System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")] public string Item { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public ItemChoiceType5 ItemElementName { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")] public string MerchantFulfillmentItemID { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")] public string Quantity { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(OrderFulfillmentItem)); } return serializer; } } 
}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)] public enum ItemChoiceType5 { AmazonOrderItemCode, MerchantOrderItemID, }

}
