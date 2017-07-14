using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class Arts : ProductProductData
	{
	}


	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class ArtsVariationData
	{
		private static System.Xml.Serialization.XmlSerializer serializer; public ArtsVariationDataParentage Parentage { get; set; }
		public ArtsVariationDataVariationTheme VariationTheme { get; set; }
		[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; }
		private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ArtsVariationData)); } return serializer; } }
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum ArtsVariationDataParentage
	{

		/// <remarks/>
		parent,

		/// <remarks/>
		child,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum ArtsVariationDataVariationTheme
	{
		SizeName, FrameMaterial, [System.Xml.Serialization.XmlEnumAttribute("Size-Material")] SizeMaterial,
	}



	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public partial class Luggage
	{
		private LuggageVariationData variationDataField; private Battery batteryField; private VolumeDimension volumeCapacityNameField; private List<string> specialFeaturesField; private WeightDimension lithiumBatteryWeightField; private LengthDimension shoulderStrapDropField; private LengthDimension minimumCircumferenceField; private LengthDimension maximumCircumferenceField; private LengthDimension displaySizeField; private AgeRecommendedDimension manufacturerMinimumAgeField; private List<string> performanceRatingField; private List<string> specificUsesForProductField; private static System.Xml.Serialization.XmlSerializer serializer; public LuggageProductType ProductType { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Model { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string ModelName { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string MaterialType { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string ClosureType { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string ShellType { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string TeamName { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string InnerMaterialType { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Collection { get; set; }
		public bool IsStainResistant { get; set; }
		[System.Xml.Serialization.XmlIgnoreAttribute()] public bool IsStainResistantSpecified { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string StrapType { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")] public string NumberOfWheels { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string WheelType { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string ColorMap { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Lifestyle { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Size { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Certification { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Season { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Department { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string OuterMaterialType { get; set; }
		public BatteryCellTypeValues BatteryComposition { get; set; }
		[System.Xml.Serialization.XmlIgnoreAttribute()] public bool BatteryCompositionSpecified { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string LoadConfiguration { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string LeatherType { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")] public string ModelYear { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Style { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string FabricType { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Color { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string LiningDescription { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string BatteryDescription { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Specifications { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string BatteryFormFactor { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Pattern { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string LockType { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Character { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Warranty { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")] public string NumberOfCompartments { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string OccasionType { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string CompartmentDescription { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string HandleType { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string HarmonizedCode { get; set; }
		public bool VeryHighValue { get; set; }
		[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VeryHighValueSpecified { get; set; }
		public WaterResistantType WaterResistance { get; set; }
		[System.Xml.Serialization.XmlIgnoreAttribute()] public bool WaterResistanceSpecified { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string WearResistance { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string WarrantyType { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string SizeMap { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string CareInstructions { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string IncludedComponents { get; set; }
		public bool IsAdultProduct { get; set; }
		[System.Xml.Serialization.XmlIgnoreAttribute()] public bool IsAdultProductSpecified { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string SellerWarrantyDescription { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string PatternType { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Theme { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Opacity { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string MfrWarrantyDescriptionType { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string MfrWarrantyDescriptionParts { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string MfrWarrantyDescriptionLabor { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string FabricWash { get; set; }
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string CapacityName { get; set; }
		
		[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum ArtsVariationDataParentage { parent, child, }

		[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
		[System.SerializableAttribute()]
		[System.ComponentModel.DesignerCategoryAttribute("code")]
		[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
		public partial class ArtsProductType
		{

			[System.Xml.Serialization.XmlElementAttribute("FineArt", typeof(FineArt))]
			[System.Xml.Serialization.XmlElementAttribute("FineArtEditioned", typeof(FineArtEditioned))]
			public object Item { get; set; }
		}

	}


}
