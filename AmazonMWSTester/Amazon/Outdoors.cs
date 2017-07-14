using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class Outdoors : ProductProductData
	{
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class OutdoorsProductType { private OutdoorRecreationProduct itemField; private static System.Xml.Serialization.XmlSerializer serializer; public OutdoorsProductType() { this.itemField = new OutdoorRecreationProduct(); }[System.Xml.Serialization.XmlElementAttribute("OutdoorRecreationProduct")] public OutdoorRecreationProduct Item { get { return this.itemField; } set { this.itemField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(OutdoorsProductType)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class OutdoorsVariationData { private static System.Xml.Serialization.XmlSerializer serializer; public OutdoorsVariationDataParentage Parentage { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool ParentageSpecified { get; set; } public OutdoorsVariationDataVariationTheme VariationTheme { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(OutdoorsVariationData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum LithiumBatteryPackagingType { batteries_contained_in_equipment, batteries_only, batteries_packed_with_equipment, }

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum OutdoorsVariationDataParentage { parent, child, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum OutdoorsVariationDataVariationTheme { ColorLength, ColorLensColor, ColorName, ColorSize, Length, LengthSize, LengthWidth, LensColor, ShapeSize, SizeName, SizeTensionLevel, SizeWeight, SizeWeightSupported, TensionLevel, Weight, Width, }

}
