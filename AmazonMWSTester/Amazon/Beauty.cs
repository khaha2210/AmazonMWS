using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class Beauty : ProductProductData
	{
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class BeautyProductType { private BeautyMisc itemField; private static System.Xml.Serialization.XmlSerializer serializer; public BeautyProductType() { this.itemField = new BeautyMisc(); }[System.Xml.Serialization.XmlElementAttribute("BeautyMisc")] public BeautyMisc Item { get { return this.itemField; } set { this.itemField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(BeautyProductType)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum BeautyLithiumBatteryPackaging { batteries_contained_in_equipment, batteries_only, batteries_packed_with_equipment, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class BeautyMiscVariationData { private VolumeDimension capacityField; private static System.Xml.Serialization.XmlSerializer serializer; public BeautyMiscVariationDataParentage Parentage { get; set; } public BeautyMiscVariationDataVariationTheme VariationTheme { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Size { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Color { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string ColorMap { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Scent { get; set; } public BeautyMiscVariationData() { this.capacityField = new VolumeDimension(); } public VolumeDimension Capacity { get { return this.capacityField; } set { this.capacityField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(BeautyMiscVariationData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class BeautyMiscUnitCount { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")] public string unitOfMeasure { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(BeautyMiscUnitCount)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum BeautyMiscTargetGender { male, female, unisex, }

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum BeautyMiscVariationDataParentage { parent, child, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum BeautyMiscVariationDataVariationTheme { Size, Capacity, Color, [System.Xml.Serialization.XmlEnumAttribute("Size-Color")] SizeColor, Scent, [System.Xml.Serialization.XmlEnumAttribute("Size-Scent")] SizeScent, PatternName, [System.Xml.Serialization.XmlEnumAttribute("Size-UnitCount")] SizeUnitCount, }


}
