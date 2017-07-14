using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class ThreeDPrinting : ProductProductData
	{
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] [System.ComponentModel.DesignerCategoryAttribute("code")] [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ThreeDPrintingVariationData { private static System.Xml.Serialization.XmlSerializer serializer; public ThreeDPrintingVariationDataParentage Parentage { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool ParentageSpecified { get; set; } public ThreeDPrintingVariationDataVariationTheme VariationTheme { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ThreeDPrintingVariationData)); } return serializer; } } }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum ThreeDPrintingProductType { DigitalDesigns, ThreeDPrintedProduct, ThreeDPrintableDesigns, }

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum ThreeDPrintingVariationDataParentage { parent, child, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum ThreeDPrintingVariationDataVariationTheme { ColorName, Material, [System.Xml.Serialization.XmlEnumAttribute("Material-Color")] MaterialColor, [System.Xml.Serialization.XmlEnumAttribute("Material-Size")] MaterialSize, SizeName, [System.Xml.Serialization.XmlEnumAttribute("SizeName-ColorName")] SizeNameColorName, }

}
