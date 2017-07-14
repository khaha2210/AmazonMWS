using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class ReverseFeed 
	{
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ReverseItemSku { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ReverseItemSku)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ReverseItemAsin { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ReverseItemAsin)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ReverseItemPackageDimensions { private DimensionValue package_heightField; private DimensionValue package_lengthField; private DimensionValue package_widthField; private static System.Xml.Serialization.XmlSerializer serializer; public ReverseItemPackageDimensions() { this.package_widthField = new DimensionValue(); this.package_lengthField = new DimensionValue(); this.package_heightField = new DimensionValue(); } public DimensionValue package_height { get { return this.package_heightField; } set { this.package_heightField = value; } } public DimensionValue package_length { get { return this.package_lengthField; } set { this.package_lengthField = value; } } public DimensionValue package_width { get { return this.package_widthField; } set { this.package_widthField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ReverseItemPackageDimensions)); } return serializer; } } 
}

}
