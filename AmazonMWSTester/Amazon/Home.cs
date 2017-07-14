using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class Home : ProductProductData
	{
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class HomeProductType { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute("Art", typeof(Art))]
[System.Xml.Serialization.XmlElementAttribute("BedAndBath", typeof(BedAndBath))]
[System.Xml.Serialization.XmlElementAttribute("FurnitureAndDecor", typeof(FurnitureAndDecor))]
[System.Xml.Serialization.XmlElementAttribute("Home", typeof(HomeProductTypeHome))]
[System.Xml.Serialization.XmlElementAttribute("Kitchen", typeof(Kitchen))]
[System.Xml.Serialization.XmlElementAttribute("OutdoorLiving", typeof(OutdoorLiving))]
[System.Xml.Serialization.XmlElementAttribute("SeedsAndPlants", typeof(SeedsAndPlants))] public object Item { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(HomeProductType)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class HomeVariationData { private static System.Xml.Serialization.XmlSerializer serializer; public HomeVariationDataParentage Parentage { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool ParentageSpecified { get; set; } public HomeVariationDataVariationTheme VariationTheme { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Size { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Color { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(HomeVariationData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum HomeParentage {[System.Xml.Serialization.XmlEnumAttribute("collection-parent")] collectionparent, [System.Xml.Serialization.XmlEnumAttribute("variation-parent")] variationparent, [System.Xml.Serialization.XmlEnumAttribute("base-product")] baseproduct, parent, child, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum HomeIdentityPackageType { bulk, frustration_free, traditional, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum HomeLithiumBatteryPackaging { batteries_contained_in_equipment, batteries_only, batteries_packed_with_equipment, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum HomeSunlightExposure { shade, [System.Xml.Serialization.XmlEnumAttribute("partial-shade")] partialshade, [System.Xml.Serialization.XmlEnumAttribute("partial-sun")] partialsun, [System.Xml.Serialization.XmlEnumAttribute("full-sun")] fullsun, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum HomeMoistureNeeds {[System.Xml.Serialization.XmlEnumAttribute("little-to-no-watering")] littletonowatering, [System.Xml.Serialization.XmlEnumAttribute("moderate-watering")] moderatewatering, [System.Xml.Serialization.XmlEnumAttribute("regular-watering")] regularwatering, [System.Xml.Serialization.XmlEnumAttribute("constant-watering")] constantwatering, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ArtVariationData { private static System.Xml.Serialization.XmlSerializer serializer; public ArtVariationDataVariationTheme VariationTheme { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Size { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Color { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Scent { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string StyleName { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string CustomerPackageType { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ArtVariationData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum ArtIdentityPackageType { bulk, frustration_free, traditional, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class BedAndBathVariationData { private static System.Xml.Serialization.XmlSerializer serializer; public BedAndBathVariationDataVariationTheme VariationTheme { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Size { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Color { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Scent { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string StyleName { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string CustomerPackageType { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(BedAndBathVariationData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum BedAndBathIdentityPackageType { bulk, frustration_free, traditional, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum BedAndBathLithiumBatteryPackaging { batteries_contained_in_equipment, batteries_only, batteries_packed_with_equipment, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class FurnitureAndDecorVariationData { private static System.Xml.Serialization.XmlSerializer serializer; public FurnitureAndDecorVariationDataVariationTheme VariationTheme { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Size { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Color { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Scent { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string StyleName { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string CustomerPackageType { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(FurnitureAndDecorVariationData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum FurnitureAndDecorIdentityPackageType { bulk, frustration_free, traditional, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum FurnitureAndDecorLithiumBatteryPackaging { batteries_contained_in_equipment, batteries_only, batteries_packed_with_equipment, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class KitchenVariationData { private static System.Xml.Serialization.XmlSerializer serializer; public KitchenVariationDataVariationTheme VariationTheme { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Size { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Color { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string StyleName { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string CustomerPackageType { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(KitchenVariationData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum KitchenIdentityPackageType { bulk, frustration_free, traditional, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class OutdoorLivingVariationData { private static System.Xml.Serialization.XmlSerializer serializer; public OutdoorLivingVariationDataVariationTheme VariationTheme { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Size { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Color { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string StyleName { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string ScentName { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string CustomerPackageType { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string MetalType { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(OutdoorLivingVariationData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class OutdoorLivingUnitCount { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")] public string unitOfMeasure { get; set; }[System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(OutdoorLivingUnitCount)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum OutdoorLivingIdentityPackageType { bulk, frustration_free, traditional, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class SeedsAndPlantsVariationData { private static System.Xml.Serialization.XmlSerializer serializer; public SeedsAndPlantsVariationDataVariationTheme VariationTheme { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Size { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Color { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string StyleName { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string ScentName { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string CustomerPackageType { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(SeedsAndPlantsVariationData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class SeedsAndPlantsUnitCount { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")] public string unitOfMeasure { get; set; }[System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(SeedsAndPlantsUnitCount)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum SeedsAndPlantsIdentityPackageType { bulk, frustration_free, traditional, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum SeedsAndPlantsMoistureNeeds {[System.Xml.Serialization.XmlEnumAttribute("little-to-no-watering")] littletonowatering, [System.Xml.Serialization.XmlEnumAttribute("moderate-watering")] moderatewatering, [System.Xml.Serialization.XmlEnumAttribute("regular-watering")] regularwatering, [System.Xml.Serialization.XmlEnumAttribute("constant-watering")] constantwatering, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum SeedsAndPlantsSunlightExposure { shade, [System.Xml.Serialization.XmlEnumAttribute("partial-shade")] partialshade, [System.Xml.Serialization.XmlEnumAttribute("partial-sun")] partialsun, [System.Xml.Serialization.XmlEnumAttribute("full-sun")] fullsun, }

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class HomeProductTypeHome { private Battery batteryField; private AreaDimensionOptionalUnit maximumCoverageAreaField; private VolumeRateDimension outputCapacityField; private WeightDimension towelWeightField; private HomeProductTypeHomeVariationData variationDataField; private WattageDimensionOptionalUnit wattageField; private LengthDimension itemDiameterField; private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string ColorMap { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Finish { get; set; } public bool IsStainResistant { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool IsStainResistantSpecified { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string LightSourceType { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Material { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")] public string NumberOfSets { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")] public string PieceCount { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Shape { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")] public string ThreadCount { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string InnerMaterialType { get; set; } public BatteryCellTypeValues BatteryCellComposition { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool BatteryCellCompositionSpecified { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string BatteryFormFactor { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string PaintType { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string CustomerRestrictionType { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string OccasionType { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Efficiency { get; set; } public HomeProductTypeHome() { this.itemDiameterField = new LengthDimension(); this.wattageField = new WattageDimensionOptionalUnit(); this.variationDataField = new HomeProductTypeHomeVariationData(); this.towelWeightField = new WeightDimension(); this.outputCapacityField = new VolumeRateDimension(); this.maximumCoverageAreaField = new AreaDimensionOptionalUnit(); this.batteryField = new Battery(); } public Battery Battery { get { return this.batteryField; } set { this.batteryField = value; } } public AreaDimensionOptionalUnit MaximumCoverageArea { get { return this.maximumCoverageAreaField; } set { this.maximumCoverageAreaField = value; } } public VolumeRateDimension OutputCapacity { get { return this.outputCapacityField; } set { this.outputCapacityField = value; } } public WeightDimension TowelWeight { get { return this.towelWeightField; } set { this.towelWeightField = value; } } public HomeProductTypeHomeVariationData VariationData { get { return this.variationDataField; } set { this.variationDataField = value; } } public WattageDimensionOptionalUnit Wattage { get { return this.wattageField; } set { this.wattageField = value; } } public LengthDimension ItemDiameter { get { return this.itemDiameterField; } set { this.itemDiameterField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(HomeProductTypeHome)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum HomeVariationDataParentage { parent, child, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum HomeVariationDataVariationTheme { Size, Color, [System.Xml.Serialization.XmlEnumAttribute("Length-Width")] LengthWidth, [System.Xml.Serialization.XmlEnumAttribute("Length-Material")] LengthMaterial, [System.Xml.Serialization.XmlEnumAttribute("Length-Size")] LengthSize, [System.Xml.Serialization.XmlEnumAttribute("Length-Color")] LengthColor, [System.Xml.Serialization.XmlEnumAttribute("Length-Height")] LengthHeight, [System.Xml.Serialization.XmlEnumAttribute("Width-Material")] WidthMaterial, [System.Xml.Serialization.XmlEnumAttribute("Width-Size")] WidthSize, [System.Xml.Serialization.XmlEnumAttribute("Width-Color")] WidthColor, [System.Xml.Serialization.XmlEnumAttribute("Width-Height")] WidthHeight, [System.Xml.Serialization.XmlEnumAttribute("NumberOfItemsInPackage-Material")] NumberOfItemsInPackageMaterial, [System.Xml.Serialization.XmlEnumAttribute("NumberOfItemsInPackage-Size")] NumberOfItemsInPackageSize, [System.Xml.Serialization.XmlEnumAttribute("NumberOfItemsInPackage-Color")] NumberOfItemsInPackageColor, [System.Xml.Serialization.XmlEnumAttribute("NumberOfItemsInPackage-Height")] NumberOfItemsInPackageHeight, [System.Xml.Serialization.XmlEnumAttribute("Weight-NumberOfItemsInPackage")] WeightNumberOfItemsInPackage, [System.Xml.Serialization.XmlEnumAttribute("Weight-Material")] WeightMaterial, [System.Xml.Serialization.XmlEnumAttribute("Weight-Size")] WeightSize, [System.Xml.Serialization.XmlEnumAttribute("Weight-Color")] WeightColor, [System.Xml.Serialization.XmlEnumAttribute("Weight-Height")] WeightHeight, [System.Xml.Serialization.XmlEnumAttribute("Material-Length")] MaterialLength, [System.Xml.Serialization.XmlEnumAttribute("Material-Width")] MaterialWidth, [System.Xml.Serialization.XmlEnumAttribute("Material-Size")] MaterialSize, [System.Xml.Serialization.XmlEnumAttribute("Material-Color")] MaterialColor, [System.Xml.Serialization.XmlEnumAttribute("Material-Height")] MaterialHeight, [System.Xml.Serialization.XmlEnumAttribute("Size-Length")] SizeLength, [System.Xml.Serialization.XmlEnumAttribute("Size-Width")] SizeWidth, [System.Xml.Serialization.XmlEnumAttribute("Size-Weight")] SizeWeight, [System.Xml.Serialization.XmlEnumAttribute("Size-Material")] SizeMaterial, [System.Xml.Serialization.XmlEnumAttribute("Size-Color")] SizeColor, [System.Xml.Serialization.XmlEnumAttribute("Size-Height")] SizeHeight, [System.Xml.Serialization.XmlEnumAttribute("Color-Length")] ColorLength, [System.Xml.Serialization.XmlEnumAttribute("Color-Width")] ColorWidth, [System.Xml.Serialization.XmlEnumAttribute("Color-NumberOfItemsInPackage")] ColorNumberOfItemsInPackage, [System.Xml.Serialization.XmlEnumAttribute("Color-Weight")] ColorWeight, [System.Xml.Serialization.XmlEnumAttribute("Color-Material")] ColorMaterial, [System.Xml.Serialization.XmlEnumAttribute("Color-Size")] ColorSize, [System.Xml.Serialization.XmlEnumAttribute("Color-Height")] ColorHeight, Height, Material, Weight, Length, NumberOfItemsInPackage, [System.Xml.Serialization.XmlEnumAttribute("Length-PatternName")] LengthPatternName, [System.Xml.Serialization.XmlEnumAttribute("Length-StyleName")] LengthStyleName, [System.Xml.Serialization.XmlEnumAttribute("Width-PatternName")] WidthPatternName, [System.Xml.Serialization.XmlEnumAttribute("Width-StyleName")] WidthStyleName, [System.Xml.Serialization.XmlEnumAttribute("Occasion-PatternName")] OccasionPatternName, [System.Xml.Serialization.XmlEnumAttribute("Occasion-NumberOfItemsInPackage")] OccasionNumberOfItemsInPackage, [System.Xml.Serialization.XmlEnumAttribute("Occasion-Material")] OccasionMaterial, [System.Xml.Serialization.XmlEnumAttribute("Occasion-StyleName")] OccasionStyleName, [System.Xml.Serialization.XmlEnumAttribute("Occasion-Size")] OccasionSize, [System.Xml.Serialization.XmlEnumAttribute("Occasion-Color")] OccasionColor, [System.Xml.Serialization.XmlEnumAttribute("Occasion-Height")] OccasionHeight, [System.Xml.Serialization.XmlEnumAttribute("PatternName-Length")] PatternNameLength, [System.Xml.Serialization.XmlEnumAttribute("PatternName-Width")] PatternNameWidth, [System.Xml.Serialization.XmlEnumAttribute("PatternName-Occasion")] PatternNameOccasion, [System.Xml.Serialization.XmlEnumAttribute("PatternName-Material")] PatternNameMaterial, [System.Xml.Serialization.XmlEnumAttribute("PatternName-StyleName")] PatternNameStyleName, [System.Xml.Serialization.XmlEnumAttribute("PatternName-Size")] PatternNameSize, [System.Xml.Serialization.XmlEnumAttribute("PatternName-Color")] PatternNameColor, [System.Xml.Serialization.XmlEnumAttribute("PatternName-Height")] PatternNameHeight, [System.Xml.Serialization.XmlEnumAttribute("MatteStyle-Material")] MatteStyleMaterial, [System.Xml.Serialization.XmlEnumAttribute("MatteStyle-StyleName")] MatteStyleStyleName, [System.Xml.Serialization.XmlEnumAttribute("MatteStyle-Size")] MatteStyleSize, [System.Xml.Serialization.XmlEnumAttribute("MatteStyle-Color")] MatteStyleColor, [System.Xml.Serialization.XmlEnumAttribute("NumberOfItemsInPackage-Occasion")] NumberOfItemsInPackageOccasion, [System.Xml.Serialization.XmlEnumAttribute("NumberOfItemsInPackage-StyleName")] NumberOfItemsInPackageStyleName, [System.Xml.Serialization.XmlEnumAttribute("Weight-StyleName")] WeightStyleName, [System.Xml.Serialization.XmlEnumAttribute("Material-PatternName")] MaterialPatternName, [System.Xml.Serialization.XmlEnumAttribute("Material-MatteStyle")] MaterialMatteStyle, [System.Xml.Serialization.XmlEnumAttribute("Material-StyleName")] MaterialStyleName, [System.Xml.Serialization.XmlEnumAttribute("StyleName-Length")] StyleNameLength, [System.Xml.Serialization.XmlEnumAttribute("StyleName-Width")] StyleNameWidth, [System.Xml.Serialization.XmlEnumAttribute("StyleName-Occasion")] StyleNameOccasion, [System.Xml.Serialization.XmlEnumAttribute("StyleName-PatternName")] StyleNamePatternName, [System.Xml.Serialization.XmlEnumAttribute("StyleName-Weight")] StyleNameWeight, [System.Xml.Serialization.XmlEnumAttribute("StyleName-Material")] StyleNameMaterial, [System.Xml.Serialization.XmlEnumAttribute("StyleName-Size")] StyleNameSize, [System.Xml.Serialization.XmlEnumAttribute("StyleName-Color")] StyleNameColor, [System.Xml.Serialization.XmlEnumAttribute("Size-Occasion")] SizeOccasion, [System.Xml.Serialization.XmlEnumAttribute("Size-PatternName")] SizePatternName, [System.Xml.Serialization.XmlEnumAttribute("Size-MatteStyle")] SizeMatteStyle, [System.Xml.Serialization.XmlEnumAttribute("Size-StyleName")] SizeStyleName, [System.Xml.Serialization.XmlEnumAttribute("Color-Occasion")] ColorOccasion, [System.Xml.Serialization.XmlEnumAttribute("Color-PatternName")] ColorPatternName, [System.Xml.Serialization.XmlEnumAttribute("Color-MatteStyle")] ColorMatteStyle, [System.Xml.Serialization.XmlEnumAttribute("Color-StyleName")] ColorStyleName, MatteStyle, PatternName, Occasion, StyleName, [System.Xml.Serialization.XmlEnumAttribute("Weight-Length-Color")] WeightLengthColor, [System.Xml.Serialization.XmlEnumAttribute("Occasion-Size-Color")] OccasionSizeColor, [System.Xml.Serialization.XmlEnumAttribute("Weight-Length-Material")] WeightLengthMaterial, [System.Xml.Serialization.XmlEnumAttribute("Weight-Length-StyleName")] WeightLengthStyleName, [System.Xml.Serialization.XmlEnumAttribute("PatternName-Size-Occasion")] PatternNameSizeOccasion, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum ArtVariationDataVariationTheme { Size, Color, Scent, [System.Xml.Serialization.XmlEnumAttribute("Size-Color")] SizeColor, [System.Xml.Serialization.XmlEnumAttribute("Size-Scent")] SizeScent, [System.Xml.Serialization.XmlEnumAttribute("DisplayLength-DisplayWidth")] DisplayLengthDisplayWidth, [System.Xml.Serialization.XmlEnumAttribute("DisplayLength-Material")] DisplayLengthMaterial, [System.Xml.Serialization.XmlEnumAttribute("DisplayLength-Size")] DisplayLengthSize, [System.Xml.Serialization.XmlEnumAttribute("DisplayLength-Color")] DisplayLengthColor, [System.Xml.Serialization.XmlEnumAttribute("DisplayLength-DisplayHeight")] DisplayLengthDisplayHeight, [System.Xml.Serialization.XmlEnumAttribute("DisplayWidth-Material")] DisplayWidthMaterial, [System.Xml.Serialization.XmlEnumAttribute("DisplayWidth-Size")] DisplayWidthSize, [System.Xml.Serialization.XmlEnumAttribute("DisplayWidth-Color")] DisplayWidthColor, [System.Xml.Serialization.XmlEnumAttribute("DisplayWidth-DisplayHeight")] DisplayWidthDisplayHeight, [System.Xml.Serialization.XmlEnumAttribute("ItemPackageQuantity-Material")] ItemPackageQuantityMaterial, [System.Xml.Serialization.XmlEnumAttribute("ItemPackageQuantity-Size")] ItemPackageQuantitySize, [System.Xml.Serialization.XmlEnumAttribute("ItemPackageQuantity-Color")] ItemPackageQuantityColor, [System.Xml.Serialization.XmlEnumAttribute("ItemPackageQuantity-DisplayHeight")] ItemPackageQuantityDisplayHeight, [System.Xml.Serialization.XmlEnumAttribute("DisplayWeight-ItemPackageQuantity")] DisplayWeightItemPackageQuantity, [System.Xml.Serialization.XmlEnumAttribute("DisplayWeight-Material")] DisplayWeightMaterial, [System.Xml.Serialization.XmlEnumAttribute("DisplayWeight-Size")] DisplayWeightSize, [System.Xml.Serialization.XmlEnumAttribute("DisplayWeight-Color")] DisplayWeightColor, [System.Xml.Serialization.XmlEnumAttribute("DisplayWeight-DisplayHeight")] DisplayWeightDisplayHeight, [System.Xml.Serialization.XmlEnumAttribute("Material-DisplayLength")] MaterialDisplayLength, [System.Xml.Serialization.XmlEnumAttribute("Material-DisplayWidth")] MaterialDisplayWidth, [System.Xml.Serialization.XmlEnumAttribute("Material-Size")] MaterialSize, [System.Xml.Serialization.XmlEnumAttribute("Material-Color")] MaterialColor, [System.Xml.Serialization.XmlEnumAttribute("Material-DisplayHeight")] MaterialDisplayHeight, [System.Xml.Serialization.XmlEnumAttribute("Size-DisplayLength")] SizeDisplayLength, [System.Xml.Serialization.XmlEnumAttribute("Size-DisplayWidth")] SizeDisplayWidth, [System.Xml.Serialization.XmlEnumAttribute("Size-DisplayWeight")] SizeDisplayWeight, [System.Xml.Serialization.XmlEnumAttribute("Size-Material")] SizeMaterial, [System.Xml.Serialization.XmlEnumAttribute("Size-Color")] SizeColor1, [System.Xml.Serialization.XmlEnumAttribute("Size-DisplayHeight")] SizeDisplayHeight, [System.Xml.Serialization.XmlEnumAttribute("Color-DisplayLength")] ColorDisplayLength, [System.Xml.Serialization.XmlEnumAttribute("Color-DisplayWidth")] ColorDisplayWidth, [System.Xml.Serialization.XmlEnumAttribute("Color-ItemPackageQuantity")] ColorItemPackageQuantity, [System.Xml.Serialization.XmlEnumAttribute("Color-DisplayWeight")] ColorDisplayWeight, [System.Xml.Serialization.XmlEnumAttribute("Color-Material")] ColorMaterial, [System.Xml.Serialization.XmlEnumAttribute("Color-Size")] ColorSize, [System.Xml.Serialization.XmlEnumAttribute("Color-DisplayHeight")] ColorDisplayHeight, DisplayHeight, Material, DisplayWeight, DisplayLength, ItemPackageQuantity, [System.Xml.Serialization.XmlEnumAttribute("DisplayLength-PatternName")] DisplayLengthPatternName, [System.Xml.Serialization.XmlEnumAttribute("DisplayLength-StyleName")] DisplayLengthStyleName, [System.Xml.Serialization.XmlEnumAttribute("DisplayWidth-PatternName")] DisplayWidthPatternName, [System.Xml.Serialization.XmlEnumAttribute("DisplayWidth-StyleName")] DisplayWidthStyleName, [System.Xml.Serialization.XmlEnumAttribute("Occasion-PatternName")] OccasionPatternName, [System.Xml.Serialization.XmlEnumAttribute("Occasion-ItemPackageQuantity")] OccasionItemPackageQuantity, [System.Xml.Serialization.XmlEnumAttribute("Occasion-Material")] OccasionMaterial, [System.Xml.Serialization.XmlEnumAttribute("Occasion-StyleName")] OccasionStyleName, [System.Xml.Serialization.XmlEnumAttribute("Occasion-Size")] OccasionSize, [System.Xml.Serialization.XmlEnumAttribute("Occasion-Color")] OccasionColor, [System.Xml.Serialization.XmlEnumAttribute("Occasion-DisplayHeight")] OccasionDisplayHeight, [System.Xml.Serialization.XmlEnumAttribute("PatternName-DisplayLength")] PatternNameDisplayLength, [System.Xml.Serialization.XmlEnumAttribute("PatternName-DisplayWidth")] PatternNameDisplayWidth, [System.Xml.Serialization.XmlEnumAttribute("PatternName-Occasion")] PatternNameOccasion, [System.Xml.Serialization.XmlEnumAttribute("PatternName-Material")] PatternNameMaterial, [System.Xml.Serialization.XmlEnumAttribute("PatternName-StyleName")] PatternNameStyleName, [System.Xml.Serialization.XmlEnumAttribute("PatternName-Size")] PatternNameSize, [System.Xml.Serialization.XmlEnumAttribute("PatternName-Color")] PatternNameColor, [System.Xml.Serialization.XmlEnumAttribute("PatternName-DisplayHeight")] PatternNameDisplayHeight, [System.Xml.Serialization.XmlEnumAttribute("MatteStyle-Material")] MatteStyleMaterial, [System.Xml.Serialization.XmlEnumAttribute("MatteStyle-StyleName")] MatteStyleStyleName, [System.Xml.Serialization.XmlEnumAttribute("MatteStyle-Size")] MatteStyleSize, [System.Xml.Serialization.XmlEnumAttribute("MatteStyle-Color")] MatteStyleColor, [System.Xml.Serialization.XmlEnumAttribute("ItemPackageQuantity-Occasion")] ItemPackageQuantityOccasion, [System.Xml.Serialization.XmlEnumAttribute("ItemPackageQuantity-StyleName")] ItemPackageQuantityStyleName, [System.Xml.Serialization.XmlEnumAttribute("DisplayWeight-StyleName")] DisplayWeightStyleName, [System.Xml.Serialization.XmlEnumAttribute("Material-PatternName")] MaterialPatternName, [System.Xml.Serialization.XmlEnumAttribute("Material-MatteStyle")] MaterialMatteStyle, [System.Xml.Serialization.XmlEnumAttribute("Material-StyleName")] MaterialStyleName, [System.Xml.Serialization.XmlEnumAttribute("StyleName-DisplayLength")] StyleNameDisplayLength, [System.Xml.Serialization.XmlEnumAttribute("StyleName-DisplayWidth")] StyleNameDisplayWidth, [System.Xml.Serialization.XmlEnumAttribute("StyleName-Occasion")] StyleNameOccasion, [System.Xml.Serialization.XmlEnumAttribute("StyleName-PatternName")] StyleNamePatternName, [System.Xml.Serialization.XmlEnumAttribute("StyleName-DisplayWeight")] StyleNameDisplayWeight, [System.Xml.Serialization.XmlEnumAttribute("StyleName-Material")] StyleNameMaterial, [System.Xml.Serialization.XmlEnumAttribute("StyleName-Size")] StyleNameSize, [System.Xml.Serialization.XmlEnumAttribute("StyleName-Color")] StyleNameColor, [System.Xml.Serialization.XmlEnumAttribute("Size-Occasion")] SizeOccasion, [System.Xml.Serialization.XmlEnumAttribute("Size-PatternName")] SizePatternName, [System.Xml.Serialization.XmlEnumAttribute("Size-MatteStyle")] SizeMatteStyle, [System.Xml.Serialization.XmlEnumAttribute("Size-StyleName")] SizeStyleName, [System.Xml.Serialization.XmlEnumAttribute("Color-Occasion")] ColorOccasion, [System.Xml.Serialization.XmlEnumAttribute("Color-PatternName")] ColorPatternName, [System.Xml.Serialization.XmlEnumAttribute("Color-MatteStyle")] ColorMatteStyle, [System.Xml.Serialization.XmlEnumAttribute("Color-StyleName")] ColorStyleName, MatteStyle, PatternName, Occasion, StyleName, CustomerPackageType, [System.Xml.Serialization.XmlEnumAttribute("ColorName-CustomerPackageType")] ColorNameCustomerPackageType, [System.Xml.Serialization.XmlEnumAttribute("SizeName-CustomerPackageType")] SizeNameCustomerPackageType, [System.Xml.Serialization.XmlEnumAttribute("SizeName-ColorName-CustomerPackageType")] SizeNameColorNameCustomerPackageType, [System.Xml.Serialization.XmlEnumAttribute("StyleName-CustomerPackageType")] StyleNameCustomerPackageType, [System.Xml.Serialization.XmlEnumAttribute("SizeName-StyleName-CustomerPackageType")] SizeNameStyleNameCustomerPackageType, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum BedAndBathVariationDataVariationTheme { Size, Color, Scent, [System.Xml.Serialization.XmlEnumAttribute("Size-Color")] SizeColor, [System.Xml.Serialization.XmlEnumAttribute("Size-Scent")] SizeScent, [System.Xml.Serialization.XmlEnumAttribute("DisplayLength-DisplayWidth")] DisplayLengthDisplayWidth, [System.Xml.Serialization.XmlEnumAttribute("DisplayLength-Material")] DisplayLengthMaterial, [System.Xml.Serialization.XmlEnumAttribute("DisplayLength-Size")] DisplayLengthSize, [System.Xml.Serialization.XmlEnumAttribute("DisplayLength-Color")] DisplayLengthColor, [System.Xml.Serialization.XmlEnumAttribute("DisplayLength-DisplayHeight")] DisplayLengthDisplayHeight, [System.Xml.Serialization.XmlEnumAttribute("DisplayWidth-Material")] DisplayWidthMaterial, [System.Xml.Serialization.XmlEnumAttribute("DisplayWidth-Size")] DisplayWidthSize, [System.Xml.Serialization.XmlEnumAttribute("DisplayWidth-Color")] DisplayWidthColor, [System.Xml.Serialization.XmlEnumAttribute("DisplayWidth-DisplayHeight")] DisplayWidthDisplayHeight, [System.Xml.Serialization.XmlEnumAttribute("ItemPackageQuantity-Material")] ItemPackageQuantityMaterial, [System.Xml.Serialization.XmlEnumAttribute("ItemPackageQuantity-Size")] ItemPackageQuantitySize, [System.Xml.Serialization.XmlEnumAttribute("ItemPackageQuantity-Color")] ItemPackageQuantityColor, [System.Xml.Serialization.XmlEnumAttribute("ItemPackageQuantity-DisplayHeight")] ItemPackageQuantityDisplayHeight, [System.Xml.Serialization.XmlEnumAttribute("DisplayWeight-ItemPackageQuantity")] DisplayWeightItemPackageQuantity, [System.Xml.Serialization.XmlEnumAttribute("DisplayWeight-Material")] DisplayWeightMaterial, [System.Xml.Serialization.XmlEnumAttribute("DisplayWeight-Size")] DisplayWeightSize, [System.Xml.Serialization.XmlEnumAttribute("DisplayWeight-Color")] DisplayWeightColor, [System.Xml.Serialization.XmlEnumAttribute("DisplayWeight-DisplayHeight")] DisplayWeightDisplayHeight, [System.Xml.Serialization.XmlEnumAttribute("Material-DisplayLength")] MaterialDisplayLength, [System.Xml.Serialization.XmlEnumAttribute("Material-DisplayWidth")] MaterialDisplayWidth, [System.Xml.Serialization.XmlEnumAttribute("Material-Size")] MaterialSize, [System.Xml.Serialization.XmlEnumAttribute("Material-Color")] MaterialColor, [System.Xml.Serialization.XmlEnumAttribute("Material-DisplayHeight")] MaterialDisplayHeight, [System.Xml.Serialization.XmlEnumAttribute("Size-DisplayLength")] SizeDisplayLength, [System.Xml.Serialization.XmlEnumAttribute("Size-DisplayWidth")] SizeDisplayWidth, [System.Xml.Serialization.XmlEnumAttribute("Size-DisplayWeight")] SizeDisplayWeight, [System.Xml.Serialization.XmlEnumAttribute("Size-Material")] SizeMaterial, [System.Xml.Serialization.XmlEnumAttribute("Size-Color")] SizeColor1, [System.Xml.Serialization.XmlEnumAttribute("Size-DisplayHeight")] SizeDisplayHeight, [System.Xml.Serialization.XmlEnumAttribute("Color-DisplayLength")] ColorDisplayLength, [System.Xml.Serialization.XmlEnumAttribute("Color-DisplayWidth")] ColorDisplayWidth, [System.Xml.Serialization.XmlEnumAttribute("Color-ItemPackageQuantity")] ColorItemPackageQuantity, [System.Xml.Serialization.XmlEnumAttribute("Color-DisplayWeight")] ColorDisplayWeight, [System.Xml.Serialization.XmlEnumAttribute("Color-Material")] ColorMaterial, [System.Xml.Serialization.XmlEnumAttribute("Color-Size")] ColorSize, [System.Xml.Serialization.XmlEnumAttribute("Color-DisplayHeight")] ColorDisplayHeight, DisplayHeight, Material, DisplayWeight, DisplayLength, ItemPackageQuantity, [System.Xml.Serialization.XmlEnumAttribute("DisplayLength-PatternName")] DisplayLengthPatternName, [System.Xml.Serialization.XmlEnumAttribute("DisplayLength-StyleName")] DisplayLengthStyleName, [System.Xml.Serialization.XmlEnumAttribute("DisplayWidth-PatternName")] DisplayWidthPatternName, [System.Xml.Serialization.XmlEnumAttribute("DisplayWidth-StyleName")] DisplayWidthStyleName, [System.Xml.Serialization.XmlEnumAttribute("Occasion-PatternName")] OccasionPatternName, [System.Xml.Serialization.XmlEnumAttribute("Occasion-ItemPackageQuantity")] OccasionItemPackageQuantity, [System.Xml.Serialization.XmlEnumAttribute("Occasion-Material")] OccasionMaterial, [System.Xml.Serialization.XmlEnumAttribute("Occasion-StyleName")] OccasionStyleName, [System.Xml.Serialization.XmlEnumAttribute("Occasion-Size")] OccasionSize, [System.Xml.Serialization.XmlEnumAttribute("Occasion-Color")] OccasionColor, [System.Xml.Serialization.XmlEnumAttribute("Occasion-DisplayHeight")] OccasionDisplayHeight, [System.Xml.Serialization.XmlEnumAttribute("PatternName-DisplayLength")] PatternNameDisplayLength, [System.Xml.Serialization.XmlEnumAttribute("PatternName-DisplayWidth")] PatternNameDisplayWidth, [System.Xml.Serialization.XmlEnumAttribute("PatternName-Occasion")] PatternNameOccasion, [System.Xml.Serialization.XmlEnumAttribute("PatternName-Material")] PatternNameMaterial, [System.Xml.Serialization.XmlEnumAttribute("PatternName-StyleName")] PatternNameStyleName, [System.Xml.Serialization.XmlEnumAttribute("PatternName-Size")] PatternNameSize, [System.Xml.Serialization.XmlEnumAttribute("PatternName-Color")] PatternNameColor, [System.Xml.Serialization.XmlEnumAttribute("PatternName-DisplayHeight")] PatternNameDisplayHeight, [System.Xml.Serialization.XmlEnumAttribute("MatteStyle-Material")] MatteStyleMaterial, [System.Xml.Serialization.XmlEnumAttribute("MatteStyle-StyleName")] MatteStyleStyleName, [System.Xml.Serialization.XmlEnumAttribute("MatteStyle-Size")] MatteStyleSize, [System.Xml.Serialization.XmlEnumAttribute("MatteStyle-Color")] MatteStyleColor, [System.Xml.Serialization.XmlEnumAttribute("ItemPackageQuantity-Occasion")] ItemPackageQuantityOccasion, [System.Xml.Serialization.XmlEnumAttribute("ItemPackageQuantity-StyleName")] ItemPackageQuantityStyleName, [System.Xml.Serialization.XmlEnumAttribute("DisplayWeight-StyleName")] DisplayWeightStyleName, [System.Xml.Serialization.XmlEnumAttribute("Material-PatternName")] MaterialPatternName, [System.Xml.Serialization.XmlEnumAttribute("Material-MatteStyle")] MaterialMatteStyle, [System.Xml.Serialization.XmlEnumAttribute("Material-StyleName")] MaterialStyleName, [System.Xml.Serialization.XmlEnumAttribute("StyleName-DisplayLength")] StyleNameDisplayLength, [System.Xml.Serialization.XmlEnumAttribute("StyleName-DisplayWidth")] StyleNameDisplayWidth, [System.Xml.Serialization.XmlEnumAttribute("StyleName-Occasion")] StyleNameOccasion, [System.Xml.Serialization.XmlEnumAttribute("StyleName-PatternName")] StyleNamePatternName, [System.Xml.Serialization.XmlEnumAttribute("StyleName-DisplayWeight")] StyleNameDisplayWeight, [System.Xml.Serialization.XmlEnumAttribute("StyleName-Material")] StyleNameMaterial, [System.Xml.Serialization.XmlEnumAttribute("StyleName-Size")] StyleNameSize, [System.Xml.Serialization.XmlEnumAttribute("StyleName-Color")] StyleNameColor, [System.Xml.Serialization.XmlEnumAttribute("Size-Occasion")] SizeOccasion, [System.Xml.Serialization.XmlEnumAttribute("Size-PatternName")] SizePatternName, [System.Xml.Serialization.XmlEnumAttribute("Size-MatteStyle")] SizeMatteStyle, [System.Xml.Serialization.XmlEnumAttribute("Size-StyleName")] SizeStyleName, [System.Xml.Serialization.XmlEnumAttribute("Color-Occasion")] ColorOccasion, [System.Xml.Serialization.XmlEnumAttribute("Color-PatternName")] ColorPatternName, [System.Xml.Serialization.XmlEnumAttribute("Color-MatteStyle")] ColorMatteStyle, [System.Xml.Serialization.XmlEnumAttribute("Color-StyleName")] ColorStyleName, MatteStyle, PatternName, Occasion, StyleName, CustomerPackageType, [System.Xml.Serialization.XmlEnumAttribute("ColorName-CustomerPackageType")] ColorNameCustomerPackageType, [System.Xml.Serialization.XmlEnumAttribute("SizeName-CustomerPackageType")] SizeNameCustomerPackageType, [System.Xml.Serialization.XmlEnumAttribute("SizeName-ColorName-CustomerPackageType")] SizeNameColorNameCustomerPackageType, [System.Xml.Serialization.XmlEnumAttribute("StyleName-CustomerPackageType")] StyleNameCustomerPackageType, [System.Xml.Serialization.XmlEnumAttribute("SizeName-StyleName-CustomerPackageType")] SizeNameStyleNameCustomerPackageType, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum FurnitureAndDecorVariationDataVariationTheme { Size, Color, Scent, [System.Xml.Serialization.XmlEnumAttribute("Size-Color")] SizeColor, [System.Xml.Serialization.XmlEnumAttribute("Size-Scent")] SizeScent, [System.Xml.Serialization.XmlEnumAttribute("DisplayLength-DisplayWidth")] DisplayLengthDisplayWidth, [System.Xml.Serialization.XmlEnumAttribute("DisplayLength-Material")] DisplayLengthMaterial, [System.Xml.Serialization.XmlEnumAttribute("DisplayLength-Size")] DisplayLengthSize, [System.Xml.Serialization.XmlEnumAttribute("DisplayLength-Color")] DisplayLengthColor, [System.Xml.Serialization.XmlEnumAttribute("DisplayLength-DisplayHeight")] DisplayLengthDisplayHeight, [System.Xml.Serialization.XmlEnumAttribute("DisplayWidth-Material")] DisplayWidthMaterial, [System.Xml.Serialization.XmlEnumAttribute("DisplayWidth-Size")] DisplayWidthSize, [System.Xml.Serialization.XmlEnumAttribute("DisplayWidth-Color")] DisplayWidthColor, [System.Xml.Serialization.XmlEnumAttribute("DisplayWidth-DisplayHeight")] DisplayWidthDisplayHeight, [System.Xml.Serialization.XmlEnumAttribute("ItemPackageQuantity-Material")] ItemPackageQuantityMaterial, [System.Xml.Serialization.XmlEnumAttribute("ItemPackageQuantity-Size")] ItemPackageQuantitySize, [System.Xml.Serialization.XmlEnumAttribute("ItemPackageQuantity-Color")] ItemPackageQuantityColor, [System.Xml.Serialization.XmlEnumAttribute("ItemPackageQuantity-DisplayHeight")] ItemPackageQuantityDisplayHeight, [System.Xml.Serialization.XmlEnumAttribute("DisplayWeight-ItemPackageQuantity")] DisplayWeightItemPackageQuantity, [System.Xml.Serialization.XmlEnumAttribute("DisplayWeight-Material")] DisplayWeightMaterial, [System.Xml.Serialization.XmlEnumAttribute("DisplayWeight-Size")] DisplayWeightSize, [System.Xml.Serialization.XmlEnumAttribute("DisplayWeight-Color")] DisplayWeightColor, [System.Xml.Serialization.XmlEnumAttribute("DisplayWeight-DisplayHeight")] DisplayWeightDisplayHeight, [System.Xml.Serialization.XmlEnumAttribute("Material-DisplayLength")] MaterialDisplayLength, [System.Xml.Serialization.XmlEnumAttribute("Material-DisplayWidth")] MaterialDisplayWidth, [System.Xml.Serialization.XmlEnumAttribute("Material-Size")] MaterialSize, [System.Xml.Serialization.XmlEnumAttribute("Material-Color")] MaterialColor, [System.Xml.Serialization.XmlEnumAttribute("Material-DisplayHeight")] MaterialDisplayHeight, [System.Xml.Serialization.XmlEnumAttribute("Size-DisplayLength")] SizeDisplayLength, [System.Xml.Serialization.XmlEnumAttribute("Size-DisplayWidth")] SizeDisplayWidth, [System.Xml.Serialization.XmlEnumAttribute("Size-DisplayWeight")] SizeDisplayWeight, [System.Xml.Serialization.XmlEnumAttribute("Size-Material")] SizeMaterial, [System.Xml.Serialization.XmlEnumAttribute("Size-Color")] SizeColor1, [System.Xml.Serialization.XmlEnumAttribute("Size-DisplayHeight")] SizeDisplayHeight, [System.Xml.Serialization.XmlEnumAttribute("Color-DisplayLength")] ColorDisplayLength, [System.Xml.Serialization.XmlEnumAttribute("Color-DisplayWidth")] ColorDisplayWidth, [System.Xml.Serialization.XmlEnumAttribute("Color-ItemPackageQuantity")] ColorItemPackageQuantity, [System.Xml.Serialization.XmlEnumAttribute("Color-DisplayWeight")] ColorDisplayWeight, [System.Xml.Serialization.XmlEnumAttribute("Color-Material")] ColorMaterial, [System.Xml.Serialization.XmlEnumAttribute("Color-Size")] ColorSize, [System.Xml.Serialization.XmlEnumAttribute("Color-DisplayHeight")] ColorDisplayHeight, DisplayHeight, Material, DisplayWeight, DisplayLength, ItemPackageQuantity, [System.Xml.Serialization.XmlEnumAttribute("DisplayLength-PatternName")] DisplayLengthPatternName, [System.Xml.Serialization.XmlEnumAttribute("DisplayLength-StyleName")] DisplayLengthStyleName, [System.Xml.Serialization.XmlEnumAttribute("DisplayWidth-PatternName")] DisplayWidthPatternName, [System.Xml.Serialization.XmlEnumAttribute("DisplayWidth-StyleName")] DisplayWidthStyleName, [System.Xml.Serialization.XmlEnumAttribute("Occasion-PatternName")] OccasionPatternName, [System.Xml.Serialization.XmlEnumAttribute("Occasion-ItemPackageQuantity")] OccasionItemPackageQuantity, [System.Xml.Serialization.XmlEnumAttribute("Occasion-Material")] OccasionMaterial, [System.Xml.Serialization.XmlEnumAttribute("Occasion-StyleName")] OccasionStyleName, [System.Xml.Serialization.XmlEnumAttribute("Occasion-Size")] OccasionSize, [System.Xml.Serialization.XmlEnumAttribute("Occasion-Color")] OccasionColor, [System.Xml.Serialization.XmlEnumAttribute("Occasion-DisplayHeight")] OccasionDisplayHeight, [System.Xml.Serialization.XmlEnumAttribute("PatternName-DisplayLength")] PatternNameDisplayLength, [System.Xml.Serialization.XmlEnumAttribute("PatternName-DisplayWidth")] PatternNameDisplayWidth, [System.Xml.Serialization.XmlEnumAttribute("PatternName-Occasion")] PatternNameOccasion, [System.Xml.Serialization.XmlEnumAttribute("PatternName-Material")] PatternNameMaterial, [System.Xml.Serialization.XmlEnumAttribute("PatternName-StyleName")] PatternNameStyleName, [System.Xml.Serialization.XmlEnumAttribute("PatternName-Size")] PatternNameSize, [System.Xml.Serialization.XmlEnumAttribute("PatternName-Color")] PatternNameColor, [System.Xml.Serialization.XmlEnumAttribute("PatternName-DisplayHeight")] PatternNameDisplayHeight, [System.Xml.Serialization.XmlEnumAttribute("MatteStyle-Material")] MatteStyleMaterial, [System.Xml.Serialization.XmlEnumAttribute("MatteStyle-StyleName")] MatteStyleStyleName, [System.Xml.Serialization.XmlEnumAttribute("MatteStyle-Size")] MatteStyleSize, [System.Xml.Serialization.XmlEnumAttribute("MatteStyle-Color")] MatteStyleColor, [System.Xml.Serialization.XmlEnumAttribute("ItemPackageQuantity-Occasion")] ItemPackageQuantityOccasion, [System.Xml.Serialization.XmlEnumAttribute("ItemPackageQuantity-StyleName")] ItemPackageQuantityStyleName, [System.Xml.Serialization.XmlEnumAttribute("DisplayWeight-StyleName")] DisplayWeightStyleName, [System.Xml.Serialization.XmlEnumAttribute("Material-PatternName")] MaterialPatternName, [System.Xml.Serialization.XmlEnumAttribute("Material-MatteStyle")] MaterialMatteStyle, [System.Xml.Serialization.XmlEnumAttribute("Material-StyleName")] MaterialStyleName, [System.Xml.Serialization.XmlEnumAttribute("StyleName-DisplayLength")] StyleNameDisplayLength, [System.Xml.Serialization.XmlEnumAttribute("StyleName-DisplayWidth")] StyleNameDisplayWidth, [System.Xml.Serialization.XmlEnumAttribute("StyleName-Occasion")] StyleNameOccasion, [System.Xml.Serialization.XmlEnumAttribute("StyleName-PatternName")] StyleNamePatternName, [System.Xml.Serialization.XmlEnumAttribute("StyleName-DisplayWeight")] StyleNameDisplayWeight, [System.Xml.Serialization.XmlEnumAttribute("StyleName-Material")] StyleNameMaterial, [System.Xml.Serialization.XmlEnumAttribute("StyleName-Size")] StyleNameSize, [System.Xml.Serialization.XmlEnumAttribute("StyleName-Color")] StyleNameColor, [System.Xml.Serialization.XmlEnumAttribute("Size-Occasion")] SizeOccasion, [System.Xml.Serialization.XmlEnumAttribute("Size-PatternName")] SizePatternName, [System.Xml.Serialization.XmlEnumAttribute("Size-MatteStyle")] SizeMatteStyle, [System.Xml.Serialization.XmlEnumAttribute("Size-StyleName")] SizeStyleName, [System.Xml.Serialization.XmlEnumAttribute("Color-Occasion")] ColorOccasion, [System.Xml.Serialization.XmlEnumAttribute("Color-PatternName")] ColorPatternName, [System.Xml.Serialization.XmlEnumAttribute("Color-MatteStyle")] ColorMatteStyle, [System.Xml.Serialization.XmlEnumAttribute("Color-StyleName")] ColorStyleName, MatteStyle, PatternName, Occasion, StyleName, CustomerPackageType, [System.Xml.Serialization.XmlEnumAttribute("ColorName-CustomerPackageType")] ColorNameCustomerPackageType, [System.Xml.Serialization.XmlEnumAttribute("SizeName-CustomerPackageType")] SizeNameCustomerPackageType, [System.Xml.Serialization.XmlEnumAttribute("SizeName-ColorName-CustomerPackageType")] SizeNameColorNameCustomerPackageType, [System.Xml.Serialization.XmlEnumAttribute("StyleName-CustomerPackageType")] StyleNameCustomerPackageType, [System.Xml.Serialization.XmlEnumAttribute("SizeName-StyleName-CustomerPackageType")] SizeNameStyleNameCustomerPackageType, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum KitchenVariationDataVariationTheme { Size, Color, [System.Xml.Serialization.XmlEnumAttribute("Size-Color")] SizeColor, [System.Xml.Serialization.XmlEnumAttribute("DisplayLength-DisplayWidth")] DisplayLengthDisplayWidth, [System.Xml.Serialization.XmlEnumAttribute("DisplayLength-Material")] DisplayLengthMaterial, [System.Xml.Serialization.XmlEnumAttribute("DisplayLength-Size")] DisplayLengthSize, [System.Xml.Serialization.XmlEnumAttribute("DisplayLength-Color")] DisplayLengthColor, [System.Xml.Serialization.XmlEnumAttribute("DisplayLength-DisplayHeight")] DisplayLengthDisplayHeight, [System.Xml.Serialization.XmlEnumAttribute("DisplayWidth-Material")] DisplayWidthMaterial, [System.Xml.Serialization.XmlEnumAttribute("DisplayWidth-Size")] DisplayWidthSize, [System.Xml.Serialization.XmlEnumAttribute("DisplayWidth-Color")] DisplayWidthColor, [System.Xml.Serialization.XmlEnumAttribute("DisplayWidth-DisplayHeight")] DisplayWidthDisplayHeight, [System.Xml.Serialization.XmlEnumAttribute("ItemPackageQuantity-Material")] ItemPackageQuantityMaterial, [System.Xml.Serialization.XmlEnumAttribute("ItemPackageQuantity-Size")] ItemPackageQuantitySize, [System.Xml.Serialization.XmlEnumAttribute("ItemPackageQuantity-Color")] ItemPackageQuantityColor, [System.Xml.Serialization.XmlEnumAttribute("ItemPackageQuantity-DisplayHeight")] ItemPackageQuantityDisplayHeight, [System.Xml.Serialization.XmlEnumAttribute("DisplayWeight-ItemPackageQuantity")] DisplayWeightItemPackageQuantity, [System.Xml.Serialization.XmlEnumAttribute("DisplayWeight-Material")] DisplayWeightMaterial, [System.Xml.Serialization.XmlEnumAttribute("DisplayWeight-Size")] DisplayWeightSize, [System.Xml.Serialization.XmlEnumAttribute("DisplayWeight-Color")] DisplayWeightColor, [System.Xml.Serialization.XmlEnumAttribute("DisplayWeight-DisplayHeight")] DisplayWeightDisplayHeight, [System.Xml.Serialization.XmlEnumAttribute("Material-DisplayLength")] MaterialDisplayLength, [System.Xml.Serialization.XmlEnumAttribute("Material-DisplayWidth")] MaterialDisplayWidth, [System.Xml.Serialization.XmlEnumAttribute("Material-Size")] MaterialSize, [System.Xml.Serialization.XmlEnumAttribute("Material-Color")] MaterialColor, [System.Xml.Serialization.XmlEnumAttribute("Material-DisplayHeight")] MaterialDisplayHeight, [System.Xml.Serialization.XmlEnumAttribute("Size-DisplayLength")] SizeDisplayLength, [System.Xml.Serialization.XmlEnumAttribute("Size-DisplayWidth")] SizeDisplayWidth, [System.Xml.Serialization.XmlEnumAttribute("Size-DisplayWeight")] SizeDisplayWeight, [System.Xml.Serialization.XmlEnumAttribute("Size-Material")] SizeMaterial, [System.Xml.Serialization.XmlEnumAttribute("Size-Color")] SizeColor1, [System.Xml.Serialization.XmlEnumAttribute("Size-DisplayHeight")] SizeDisplayHeight, [System.Xml.Serialization.XmlEnumAttribute("Color-DisplayLength")] ColorDisplayLength, [System.Xml.Serialization.XmlEnumAttribute("Color-DisplayWidth")] ColorDisplayWidth, [System.Xml.Serialization.XmlEnumAttribute("Color-ItemPackageQuantity")] ColorItemPackageQuantity, [System.Xml.Serialization.XmlEnumAttribute("Color-DisplayWeight")] ColorDisplayWeight, [System.Xml.Serialization.XmlEnumAttribute("Color-Material")] ColorMaterial, [System.Xml.Serialization.XmlEnumAttribute("Color-Size")] ColorSize, [System.Xml.Serialization.XmlEnumAttribute("Color-DisplayHeight")] ColorDisplayHeight, DisplayHeight, Material, DisplayWeight, DisplayLength, ItemPackageQuantity, [System.Xml.Serialization.XmlEnumAttribute("DisplayLength-PatternName")] DisplayLengthPatternName, [System.Xml.Serialization.XmlEnumAttribute("DisplayLength-StyleName")] DisplayLengthStyleName, [System.Xml.Serialization.XmlEnumAttribute("DisplayWidth-PatternName")] DisplayWidthPatternName, [System.Xml.Serialization.XmlEnumAttribute("DisplayWidth-StyleName")] DisplayWidthStyleName, [System.Xml.Serialization.XmlEnumAttribute("Occasion-PatternName")] OccasionPatternName, [System.Xml.Serialization.XmlEnumAttribute("Occasion-ItemPackageQuantity")] OccasionItemPackageQuantity, [System.Xml.Serialization.XmlEnumAttribute("Occasion-Material")] OccasionMaterial, [System.Xml.Serialization.XmlEnumAttribute("Occasion-StyleName")] OccasionStyleName, [System.Xml.Serialization.XmlEnumAttribute("Occasion-Size")] OccasionSize, [System.Xml.Serialization.XmlEnumAttribute("Occasion-Color")] OccasionColor, [System.Xml.Serialization.XmlEnumAttribute("Occasion-DisplayHeight")] OccasionDisplayHeight, [System.Xml.Serialization.XmlEnumAttribute("PatternName-DisplayLength")] PatternNameDisplayLength, [System.Xml.Serialization.XmlEnumAttribute("PatternName-DisplayWidth")] PatternNameDisplayWidth, [System.Xml.Serialization.XmlEnumAttribute("PatternName-Occasion")] PatternNameOccasion, [System.Xml.Serialization.XmlEnumAttribute("PatternName-Material")] PatternNameMaterial, [System.Xml.Serialization.XmlEnumAttribute("PatternName-StyleName")] PatternNameStyleName, [System.Xml.Serialization.XmlEnumAttribute("PatternName-Size")] PatternNameSize, [System.Xml.Serialization.XmlEnumAttribute("PatternName-Color")] PatternNameColor, [System.Xml.Serialization.XmlEnumAttribute("PatternName-DisplayHeight")] PatternNameDisplayHeight, [System.Xml.Serialization.XmlEnumAttribute("MatteStyle-Material")] MatteStyleMaterial, [System.Xml.Serialization.XmlEnumAttribute("MatteStyle-StyleName")] MatteStyleStyleName, [System.Xml.Serialization.XmlEnumAttribute("MatteStyle-Size")] MatteStyleSize, [System.Xml.Serialization.XmlEnumAttribute("MatteStyle-Color")] MatteStyleColor, [System.Xml.Serialization.XmlEnumAttribute("ItemPackageQuantity-Occasion")] ItemPackageQuantityOccasion, [System.Xml.Serialization.XmlEnumAttribute("ItemPackageQuantity-StyleName")] ItemPackageQuantityStyleName, [System.Xml.Serialization.XmlEnumAttribute("DisplayWeight-StyleName")] DisplayWeightStyleName, [System.Xml.Serialization.XmlEnumAttribute("Material-PatternName")] MaterialPatternName, [System.Xml.Serialization.XmlEnumAttribute("Material-MatteStyle")] MaterialMatteStyle, [System.Xml.Serialization.XmlEnumAttribute("Material-StyleName")] MaterialStyleName, [System.Xml.Serialization.XmlEnumAttribute("StyleName-DisplayLength")] StyleNameDisplayLength, [System.Xml.Serialization.XmlEnumAttribute("StyleName-DisplayWidth")] StyleNameDisplayWidth, [System.Xml.Serialization.XmlEnumAttribute("StyleName-Occasion")] StyleNameOccasion, [System.Xml.Serialization.XmlEnumAttribute("StyleName-PatternName")] StyleNamePatternName, [System.Xml.Serialization.XmlEnumAttribute("StyleName-DisplayWeight")] StyleNameDisplayWeight, [System.Xml.Serialization.XmlEnumAttribute("StyleName-Material")] StyleNameMaterial, [System.Xml.Serialization.XmlEnumAttribute("StyleName-Size")] StyleNameSize, [System.Xml.Serialization.XmlEnumAttribute("StyleName-Color")] StyleNameColor, [System.Xml.Serialization.XmlEnumAttribute("Size-Occasion")] SizeOccasion, [System.Xml.Serialization.XmlEnumAttribute("Size-PatternName")] SizePatternName, [System.Xml.Serialization.XmlEnumAttribute("Size-MatteStyle")] SizeMatteStyle, [System.Xml.Serialization.XmlEnumAttribute("Size-StyleName")] SizeStyleName, [System.Xml.Serialization.XmlEnumAttribute("Color-Occasion")] ColorOccasion, [System.Xml.Serialization.XmlEnumAttribute("Color-PatternName")] ColorPatternName, [System.Xml.Serialization.XmlEnumAttribute("Color-MatteStyle")] ColorMatteStyle, [System.Xml.Serialization.XmlEnumAttribute("Color-StyleName")] ColorStyleName, MatteStyle, PatternName, Occasion, StyleName, CustomerPackageType, [System.Xml.Serialization.XmlEnumAttribute("ColorName-CustomerPackageType")] ColorNameCustomerPackageType, [System.Xml.Serialization.XmlEnumAttribute("SizeName-CustomerPackageType")] SizeNameCustomerPackageType, [System.Xml.Serialization.XmlEnumAttribute("SizeName-ColorName-CustomerPackageType")] SizeNameColorNameCustomerPackageType, [System.Xml.Serialization.XmlEnumAttribute("StyleName-CustomerPackageType")] StyleNameCustomerPackageType, [System.Xml.Serialization.XmlEnumAttribute("SizeName-StyleName-CustomerPackageType")] SizeNameStyleNameCustomerPackageType, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum OutdoorLivingVariationDataVariationTheme { Size, Color, [System.Xml.Serialization.XmlEnumAttribute("Size-Color")] SizeColor, [System.Xml.Serialization.XmlEnumAttribute("ItemDisplayLength-ItemDisplayWidth")] ItemDisplayLengthItemDisplayWidth, [System.Xml.Serialization.XmlEnumAttribute("ItemDisplayLength-MaterialType")] ItemDisplayLengthMaterialType, [System.Xml.Serialization.XmlEnumAttribute("ItemDisplayLength-SizeName")] ItemDisplayLengthSizeName, [System.Xml.Serialization.XmlEnumAttribute("ItemDisplayLength-ColorName")] ItemDisplayLengthColorName, [System.Xml.Serialization.XmlEnumAttribute("ItemDisplayLength-ItemDisplayHeight")] ItemDisplayLengthItemDisplayHeight, [System.Xml.Serialization.XmlEnumAttribute("ItemDisplayWidth-MaterialType")] ItemDisplayWidthMaterialType, [System.Xml.Serialization.XmlEnumAttribute("ItemDisplayWidth-SizeName")] ItemDisplayWidthSizeName, [System.Xml.Serialization.XmlEnumAttribute("ItemDisplayWidth-ColorName")] ItemDisplayWidthColorName, [System.Xml.Serialization.XmlEnumAttribute("ItemDisplayWidth-ItemDisplayHeight")] ItemDisplayWidthItemDisplayHeight, [System.Xml.Serialization.XmlEnumAttribute("ItemPackageQuantity-MaterialType")] ItemPackageQuantityMaterialType, [System.Xml.Serialization.XmlEnumAttribute("ItemPackageQuantity-SizeName")] ItemPackageQuantitySizeName, [System.Xml.Serialization.XmlEnumAttribute("ItemPackageQuantity-ColorName")] ItemPackageQuantityColorName, [System.Xml.Serialization.XmlEnumAttribute("ItemPackageQuantity-ItemDisplayHeight")] ItemPackageQuantityItemDisplayHeight, [System.Xml.Serialization.XmlEnumAttribute("ItemDisplayWeight-ItemPackageQuantity")] ItemDisplayWeightItemPackageQuantity, [System.Xml.Serialization.XmlEnumAttribute("ItemDisplayWeight-MaterialType")] ItemDisplayWeightMaterialType, [System.Xml.Serialization.XmlEnumAttribute("ItemDisplayWeight-SizeName")] ItemDisplayWeightSizeName, [System.Xml.Serialization.XmlEnumAttribute("ItemDisplayWeight-ColorName")] ItemDisplayWeightColorName, [System.Xml.Serialization.XmlEnumAttribute("ItemDisplayWeight-ItemDisplayHeight")] ItemDisplayWeightItemDisplayHeight, [System.Xml.Serialization.XmlEnumAttribute("MaterialType-ItemDisplayLength")] MaterialTypeItemDisplayLength, [System.Xml.Serialization.XmlEnumAttribute("MaterialType-ItemDisplayWidth")] MaterialTypeItemDisplayWidth, [System.Xml.Serialization.XmlEnumAttribute("MaterialType-SizeName")] MaterialTypeSizeName, [System.Xml.Serialization.XmlEnumAttribute("MaterialType-ColorName")] MaterialTypeColorName, [System.Xml.Serialization.XmlEnumAttribute("MaterialType-ItemDisplayHeight")] MaterialTypeItemDisplayHeight, [System.Xml.Serialization.XmlEnumAttribute("SizeName-ItemDisplayLength")] SizeNameItemDisplayLength, [System.Xml.Serialization.XmlEnumAttribute("SizeName-ItemDisplayWidth")] SizeNameItemDisplayWidth, [System.Xml.Serialization.XmlEnumAttribute("SizeName-ItemDisplayWeight")] SizeNameItemDisplayWeight, [System.Xml.Serialization.XmlEnumAttribute("SizeName-MaterialType")] SizeNameMaterialType, [System.Xml.Serialization.XmlEnumAttribute("SizeName-ColorName")] SizeNameColorName, [System.Xml.Serialization.XmlEnumAttribute("SizeName-ItemDisplayHeight")] SizeNameItemDisplayHeight, [System.Xml.Serialization.XmlEnumAttribute("ColorName-ItemDisplayLength")] ColorNameItemDisplayLength, [System.Xml.Serialization.XmlEnumAttribute("ColorName-ItemDisplayWidth")] ColorNameItemDisplayWidth, [System.Xml.Serialization.XmlEnumAttribute("ColorName-ItemPackageQuantity")] ColorNameItemPackageQuantity, [System.Xml.Serialization.XmlEnumAttribute("ColorName-ItemDisplayWeight")] ColorNameItemDisplayWeight, [System.Xml.Serialization.XmlEnumAttribute("ColorName-MaterialType")] ColorNameMaterialType, [System.Xml.Serialization.XmlEnumAttribute("ColorName-SizeName")] ColorNameSizeName, [System.Xml.Serialization.XmlEnumAttribute("ColorName-ItemDisplayHeight")] ColorNameItemDisplayHeight, ItemDisplayHeight, MaterialType, ItemDisplayWeight, ItemDisplayLength, ItemPackageQuantity, [System.Xml.Serialization.XmlEnumAttribute("ItemDisplayLength-PatternName")] ItemDisplayLengthPatternName, [System.Xml.Serialization.XmlEnumAttribute("ItemDisplayLength-StyleName")] ItemDisplayLengthStyleName, [System.Xml.Serialization.XmlEnumAttribute("ItemDisplayWidth-PatternName")] ItemDisplayWidthPatternName, [System.Xml.Serialization.XmlEnumAttribute("ItemDisplayWidth-StyleName")] ItemDisplayWidthStyleName, [System.Xml.Serialization.XmlEnumAttribute("Occasion-PatternName")] OccasionPatternName, [System.Xml.Serialization.XmlEnumAttribute("Occasion-ItemPackageQuantity")] OccasionItemPackageQuantity, [System.Xml.Serialization.XmlEnumAttribute("Occasion-MaterialType")] OccasionMaterialType, [System.Xml.Serialization.XmlEnumAttribute("Occasion-StyleName")] OccasionStyleName, [System.Xml.Serialization.XmlEnumAttribute("Occasion-SizeName")] OccasionSizeName, [System.Xml.Serialization.XmlEnumAttribute("Occasion-ColorName")] OccasionColorName, [System.Xml.Serialization.XmlEnumAttribute("Occasion-ItemDisplayHeight")] OccasionItemDisplayHeight, [System.Xml.Serialization.XmlEnumAttribute("PatternName-ItemDisplayLength")] PatternNameItemDisplayLength, [System.Xml.Serialization.XmlEnumAttribute("PatternName-ItemDisplayWidth")] PatternNameItemDisplayWidth, [System.Xml.Serialization.XmlEnumAttribute("PatternName-Occasion")] PatternNameOccasion, [System.Xml.Serialization.XmlEnumAttribute("PatternName-MaterialType")] PatternNameMaterialType, [System.Xml.Serialization.XmlEnumAttribute("PatternName-StyleName")] PatternNameStyleName, [System.Xml.Serialization.XmlEnumAttribute("PatternName-SizeName")] PatternNameSizeName, [System.Xml.Serialization.XmlEnumAttribute("PatternName-ColorName")] PatternNameColorName, [System.Xml.Serialization.XmlEnumAttribute("PatternName-ItemDisplayHeight")] PatternNameItemDisplayHeight, [System.Xml.Serialization.XmlEnumAttribute("MatteStyle-MaterialType")] MatteStyleMaterialType, [System.Xml.Serialization.XmlEnumAttribute("MatteStyle-StyleName")] MatteStyleStyleName, [System.Xml.Serialization.XmlEnumAttribute("MatteStyle-SizeName")] MatteStyleSizeName, [System.Xml.Serialization.XmlEnumAttribute("MatteStyle-ColorName")] MatteStyleColorName, [System.Xml.Serialization.XmlEnumAttribute("ItemPackageQuantity-Occasion")] ItemPackageQuantityOccasion, [System.Xml.Serialization.XmlEnumAttribute("ItemPackageQuantity-StyleName")] ItemPackageQuantityStyleName, [System.Xml.Serialization.XmlEnumAttribute("ItemDisplayWeight-StyleName")] ItemDisplayWeightStyleName, [System.Xml.Serialization.XmlEnumAttribute("MaterialType-PatternName")] MaterialTypePatternName, [System.Xml.Serialization.XmlEnumAttribute("MaterialType-MatteStyle")] MaterialTypeMatteStyle, [System.Xml.Serialization.XmlEnumAttribute("MaterialType-StyleName")] MaterialTypeStyleName, [System.Xml.Serialization.XmlEnumAttribute("StyleName-ItemDisplayLength")] StyleNameItemDisplayLength, [System.Xml.Serialization.XmlEnumAttribute("StyleName-ItemDisplayWidth")] StyleNameItemDisplayWidth, [System.Xml.Serialization.XmlEnumAttribute("StyleName-Occasion")] StyleNameOccasion, [System.Xml.Serialization.XmlEnumAttribute("StyleName-PatternName")] StyleNamePatternName, [System.Xml.Serialization.XmlEnumAttribute("StyleName-ItemDisplayWeight")] StyleNameItemDisplayWeight, [System.Xml.Serialization.XmlEnumAttribute("StyleName-MaterialType")] StyleNameMaterialType, [System.Xml.Serialization.XmlEnumAttribute("StyleName-SizeName")] StyleNameSizeName, [System.Xml.Serialization.XmlEnumAttribute("StyleName-ColorName")] StyleNameColorName, [System.Xml.Serialization.XmlEnumAttribute("SizeName-Occasion")] SizeNameOccasion, [System.Xml.Serialization.XmlEnumAttribute("SizeName-PatternName")] SizeNamePatternName, [System.Xml.Serialization.XmlEnumAttribute("SizeName-MatteStyle")] SizeNameMatteStyle, [System.Xml.Serialization.XmlEnumAttribute("SizeName-StyleName")] SizeNameStyleName, [System.Xml.Serialization.XmlEnumAttribute("ColorName-Occasion")] ColorNameOccasion, [System.Xml.Serialization.XmlEnumAttribute("ColorName-PatternName")] ColorNamePatternName, [System.Xml.Serialization.XmlEnumAttribute("ColorName-MatteStyle")] ColorNameMatteStyle, [System.Xml.Serialization.XmlEnumAttribute("ColorName-StyleName")] ColorNameStyleName, MatteStyle, PatternName, Occasion, StyleName, ScentName, CustomerPackageType, [System.Xml.Serialization.XmlEnumAttribute("ColorName-CustomerPackageType")] ColorNameCustomerPackageType, [System.Xml.Serialization.XmlEnumAttribute("SizeName-CustomerPackageType")] SizeNameCustomerPackageType, [System.Xml.Serialization.XmlEnumAttribute("SizeName-ColorName-CustomerPackageType")] SizeNameColorNameCustomerPackageType, [System.Xml.Serialization.XmlEnumAttribute("StyleName-CustomerPackageType")] StyleNameCustomerPackageType, [System.Xml.Serialization.XmlEnumAttribute("SizeName-StyleName-CustomerPackageType")] SizeNameStyleNameCustomerPackageType, MetalType, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum SeedsAndPlantsVariationDataVariationTheme { Size, Color, [System.Xml.Serialization.XmlEnumAttribute("Size-Color")] SizeColor, StyleName, ScentName, CustomerPackageType, [System.Xml.Serialization.XmlEnumAttribute("ColorName-CustomerPackageType")] ColorNameCustomerPackageType, [System.Xml.Serialization.XmlEnumAttribute("SizeName-CustomerPackageType")] SizeNameCustomerPackageType, [System.Xml.Serialization.XmlEnumAttribute("SizeName-ColorName-CustomerPackageType")] SizeNameColorNameCustomerPackageType, [System.Xml.Serialization.XmlEnumAttribute("StyleName-CustomerPackageType")] StyleNameCustomerPackageType, [System.Xml.Serialization.XmlEnumAttribute("SizeName-StyleName-CustomerPackageType")] SizeNameStyleNameCustomerPackageType, }

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class HomeProductTypeHomeVariationData
	{

		private static System.Xml.Serialization.XmlSerializer serializer;

		public HomeProductTypeHomeVariationDataVariationTheme VariationTheme { get; set; }

		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool VariationThemeSpecified { get; set; }

		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
		public string Size { get; set; }

		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
		public string Color { get; set; }

		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
		public string Scent { get; set; }
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum HomeProductTypeHomeVariationDataVariationTheme
	{

		/// <remarks/>
		Size,

		/// <remarks/>
		Color,

		/// <remarks/>
		Scent,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("Size-Color")]
		SizeColor,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("Size-Scent")]
		SizeScent,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("DisplayLength-DisplayWidth")]
		DisplayLengthDisplayWidth,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("DisplayLength-Material")]
		DisplayLengthMaterial,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("DisplayLength-Size")]
		DisplayLengthSize,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("DisplayLength-Color")]
		DisplayLengthColor,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("DisplayLength-DisplayHeight")]
		DisplayLengthDisplayHeight,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("DisplayWidth-Material")]
		DisplayWidthMaterial,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("DisplayWidth-Size")]
		DisplayWidthSize,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("DisplayWidth-Color")]
		DisplayWidthColor,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("DisplayWidth-DisplayHeight")]
		DisplayWidthDisplayHeight,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("ItemPackageQuantity-Material")]
		ItemPackageQuantityMaterial,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("ItemPackageQuantity-Size")]
		ItemPackageQuantitySize,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("ItemPackageQuantity-Color")]
		ItemPackageQuantityColor,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("ItemPackageQuantity-DisplayHeight")]
		ItemPackageQuantityDisplayHeight,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("DisplayWeight-ItemPackageQuantity")]
		DisplayWeightItemPackageQuantity,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("DisplayWeight-Material")]
		DisplayWeightMaterial,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("DisplayWeight-Size")]
		DisplayWeightSize,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("DisplayWeight-Color")]
		DisplayWeightColor,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("DisplayWeight-DisplayHeight")]
		DisplayWeightDisplayHeight,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("Material-DisplayLength")]
		MaterialDisplayLength,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("Material-DisplayWidth")]
		MaterialDisplayWidth,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("Material-Size")]
		MaterialSize,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("Material-Color")]
		MaterialColor,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("Material-DisplayHeight")]
		MaterialDisplayHeight,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("Size-DisplayLength")]
		SizeDisplayLength,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("Size-DisplayWidth")]
		SizeDisplayWidth,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("Size-DisplayWeight")]
		SizeDisplayWeight,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("Size-Material")]
		SizeMaterial,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("Size-Color")]
		SizeColor1,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("Size-DisplayHeight")]
		SizeDisplayHeight,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("Color-DisplayLength")]
		ColorDisplayLength,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("Color-DisplayWidth")]
		ColorDisplayWidth,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("Color-ItemPackageQuantity")]
		ColorItemPackageQuantity,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("Color-DisplayWeight")]
		ColorDisplayWeight,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("Color-Material")]
		ColorMaterial,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("Color-Size")]
		ColorSize,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("Color-DisplayHeight")]
		ColorDisplayHeight,

		/// <remarks/>
		DisplayHeight,

		/// <remarks/>
		Material,

		/// <remarks/>
		DisplayWeight,

		/// <remarks/>
		DisplayLength,

		/// <remarks/>
		ItemPackageQuantity,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("DisplayLength-PatternName")]
		DisplayLengthPatternName,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("DisplayLength-StyleName")]
		DisplayLengthStyleName,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("DisplayWidth-PatternName")]
		DisplayWidthPatternName,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("DisplayWidth-StyleName")]
		DisplayWidthStyleName,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("Occasion-PatternName")]
		OccasionPatternName,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("Occasion-ItemPackageQuantity")]
		OccasionItemPackageQuantity,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("Occasion-Material")]
		OccasionMaterial,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("Occasion-StyleName")]
		OccasionStyleName,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("Occasion-Size")]
		OccasionSize,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("Occasion-Color")]
		OccasionColor,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("Occasion-DisplayHeight")]
		OccasionDisplayHeight,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("PatternName-DisplayLength")]
		PatternNameDisplayLength,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("PatternName-DisplayWidth")]
		PatternNameDisplayWidth,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("PatternName-Occasion")]
		PatternNameOccasion,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("PatternName-Material")]
		PatternNameMaterial,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("PatternName-StyleName")]
		PatternNameStyleName,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("PatternName-Size")]
		PatternNameSize,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("PatternName-Color")]
		PatternNameColor,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("PatternName-DisplayHeight")]
		PatternNameDisplayHeight,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("MatteStyle-Material")]
		MatteStyleMaterial,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("MatteStyle-StyleName")]
		MatteStyleStyleName,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("MatteStyle-Size")]
		MatteStyleSize,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("MatteStyle-Color")]
		MatteStyleColor,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("ItemPackageQuantity-Occasion")]
		ItemPackageQuantityOccasion,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("ItemPackageQuantity-StyleName")]
		ItemPackageQuantityStyleName,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("DisplayWeight-StyleName")]
		DisplayWeightStyleName,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("Material-PatternName")]
		MaterialPatternName,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("Material-MatteStyle")]
		MaterialMatteStyle,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("Material-StyleName")]
		MaterialStyleName,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("StyleName-DisplayLength")]
		StyleNameDisplayLength,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("StyleName-DisplayWidth")]
		StyleNameDisplayWidth,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("StyleName-Occasion")]
		StyleNameOccasion,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("StyleName-PatternName")]
		StyleNamePatternName,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("StyleName-DisplayWeight")]
		StyleNameDisplayWeight,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("StyleName-Material")]
		StyleNameMaterial,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("StyleName-Size")]
		StyleNameSize,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("StyleName-Color")]
		StyleNameColor,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("Size-Occasion")]
		SizeOccasion,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("Size-PatternName")]
		SizePatternName,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("Size-MatteStyle")]
		SizeMatteStyle,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("Size-StyleName")]
		SizeStyleName,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("Color-Occasion")]
		ColorOccasion,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("Color-PatternName")]
		ColorPatternName,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("Color-MatteStyle")]
		ColorMatteStyle,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("Color-StyleName")]
		ColorStyleName,

		/// <remarks/>
		MatteStyle,

		/// <remarks/>
		PatternName,

		/// <remarks/>
		Occasion,

		/// <remarks/>
		StyleName,

		/// <remarks/>
		CustomerPackageType,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("ColorName-CustomerPackageType")]
		ColorNameCustomerPackageType,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("SizeName-CustomerPackageType")]
		SizeNameCustomerPackageType,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("SizeName-ColorName-CustomerPackageType")]
		SizeNameColorNameCustomerPackageType,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("StyleName-CustomerPackageType")]
		StyleNameCustomerPackageType,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("SizeName-StyleName-CustomerPackageType")]
		SizeNameStyleNameCustomerPackageType,
	}
}
