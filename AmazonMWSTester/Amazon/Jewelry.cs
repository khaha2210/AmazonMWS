using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class Jewelry : ProductProductData
	{
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class JewelryProductType { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute("FashionEarring", typeof(FashionEarring))]
[System.Xml.Serialization.XmlElementAttribute("FashionNecklaceBraceletAnklet", typeof(FashionNecklaceBraceletAnklet))]
[System.Xml.Serialization.XmlElementAttribute("FashionOther", typeof(FashionOther))]
[System.Xml.Serialization.XmlElementAttribute("FashionRing", typeof(FashionRing))]
[System.Xml.Serialization.XmlElementAttribute("FineEarring", typeof(FineEarring))]
[System.Xml.Serialization.XmlElementAttribute("FineNecklaceBraceletAnklet", typeof(FineNecklaceBraceletAnklet))]
[System.Xml.Serialization.XmlElementAttribute("FineOther", typeof(FineOther))]
[System.Xml.Serialization.XmlElementAttribute("FineRing", typeof(FineRing))]
[System.Xml.Serialization.XmlElementAttribute("Watch", typeof(Watch))] public object Item { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(JewelryProductType)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class FashionEarringVariationData { private static System.Xml.Serialization.XmlSerializer serializer; public FashionEarringVariationDataParentage Parentage { get; set; } public FashionEarringVariationDataVariationTheme VariationTheme { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string MetalType { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(FashionEarringVariationData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum FashionEarringLithiumBatteryPackaging { batteries_contained_in_equipment, batteries_only, batteries_packed_with_equipment, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum StoneCreationMethod { natural, simulated, synthetic, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class JewelryBatteryBatterySubgroup { private static System.Xml.Serialization.XmlSerializer serializer; public JewelryBatteryBatterySubgroupBatteryType BatteryType { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")] public string NumberOfBatteries { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(JewelryBatteryBatterySubgroup)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class FashionNecklaceBraceletAnkletVariationData { private LengthDimension lengthField; private static System.Xml.Serialization.XmlSerializer serializer; public FashionNecklaceBraceletAnkletVariationDataParentage Parentage { get; set; } public FashionNecklaceBraceletAnkletVariationDataVariationTheme VariationTheme { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string MetalType { get; set; } public FashionNecklaceBraceletAnkletVariationData() { this.lengthField = new LengthDimension(); } public LengthDimension Length { get { return this.lengthField; } set { this.lengthField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(FashionNecklaceBraceletAnkletVariationData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum FashionNecklaceBraceletAnkletLithiumBatteryPackaging { batteries_contained_in_equipment, batteries_only, batteries_packed_with_equipment, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class FashionOtherVariationData { private LengthDimension lengthField; private static System.Xml.Serialization.XmlSerializer serializer; public FashionOtherVariationDataParentage Parentage { get; set; } public FashionOtherVariationDataVariationTheme VariationTheme { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string MetalType { get; set; } public FashionOtherVariationData() { this.lengthField = new LengthDimension(); } public LengthDimension Length { get { return this.lengthField; } set { this.lengthField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(FashionOtherVariationData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum FashionOtherLithiumBatteryPackaging { batteries_contained_in_equipment, batteries_only, batteries_packed_with_equipment, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class FashionRingVariationData { private static System.Xml.Serialization.XmlSerializer serializer; public FashionRingVariationDataParentage Parentage { get; set; } public FashionRingVariationDataVariationTheme VariationTheme { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string RingSize { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string MetalType { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(FashionRingVariationData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum FashionRingLithiumBatteryPackaging { batteries_contained_in_equipment, batteries_only, batteries_packed_with_equipment, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class FineEarringVariationData { private JewelryWeightDimension totalDiamondWeightField; private static System.Xml.Serialization.XmlSerializer serializer; public FineEarringVariationDataParentage Parentage { get; set; } public FineEarringVariationDataVariationTheme VariationTheme { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string MetalType { get; set; } public FineEarringVariationData() { this.totalDiamondWeightField = new JewelryWeightDimension(); } public JewelryWeightDimension TotalDiamondWeight { get { return this.totalDiamondWeightField; } set { this.totalDiamondWeightField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(FineEarringVariationData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum FineEarringLithiumBatteryPackaging { batteries_contained_in_equipment, batteries_only, batteries_packed_with_equipment, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class FineNecklaceBraceletAnkletVariationData { private LengthDimension lengthField; private JewelryWeightDimension totalDiamondWeightField; private static System.Xml.Serialization.XmlSerializer serializer; public FineNecklaceBraceletAnkletVariationDataParentage Parentage { get; set; } public FineNecklaceBraceletAnkletVariationDataVariationTheme VariationTheme { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string MetalType { get; set; } public FineNecklaceBraceletAnkletVariationData() { this.totalDiamondWeightField = new JewelryWeightDimension(); this.lengthField = new LengthDimension(); } public LengthDimension Length { get { return this.lengthField; } set { this.lengthField = value; } } public JewelryWeightDimension TotalDiamondWeight { get { return this.totalDiamondWeightField; } set { this.totalDiamondWeightField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(FineNecklaceBraceletAnkletVariationData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum FineNecklaceBraceletAnkletLithiumBatteryPackaging { batteries_contained_in_equipment, batteries_only, batteries_packed_with_equipment, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class FineOtherVariationData { private LengthDimension lengthField; private JewelryWeightDimension totalDiamondWeightField; private static System.Xml.Serialization.XmlSerializer serializer; public FineOtherVariationDataParentage Parentage { get; set; } public FineOtherVariationDataVariationTheme VariationTheme { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string MetalType { get; set; } public FineOtherVariationData() { this.totalDiamondWeightField = new JewelryWeightDimension(); this.lengthField = new LengthDimension(); } public LengthDimension Length { get { return this.lengthField; } set { this.lengthField = value; } } public JewelryWeightDimension TotalDiamondWeight { get { return this.totalDiamondWeightField; } set { this.totalDiamondWeightField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(FineOtherVariationData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum FineOtherLithiumBatteryPackaging { batteries_contained_in_equipment, batteries_only, batteries_packed_with_equipment, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class FineRingVariationData { private JewelryWeightDimension totalDiamondWeightField; private static System.Xml.Serialization.XmlSerializer serializer; public FineRingVariationDataParentage Parentage { get; set; } public FineRingVariationDataVariationTheme VariationTheme { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string RingSize { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string MetalType { get; set; } public FineRingVariationData() { this.totalDiamondWeightField = new JewelryWeightDimension(); } public JewelryWeightDimension TotalDiamondWeight { get { return this.totalDiamondWeightField; } set { this.totalDiamondWeightField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(FineRingVariationData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum FineRingLithiumBatteryPackaging { batteries_contained_in_equipment, batteries_only, batteries_packed_with_equipment, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class WatchVariationData { private static System.Xml.Serialization.XmlSerializer serializer; public WatchVariationDataParentage Parentage { get; set; } public WatchVariationDataVariationTheme VariationTheme { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(WatchVariationData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum WatchTargetGender { male, female, unisex, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum WatchLithiumBatteryPackaging { batteries_contained_in_equipment, batteries_only, batteries_packed_with_equipment, }

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum FashionEarringVariationDataParentage { parent, child, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum FashionEarringVariationDataVariationTheme { MetalType, Color, StyleName, Diameter, DisplayWeight, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum FashionNecklaceBraceletAnkletVariationDataParentage { parent, child, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum FashionNecklaceBraceletAnkletVariationDataVariationTheme { Length, MetalType, [System.Xml.Serialization.XmlEnumAttribute("Length-MetalType")] LengthMetalType, Color, StyleName, Diameter, DisplayWeight, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum FashionOtherVariationDataParentage { parent, child, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum FashionOtherVariationDataVariationTheme { Length, MetalType, [System.Xml.Serialization.XmlEnumAttribute("Length-MetalType")] LengthMetalType, Color, StyleName, Diameter, DisplayWeight, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum FashionRingVariationDataParentage { parent, child, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum FashionRingVariationDataVariationTheme { RingSize, MetalType, [System.Xml.Serialization.XmlEnumAttribute("MetalType-RingSize")] MetalTypeRingSize, Color, StyleName, Diameter, DisplayWeight, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum FineEarringVariationDataParentage { parent, child, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum FineEarringVariationDataVariationTheme { MetalType, SizePerPearl, TotalDiamondWeight, [System.Xml.Serialization.XmlEnumAttribute("MetalType-TotalDiamondWeight")] MetalTypeTotalDiamondWeight, [System.Xml.Serialization.XmlEnumAttribute("MetalType-SizePerPearl")] MetalTypeSizePerPearl, MetalStamp, GemType, [System.Xml.Serialization.XmlEnumAttribute("GemType-MetalType")] GemTypeMetalType, [System.Xml.Serialization.XmlEnumAttribute("MetalType-MetalStamp")] MetalTypeMetalStamp, [System.Xml.Serialization.XmlEnumAttribute("StoneShape-MetalType")] StoneShapeMetalType, Color, StyleName, Diameter, DisplayWeight, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum FineNecklaceBraceletAnkletVariationDataParentage { parent, child, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum FineNecklaceBraceletAnkletVariationDataVariationTheme { Length, MetalType, SizePerPearl, TotalDiamondWeight, [System.Xml.Serialization.XmlEnumAttribute("Length-TotalDiamondWeight")] LengthTotalDiamondWeight, [System.Xml.Serialization.XmlEnumAttribute("Length-SizePerPearl")] LengthSizePerPearl, [System.Xml.Serialization.XmlEnumAttribute("MetalType-TotalDiamondWeight")] MetalTypeTotalDiamondWeight, [System.Xml.Serialization.XmlEnumAttribute("MetalType-SizePerPearl")] MetalTypeSizePerPearl, MetalStamp, GemType, [System.Xml.Serialization.XmlEnumAttribute("GemType-MetalType")] GemTypeMetalType, [System.Xml.Serialization.XmlEnumAttribute("MetalType-MetalStamp")] MetalTypeMetalStamp, [System.Xml.Serialization.XmlEnumAttribute("MetalType-Length")] MetalTypeLength, [System.Xml.Serialization.XmlEnumAttribute("GemType-Length")] GemTypeLength, [System.Xml.Serialization.XmlEnumAttribute("StoneShape-MetalType")] StoneShapeMetalType, Color, StyleName, Diameter, DisplayWeight, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum FineOtherVariationDataParentage { parent, child, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum FineOtherVariationDataVariationTheme { Length, MetalType, SizePerPearl, TotalDiamondWeight, [System.Xml.Serialization.XmlEnumAttribute("Length-TotalDiamondWeight")] LengthTotalDiamondWeight, [System.Xml.Serialization.XmlEnumAttribute("Length-SizePerPearl")] LengthSizePerPearl, [System.Xml.Serialization.XmlEnumAttribute("MetalType-TotalDiamondWeight")] MetalTypeTotalDiamondWeight, [System.Xml.Serialization.XmlEnumAttribute("MetalType-SizePerPearl")] MetalTypeSizePerPearl, Color, StyleName, Diameter, DisplayWeight, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum FineRingVariationDataParentage { parent, child, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum FineRingVariationDataVariationTheme { RingSize, MetalType, SizePerPearl, TotalDiamondWeight, [System.Xml.Serialization.XmlEnumAttribute("MetalType-RingSize")] MetalTypeRingSize, [System.Xml.Serialization.XmlEnumAttribute("RingSize-TotalDiamondWeight")] RingSizeTotalDiamondWeight, [System.Xml.Serialization.XmlEnumAttribute("RingSize-SizePerPearl")] RingSizeSizePerPearl, [System.Xml.Serialization.XmlEnumAttribute("MetalType-TotalDiamondWeight")] MetalTypeTotalDiamondWeight, [System.Xml.Serialization.XmlEnumAttribute("MetalType-SizePerPearl")] MetalTypeSizePerPearl, MetalStamp, GemType, [System.Xml.Serialization.XmlEnumAttribute("GemType-MetalType")] GemTypeMetalType, [System.Xml.Serialization.XmlEnumAttribute("MetalType-MetalStamp")] MetalTypeMetalStamp, [System.Xml.Serialization.XmlEnumAttribute("MetalType-RingSize")] MetalTypeRingSize1, [System.Xml.Serialization.XmlEnumAttribute("GemType-RingSize")] GemTypeRingSize, [System.Xml.Serialization.XmlEnumAttribute("StoneShape-MetalType")] StoneShapeMetalType, [System.Xml.Serialization.XmlEnumAttribute("StoneShape-RingSize")] StoneShapeRingSize, Color, StyleName, Diameter, DisplayWeight, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum WatchVariationDataParentage { parent, child, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum WatchVariationDataVariationTheme { BandColor, Color, StyleName, }

}
