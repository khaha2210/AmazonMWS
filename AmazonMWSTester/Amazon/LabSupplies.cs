using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class LabSupplies : ProductProductData
	{
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] [System.ComponentModel.DesignerCategoryAttribute("code")] [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class LabSuppliesProductType { private static System.Xml.Serialization.XmlSerializer serializer;[System.Xml.Serialization.XmlElementAttribute("LabSupply", typeof(LabSupply))] [System.Xml.Serialization.XmlElementAttribute("SafetySupply", typeof(SafetySupply))] public object Item { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(LabSuppliesProductType)); } return serializer; } } }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] [System.ComponentModel.DesignerCategoryAttribute("code")] [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class LabSupplyVariationData { private static System.Xml.Serialization.XmlSerializer serializer; public LabSupplyVariationDataParentage Parentage { get; set; } public LabSupplyVariationDataVariationTheme VariationTheme { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(LabSupplyVariationData)); } return serializer; } } }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] [System.ComponentModel.DesignerCategoryAttribute("code")] [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class SafetySupplyVariationData { private static System.Xml.Serialization.XmlSerializer serializer; public SafetySupplyVariationDataParentage Parentage { get; set; } public SafetySupplyVariationDataVariationTheme VariationTheme { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(SafetySupplyVariationData)); } return serializer; } } }

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum LabSupplyVariationDataParentage { parent, child, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum LabSupplyVariationDataVariationTheme { ColorName, ItemPackageQuantity, ItemWeight, Material, NumberOfItems, [System.Xml.Serialization.XmlEnumAttribute("SizeName-ColorName")] SizeNameColorName, SizeName, Style, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum SafetySupplyVariationDataParentage { parent, child, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum SafetySupplyVariationDataVariationTheme { ColorName, ItemPackageQuantity, ItemWeight, Material, NumberOfItems, [System.Xml.Serialization.XmlEnumAttribute("Size-Color")] SizeColor, SizeName, Style, }

}
