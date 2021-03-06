﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class Health : ProductProductData
	{
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class HealthProductType { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute("HealthMisc", typeof(HealthMisc))]
[System.Xml.Serialization.XmlElementAttribute("PersonalCareAppliances", typeof(PersonalCareAppliances))]
[System.Xml.Serialization.XmlElementAttribute("PrescriptionDrug", typeof(PrescriptionDrug))] public object Item { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(HealthProductType)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum HealthLithiumBatteryPackaging { batteries_contained_in_equipment, batteries_only, batteries_packed_with_equipment, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class HealthMiscVariationData { private static System.Xml.Serialization.XmlSerializer serializer; public HealthMiscVariationDataParentage Parentage { get; set; } public HealthMiscVariationDataVariationTheme VariationTheme { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Size { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string SizeMap { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Color { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string ColorMap { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")] public string Count { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")] public string NumberOfItems { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Flavor { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Scent { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string StyleName { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string CustomerPackageType { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(HealthMiscVariationData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class HealthMiscUnitCount { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")] public string unitOfMeasure { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(HealthMiscUnitCount)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum AllergenInformationType { abalone, abalone_free, amberjack, amberjack_free, apple, apple_free, banana, banana_free, barley, barley_free, beef, beef_free, buckwheat, buckwheat_free, celery, celery_free, chicken_meat, chicken_meat_free, codfish, codfish_free, crab, crab_free, dairy, dairy_free, eggs, egg_free, fish, fish_free, gelatin, gelatin_free, gluten, gluten_free, kiwi, kiwi_free, mackerel, mackerel_free, melon, melon_free, mushroom, mushroom_free, octopus, octopus_free, orange, orange_free, peach, peach_free, peanuts, peanut_free, pork, pork_free, salmon, salmon_free, salmon_roe, salmon_roe_free, scad, scad_free, scallop, scallop_free, sesame_seeds, sesame_seeds_free, shellfish, shellfish_free, shrimp, shrimp_free, soy, soy_free, squid, squid_free, tree_nuts, tree_nut_free, tuna, tuna_free, walnut, walnut_free, yam, yam_free, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum HealthMiscIdentityPackageType { bulk, frustration_free, traditional, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum HealthMiscTargetGender { male, female, unisex, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum UnknownOpticalUnitOfMeasure { unknown_modifier, diopters, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class PersonalCareAppliancesVariationData { private static System.Xml.Serialization.XmlSerializer serializer; public PersonalCareAppliancesVariationDataParentage Parentage { get; set; } public PersonalCareAppliancesVariationDataVariationTheme VariationTheme { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Size { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string SizeMap { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Color { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string ColorMap { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")] public string Count { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")] public string NumberOfItems { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Scent { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(PersonalCareAppliancesVariationData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class PersonalCareAppliancesUnitCount { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")] public string unitOfMeasure { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(PersonalCareAppliancesUnitCount)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum PersonalCareAppliancesTargetGender { male, female, unisex, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum EnergyLabelEfficiencyClass { a, b, c, d, e, f, g, a_plus, a_plus_plus, a_plus_plus_plus, }

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum HealthMiscVariationDataParentage { parent, child, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum HealthMiscVariationDataVariationTheme { Size, Color, Count, Scent, Flavor, [System.Xml.Serialization.XmlEnumAttribute("Size-Color")] SizeColor, [System.Xml.Serialization.XmlEnumAttribute("Flavor-Count")] FlavorCount, [System.Xml.Serialization.XmlEnumAttribute("Flavor-Size")] FlavorSize, [System.Xml.Serialization.XmlEnumAttribute("Size-Scent")] SizeScent, [System.Xml.Serialization.XmlEnumAttribute("Size-UnitCount")] SizeUnitCount, CustomerPackageType, [System.Xml.Serialization.XmlEnumAttribute("ColorName-CustomerPackageType")] ColorNameCustomerPackageType, [System.Xml.Serialization.XmlEnumAttribute("SizeName-CustomerPackageType")] SizeNameCustomerPackageType, [System.Xml.Serialization.XmlEnumAttribute("SizeName-ColorName-CustomerPackageType")] SizeNameColorNameCustomerPackageType, [System.Xml.Serialization.XmlEnumAttribute("StyleName-CustomerPackageType")] StyleNameCustomerPackageType, [System.Xml.Serialization.XmlEnumAttribute("SizeName-StyleName-CustomerPackageType")] SizeNameStyleNameCustomerPackageType, [System.Xml.Serialization.XmlEnumAttribute("Opticalpower-Basecurveradius-Itemdiameterstring-Cylindercorrection-Cylinderaxis-u" + "nitcount")] OpticalpowerBasecurveradiusItemdiameterstringCylindercorrectionCylinderaxisunitcount, [System.Xml.Serialization.XmlEnumAttribute("Opticalpower-Basecurveradius-Itemdiameterstring-Lensadditionpower-Unitcount")] OpticalpowerBasecurveradiusItemdiameterstringLensadditionpowerUnitcount, [System.Xml.Serialization.XmlEnumAttribute("Opticalpower-Basecurveradius-Itemdiameterstring-Unitcount")] OpticalpowerBasecurveradiusItemdiameterstringUnitcount, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum PersonalCareAppliancesVariationDataParentage { parent, child, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum PersonalCareAppliancesVariationDataVariationTheme { Size, Color, Count, [System.Xml.Serialization.XmlEnumAttribute("Size-Color")] SizeColor, [System.Xml.Serialization.XmlEnumAttribute("Size-UnitCount")] SizeUnitCount, Scent, }

}
