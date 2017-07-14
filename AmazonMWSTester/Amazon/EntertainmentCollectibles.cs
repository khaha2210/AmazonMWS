using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class EntertainmentCollectibles : ProductProductData
	{
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] [System.ComponentModel.DesignerCategoryAttribute("code")] [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class EntertainmentCollectiblesProductType { private EntertainmentMemorabilia itemField; private static System.Xml.Serialization.XmlSerializer serializer; public EntertainmentCollectiblesProductType() { this.itemField = new EntertainmentMemorabilia(); }[System.Xml.Serialization.XmlElementAttribute("EntertainmentMemorabilia")] public EntertainmentMemorabilia Item { get { return this.itemField; } set { this.itemField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(EntertainmentCollectiblesProductType)); } return serializer; } } }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] public enum AuthenticatedByType { psa, seller, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] public enum CollectibleType { original, original_limited_edition, reproduced, reproduced_limited_edition, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] public enum ConditionProvidedByType { psa, seller, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] public enum VinylRecordDetailsType { lp, [System.Xml.Serialization.XmlEnumAttribute("12_single")] Item12_single, [System.Xml.Serialization.XmlEnumAttribute("45")] Item45, ep, [System.Xml.Serialization.XmlEnumAttribute("78")] Item78, other, unknown, }

}
