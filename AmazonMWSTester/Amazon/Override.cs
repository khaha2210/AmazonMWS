using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class Override : AmazonMessageChoice
	{
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] [System.ComponentModel.DesignerCategoryAttribute("code")] [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class OverrideShippingOverride { private List<object> itemsField; private static System.Xml.Serialization.XmlSerializer serializer;[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string ShipOption { get; set; } public OverrideShippingOverride() { this.itemsField = new List<object>(); }[System.Xml.Serialization.XmlElementAttribute("IsShippingRestricted", typeof(bool))] [System.Xml.Serialization.XmlElementAttribute("ShipAmount", typeof(CurrencyAmount))] [System.Xml.Serialization.XmlElementAttribute("Type", typeof(OverrideShippingOverrideType))] public List<object> Items { get { return this.itemsField; } set { this.itemsField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(OverrideShippingOverride)); } return serializer; } } }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum OverrideShippingOverrideType { Additive, Exclusive, }

}
