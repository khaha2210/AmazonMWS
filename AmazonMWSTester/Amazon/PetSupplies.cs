using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class PetSupplies : ProductProductData
	{
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] [System.ComponentModel.DesignerCategoryAttribute("code")] [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class PetSuppliesProductType { private PetSuppliesMisc itemField; private static System.Xml.Serialization.XmlSerializer serializer; public PetSuppliesProductType() { this.itemField = new PetSuppliesMisc(); }[System.Xml.Serialization.XmlElementAttribute("PetSuppliesMisc")] public PetSuppliesMisc Item { get { return this.itemField; } set { this.itemField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(PetSuppliesProductType)); } return serializer; } } }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] [System.ComponentModel.DesignerCategoryAttribute("code")] [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class PetSuppliesMiscVariationData { private static System.Xml.Serialization.XmlSerializer serializer; public PetSuppliesMiscVariationDataParentage Parentage { get; set; } public PetSuppliesMiscVariationDataVariationTheme VariationTheme { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(PetSuppliesMiscVariationData)); } return serializer; } } }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] [System.ComponentModel.DesignerCategoryAttribute("code")] [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class PetSuppliesMiscColorSpecification { private static System.Xml.Serialization.XmlSerializer serializer;[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Color { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string ColorMap { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(PetSuppliesMiscColorSpecification)); } return serializer; } } }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum PetSuppliesMiscLithiumBatteryPackaging { batteries_contained_in_equipment, batteries_only, batteries_packed_with_equipment, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum PetSuppliesMiscLegalComplianceCertificationStatus { compliant, noncompliant, exempt, }

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum PetSuppliesMiscVariationDataParentage { parent, child, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum PetSuppliesMiscVariationDataVariationTheme { Color, Size, SizeColor, Flavor, FlavorSize, PatternName, [System.Xml.Serialization.XmlEnumAttribute("Color-PatternName")] ColorPatternName, [System.Xml.Serialization.XmlEnumAttribute("PatternName-Size")] PatternNameSize, [System.Xml.Serialization.XmlEnumAttribute("PatternName-Flavor")] PatternNameFlavor, Scent, }

}
