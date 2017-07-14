using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class TypeDefinitions
	{

	
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum ConveyabilityValueValue { noncon, fullcase, sortable, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ElectricalPowerValueValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public ElectricalPowerValueValueUnitValue unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ElectricalPowerValueValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class NoiseValueValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public NoiseValueValueUnitValue unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(NoiseValueValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class EnergyValueValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public EnergyValueValueUnitValue unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(EnergyValueValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class PriceUnitValueValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public CurrencyCode currency { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(PriceUnitValueValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class WeightValueValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public WeightValueValueUnitValue unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(WeightValueValue)); } return serializer; } } 
}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class WeightValueNoDeleteValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public WeightValueNoDeleteValueUnitValue unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(WeightValueNoDeleteValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class DimensionValueValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(DimensionValueValue)); } return serializer; } } 
}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum RestrictedDimensionType { MM, CM, M, IN, FT, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class LongDimensionValueValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(LongDimensionValueValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class PowerValueValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public PowerValueValueUnitValue unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(PowerValueValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class PrinterResolutionValueValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public PrinterResolutionValueValueUnitValue unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(PrinterResolutionValueValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class TimeValueValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public TimeValueValueUnitValue unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(TimeValueValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class MemorySizeValueValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public MemorySizeValueValueUnitValue unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(MemorySizeValueValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class VolumeValueValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public VolumeValueValueUnitValue unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(VolumeValueValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ToleranceValueValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public ToleranceValueValueUnitValue unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ToleranceValueValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class CapacityValueValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public CapacityValueValueUnitValue unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(CapacityValueValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ApertureValueValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public ApertureValueValueUnitValue unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ApertureValueValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class PixelValueValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public PixelValueValueUnitValue unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(PixelValueValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum ZoomTypeUnitValue { x, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class JewelryWeightValueValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public JewelryWeightValueValueUnitValue unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(JewelryWeightValueValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class LongJewelryWeightValueValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public LongJewelryWeightValueValueUnitValue unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(LongJewelryWeightValueValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum MarketplaceSearchIndexabilityValue { exclude_from_index, include_in_index, }

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum ElectricalPowerValueValueUnitValue { Volt, Watt, kW, VA, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum NoiseValueValueUnitValue { Sone, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum EnergyValueValueUnitValue { BTU, kWh, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum CurrencyCode { USD, CAD, EUR, GBP, JPY, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum WeightValueValueUnitValue { GR, KG, OZ, LB, MG, tons, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum WeightValueNoDeleteValueUnitValue { GR, KG, OZ, LB, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum PowerValueValueUnitValue {[System.Xml.Serialization.XmlEnumAttribute("watts-per-sec")] wattspersec, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum PrinterResolutionValueValueUnitValue { cpi, ppi, dpi, lpi, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum TimeValueValueUnitValue { ns, ms, sec, min, hr, femtoseconds, picoseconds, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum MemorySizeValueValueUnitValue { TB, GB, MB, KB, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum VolumeValueValueUnitValue {[System.Xml.Serialization.XmlEnumAttribute("cubic-cm")] cubiccm, [System.Xml.Serialization.XmlEnumAttribute("cubic-ft")] cubicft, [System.Xml.Serialization.XmlEnumAttribute("cubic-in")] cubicin, [System.Xml.Serialization.XmlEnumAttribute("cubic-m")] cubicm, [System.Xml.Serialization.XmlEnumAttribute("cubic-yd")] cubicyd, cup, gallon, liter, milliliters, ounce, pint, quart, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum ToleranceValueValueUnitValue {[System.Xml.Serialization.XmlEnumAttribute("cubic-cm")] cubiccm, [System.Xml.Serialization.XmlEnumAttribute("cubic-ft")] cubicft, [System.Xml.Serialization.XmlEnumAttribute("cubic-in")] cubicin, [System.Xml.Serialization.XmlEnumAttribute("cubic-m")] cubicm, [System.Xml.Serialization.XmlEnumAttribute("cubic-yd")] cubicyd, cup, gallon, liter, milliliters, ounce, pint, quart, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum CapacityValueValueUnitValue { cubic_feet_per_minute, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum ApertureValueValueUnitValue { f, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum PixelValueValueUnitValue { pixels, MP, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum JewelryWeightValueValueUnitValue { GR, KG, OZ, LB, CARATS, DWT, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum LongJewelryWeightValueValueUnitValue { GR, KG, OZ, LB, CARATS, DWT, }

}
