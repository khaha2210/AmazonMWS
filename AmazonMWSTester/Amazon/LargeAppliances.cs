using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class LargeAppliances : ProductProductData
	{
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] [System.ComponentModel.DesignerCategoryAttribute("code")] [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class LargeAppliancesProductType { private static System.Xml.Serialization.XmlSerializer serializer;[System.Xml.Serialization.XmlElementAttribute("CookingOven", typeof(CookingOven))] [System.Xml.Serialization.XmlElementAttribute("Cooktop", typeof(Cooktop))] [System.Xml.Serialization.XmlElementAttribute("Dishwasher", typeof(Dishwasher))] [System.Xml.Serialization.XmlElementAttribute("LaundryAppliance", typeof(LaundryAppliance))] [System.Xml.Serialization.XmlElementAttribute("MicrowaveOven", typeof(MicrowaveOven))] [System.Xml.Serialization.XmlElementAttribute("Range", typeof(Range))] [System.Xml.Serialization.XmlElementAttribute("RefrigerationAppliance", typeof(RefrigerationAppliance))] [System.Xml.Serialization.XmlElementAttribute("TrashCompactor", typeof(TrashCompactor))] [System.Xml.Serialization.XmlElementAttribute("VentHood", typeof(VentHood))] public object Item { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(LargeAppliancesProductType)); } return serializer; } } }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] [System.ComponentModel.DesignerCategoryAttribute("code")] [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class LargeAppliancesVariationData { private static System.Xml.Serialization.XmlSerializer serializer; public LargeAppliancesVariationDataParentage Parentage { get; set; } public LargeAppliancesVariationDataVariationTheme VariationTheme { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(LargeAppliancesVariationData)); } return serializer; } } }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum LargeAppliancesLithiumBatteryPackaging { batteries_contained_in_equipment, batteries_only, batteries_packed_with_equipment, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] public enum MaxEnergyOutputUnitOfMeasure { btus, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] public enum AirflowDisplacementUnitOfMeasure { cubic_feet_per_minute, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] public enum MaxRotationSpeedUnitOfMeasure { rpm, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] public enum FilterPoreSizeUnitOfMeasure { micrometer, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] public enum IceCapacityUnitOfMeasure { pounds, }

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum LargeAppliancesVariationDataParentage { parent, child, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum LargeAppliancesVariationDataVariationTheme { Color, Size, SizeColor, }

}
