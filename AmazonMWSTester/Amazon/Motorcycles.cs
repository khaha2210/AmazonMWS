using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class Motorcycles : ProductProductData
	{
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] [System.ComponentModel.DesignerCategoryAttribute("code")] [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class MotorcyclesProductType { private static System.Xml.Serialization.XmlSerializer serializer;[System.Xml.Serialization.XmlElementAttribute("Accessories", typeof(Accessories))] [System.Xml.Serialization.XmlElementAttribute("Gloves", typeof(Gloves))] [System.Xml.Serialization.XmlElementAttribute("Helmets", typeof(Helmets))] [System.Xml.Serialization.XmlElementAttribute("Parts", typeof(Parts))] [System.Xml.Serialization.XmlElementAttribute("ProtectiveClothing", typeof(ProtectiveClothing))] [System.Xml.Serialization.XmlElementAttribute("RidingBoots", typeof(RidingBoots))] [System.Xml.Serialization.XmlElementAttribute("Vehicles", typeof(Vehicles))] public object Item { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(MotorcyclesProductType)); } return serializer; } } }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] [System.ComponentModel.DesignerCategoryAttribute("code")] [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class MotorcyclesVariationData { private static System.Xml.Serialization.XmlSerializer serializer; public MotorcyclesVariationDataParentage Parentage { get; set; } public MotorcyclesVariationDataVariationTheme VariationTheme { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(MotorcyclesVariationData)); } return serializer; } } }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum AccessoriesLithiumBatteryPackaging { batteries_contained_in_equipment, batteries_only, batteries_packed_with_equipment, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum PartsLithiumBatteryPackaging { batteries_contained_in_equipment, batteries_only, batteries_packed_with_equipment, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum PartsPartPosition { front, rear, right, left, upper, lower, inside, outside, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] public enum EmissionUnitOfMeasure { grams_per_100_kilometers, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] public enum FuelEconomyUnitOfMeasure { liters_per_100_kilometers, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] public enum HorsepowerUnitOfMeasure { kilowatts, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] public enum RangeUnitOfMeasure { kilometers, }

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum MotorcyclesVariationDataParentage { parent, child, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum MotorcyclesVariationDataVariationTheme { Color, Size, SizeColor, }

}
