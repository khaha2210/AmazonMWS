using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class FulfillmentOrderRequest : AmazonMessageChoice
	{
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class FulfillmentOrderRequestItem { private PositiveCurrencyAmount perUnitDeclaredValueField; private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string MerchantSKU { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")] public string Quantity { get; set; } public string MerchantFulfillmentOrderItemID { get; set; } public string GiftMessage { get; set; } public string DisplayableComment { get; set; } public string FulfillmentNetworkSKU { get; set; } public string OrderItemDisposition { get; set; } public FulfillmentOrderRequestItem() { this.perUnitDeclaredValueField = new PositiveCurrencyAmount(); } public PositiveCurrencyAmount PerUnitDeclaredValue { get { return this.perUnitDeclaredValueField; } set { this.perUnitDeclaredValueField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(FulfillmentOrderRequestItem)); } return serializer; } } 
}

}
