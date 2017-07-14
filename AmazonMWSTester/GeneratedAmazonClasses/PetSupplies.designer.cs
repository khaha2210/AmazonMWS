// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.32989
//    <NameSpace>AmazonMWSTester.Amazon</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net40</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><OrderXMLAttrib>False</OrderXMLAttrib><EnableEncoding>False</EnableEncoding><AutomaticProperties>True</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace AmazonMWSTester.Amazon {
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Collections.Generic;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class PetSupplies {
        
        private PetSuppliesProductType productTypeField;
        
    public PetSuppliesProductType ProductType {get; set;}

        
        public PetSupplies() {
            this.productTypeField = new PetSuppliesProductType();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class PetSuppliesMisc {
        
        private PetSuppliesMiscVariationData variationDataField;
        
        private List<AllergenInformationType> allergenInformationField;
        
        private Battery batteryField;
        
        private BatteryLifeDimension batteryAverageLifeField;
        
        private BatteryLifeDimension batteryAverageLifeStandbyField;
        
        private BatteryPowerDimension batteryCapacityField;
        
        private bool batteryCellCompositionFieldSpecified;
        
        private TimeDimension batteryChargeTimeField;
        
        private string batteryFormFactorField;
        
        private BatteryPowerIntegerDimension batteryPowerField;
        
        private string breedRecommendationField;
        
        private TimeIntegerDimension bulbLifeSpanField;
        
        private List<string> careInstructionsField;
        
        private string closureTypeField;
        
        private List<string> compatibleDevicesField;
        
        private bool containsFoodOrBeverageField;
        
        private bool containsFoodOrBeverageFieldSpecified;
        
        private string countryOfOriginField;
        
        private PetSuppliesMiscColorSpecification colorSpecificationField;
        
        private string directionsField;
        
        private LengthDimension displayLengthField;
        
        private VolumeDimension displayVolumeField;
        
        private WeightDimension displayWeightField;
        
        private string dogSizeField;
        
        private string energyEfficiencyRatingField;
        
        private string eUEnergyLabelEfficiencyClassField;
        
        private List<string> externalCertificationField;
        
        private string fillMaterialTypeField;
        
        private string flavorField;
        
        private GirthSizeType girthSizeField;
        
        private HeightRecommendationType heightRecommendationField;
        
        private List<string> healthBenefitsField;
        
        private List<string> includedComponentsField;
        
        private bool includesAcAdapterField;
        
        private bool includesAcAdapterFieldSpecified;
        
        private bool includesRemoteField;
        
        private bool includesRemoteFieldSpecified;
        
        private string ingredientsField;
        
        private string innerMaterialTypeField;
        
        private bool isExpirationDatedProductField;
        
        private bool isExpirationDatedProductFieldSpecified;
        
        private bool isAssemblyRequiredField;
        
        private bool isAssemblyRequiredFieldSpecified;
        
        private bool isPortableField;
        
        private bool isPortableFieldSpecified;
        
        private LengthDimension itemDiameterField;
        
        private LengthDimension itemDisplayDiameterField;
        
        private LengthDimension itemDisplayHeightField;
        
        private LengthDimension itemDisplayWidthField;
        
        private string itemFormField;
        
        private LengthDimension itemThicknessField;
        
        private string itemPackageQuantityField;
        
        private LuminancePositiveIntegerDimension lightOutputLuminanceField;
        
        private decimal lithiumBatteryEnergyContentField;
        
        private bool lithiumBatteryEnergyContentFieldSpecified;
        
        private bool lithiumBatteryPackagingFieldSpecified;
        
        private decimal lithiumBatteryVoltageField;
        
        private bool lithiumBatteryVoltageFieldSpecified;
        
        private decimal lithiumBatteryWeightField;
        
        private bool lithiumBatteryWeightFieldSpecified;
        
        private string materialField;
        
        private List<string> materialCompositionField;
        
        private string maxOrderingQuantityField;
        
        private string maximumAgeRecommendationField;
        
        private PetPowerDimension maximumPowerField;
        
        private string mfgWarrantyDescriptionLaborField;
        
        private string mfgWarrantyDescriptionPartsField;
        
        private string mfgWarrantyDescriptionTypeField;
        
        private string minimumAgeRecommendationField;
        
        private NeckSizeType neckSizeField;
        
        private string numberOfItemsField;
        
        private string numberOfLithiumIonCellsField;
        
        private string numberOfLithiumMetalCellsField;
        
        private string nutritionFactsField;
        
        private string outerMaterialTypeField;
        
        private string patternNameField;
        
        private string petLifeStageField;
        
        private List<string> petTypeField;
        
        private string powerSourceTypeField;
        
        private string productFeatureField;
        
        private System.DateTime productSampleReceivedDateField;
        
        private bool productSampleReceivedDateFieldSpecified;
        
        private string recommendedUsesForProductField;
        
        private decimal recycledContentPercentageField;
        
        private bool recycledContentPercentageFieldSpecified;
        
        private string sellerWarrantyDescriptionField;
        
        private string scentNameField;
        
        private string sizeField;
        
        private string sizeMapField;
        
        private List<string> specialFeaturesField;
        
        private string specificationMetField;
        
        private string storageInstructionsField;
        
        private VolumeDimension tankSizeField;
        
        private bool targetGenderFieldSpecified;
        
        private string voltageField;
        
        private VolumeDimension volumeField;
        
        private string warningsField;
        
        private string wattageField;
        
        private WeightRecommendationType weightRecommendationField;
        
        private WidthSizeType widthSizeField;
        
        private string modelNameField;
        
        private string materialFeaturesField;
        
        private string legalComplianceCertificationRegulatoryOrganizationNameField;
        
        private string legalComplianceCertificationCertifyingAuthorityNameField;
        
        private string legalComplianceCertificationGeographicJurisdictionField;
        
        private bool legalComplianceCertificationStatusFieldSpecified;
        
        private string legalComplianceCertificationMetadataField;
        
        private string legalComplianceCertificationExpirationDateField;
        
        private string legalComplianceCertificationDateOfIssueField;
        
        private string legalComplianceCertificationValueField;
        
    public PetSuppliesMiscVariationData VariationData {get; set;}

    public Battery Battery {get; set;}

    public BatteryLifeDimension BatteryAverageLife {get; set;}

    public BatteryLifeDimension BatteryAverageLifeStandby {get; set;}

    public BatteryPowerDimension BatteryCapacity {get; set;}

    public BatteryCellTypeValues BatteryCellComposition {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool BatteryCellCompositionSpecified {get; set;}

    public TimeDimension BatteryChargeTime {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string BatteryFormFactor {get; set;}

    public BatteryPowerIntegerDimension BatteryPower {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string BreedRecommendation {get; set;}

    public TimeIntegerDimension BulbLifeSpan {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string ClosureType {get; set;}

    public bool ContainsFoodOrBeverage {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ContainsFoodOrBeverageSpecified {get; set;}

    public string CountryOfOrigin {get; set;}

    public PetSuppliesMiscColorSpecification ColorSpecification {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Directions {get; set;}

    public LengthDimension DisplayLength {get; set;}

    public VolumeDimension DisplayVolume {get; set;}

    public WeightDimension DisplayWeight {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string DogSize {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string EnergyEfficiencyRating {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string EUEnergyLabelEfficiencyClass {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string FillMaterialType {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Flavor {get; set;}

    public GirthSizeType GirthSize {get; set;}

    public HeightRecommendationType HeightRecommendation {get; set;}

    public bool IncludesAcAdapter {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool IncludesAcAdapterSpecified {get; set;}

    public bool IncludesRemote {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool IncludesRemoteSpecified {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Ingredients {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string InnerMaterialType {get; set;}

    public bool IsExpirationDatedProduct {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool IsExpirationDatedProductSpecified {get; set;}

    public bool IsAssemblyRequired {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool IsAssemblyRequiredSpecified {get; set;}

    public bool IsPortable {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool IsPortableSpecified {get; set;}

    public LengthDimension ItemDiameter {get; set;}

    public LengthDimension ItemDisplayDiameter {get; set;}

    public LengthDimension ItemDisplayHeight {get; set;}

    public LengthDimension ItemDisplayWidth {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string ItemForm {get; set;}

    public LengthDimension ItemThickness {get; set;}

    public LuminancePositiveIntegerDimension LightOutputLuminance {get; set;}

    public decimal LithiumBatteryEnergyContent {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool LithiumBatteryEnergyContentSpecified {get; set;}

    public PetSuppliesMiscLithiumBatteryPackaging LithiumBatteryPackaging {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool LithiumBatteryPackagingSpecified {get; set;}

    public decimal LithiumBatteryVoltage {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool LithiumBatteryVoltageSpecified {get; set;}

    public decimal LithiumBatteryWeight {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool LithiumBatteryWeightSpecified {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Material {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string MaxOrderingQuantity {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string MaximumAgeRecommendation {get; set;}

    public PetPowerDimension MaximumPower {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string MfgWarrantyDescriptionLabor {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string MfgWarrantyDescriptionParts {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string MfgWarrantyDescriptionType {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string MinimumAgeRecommendation {get; set;}

    public NeckSizeType NeckSize {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string NumberOfItems {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string NumberOfLithiumIonCells {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string NumberOfLithiumMetalCells {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string NutritionFacts {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string OuterMaterialType {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string PatternName {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string PetLifeStage {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string PowerSourceType {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string ProductFeature {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime ProductSampleReceivedDate {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ProductSampleReceivedDateSpecified {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string RecommendedUsesForProduct {get; set;}

    public decimal RecycledContentPercentage {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool RecycledContentPercentageSpecified {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string SellerWarrantyDescription {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string ScentName {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Size {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string SizeMap {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string SpecificationMet {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string StorageInstructions {get; set;}

    public VolumeDimension TankSize {get; set;}

    public TargetGenderType TargetGender {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TargetGenderSpecified {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string Voltage {get; set;}

    public VolumeDimension Volume {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Warnings {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string Wattage {get; set;}

    public WeightRecommendationType WeightRecommendation {get; set;}

    public WidthSizeType WidthSize {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string ModelName {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string MaterialFeatures {get; set;}

    public string LegalComplianceCertificationRegulatoryOrganizationName {get; set;}

    public string LegalComplianceCertificationCertifyingAuthorityName {get; set;}

    public string LegalComplianceCertificationGeographicJurisdiction {get; set;}

    public PetSuppliesMiscLegalComplianceCertificationStatus LegalComplianceCertificationStatus {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool LegalComplianceCertificationStatusSpecified {get; set;}

    public string LegalComplianceCertificationMetadata {get; set;}

    public string LegalComplianceCertificationExpirationDate {get; set;}

    public string LegalComplianceCertificationDateOfIssue {get; set;}

    public string LegalComplianceCertificationValue {get; set;}

        
        public PetSuppliesMisc() {
            this.widthSizeField = new WidthSizeType();
            this.weightRecommendationField = new WeightRecommendationType();
            this.volumeField = new VolumeDimension();
            this.tankSizeField = new VolumeDimension();
            this.specialFeaturesField = new List<string>();
            this.petTypeField = new List<string>();
            this.neckSizeField = new NeckSizeType();
            this.maximumPowerField = new PetPowerDimension();
            this.materialCompositionField = new List<string>();
            this.lightOutputLuminanceField = new LuminancePositiveIntegerDimension();
            this.includedComponentsField = new List<string>();
            this.healthBenefitsField = new List<string>();
            this.heightRecommendationField = new HeightRecommendationType();
            this.girthSizeField = new GirthSizeType();
            this.externalCertificationField = new List<string>();
            this.displayVolumeField = new VolumeDimension();
            this.colorSpecificationField = new PetSuppliesMiscColorSpecification();
            this.compatibleDevicesField = new List<string>();
            this.careInstructionsField = new List<string>();
            this.bulbLifeSpanField = new TimeIntegerDimension();
            this.batteryPowerField = new BatteryPowerIntegerDimension();
            this.batteryChargeTimeField = new TimeDimension();
            this.batteryCapacityField = new BatteryPowerDimension();
            this.batteryAverageLifeStandbyField = new BatteryLifeDimension();
            this.batteryAverageLifeField = new BatteryLifeDimension();
            this.allergenInformationField = new List<AllergenInformationType>();
            this.variationDataField = new PetSuppliesMiscVariationData();
            this.itemPackageQuantityField = "1";
        }
        
        [System.Xml.Serialization.XmlElementAttribute("AllergenInformation")]
        public List<AllergenInformationType> AllergenInformation {
            get {
                return this.allergenInformationField;
            }
            set {
                this.allergenInformationField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("CareInstructions", DataType="normalizedString")]
        public List<string> CareInstructions {
            get {
                return this.careInstructionsField;
            }
            set {
                this.careInstructionsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("CompatibleDevices", DataType="normalizedString")]
        public List<string> CompatibleDevices {
            get {
                return this.compatibleDevicesField;
            }
            set {
                this.compatibleDevicesField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ExternalCertification", DataType="normalizedString")]
        public List<string> ExternalCertification {
            get {
                return this.externalCertificationField;
            }
            set {
                this.externalCertificationField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("HealthBenefits", DataType="normalizedString")]
        public List<string> HealthBenefits {
            get {
                return this.healthBenefitsField;
            }
            set {
                this.healthBenefitsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("IncludedComponents", DataType="normalizedString")]
        public List<string> IncludedComponents {
            get {
                return this.includedComponentsField;
            }
            set {
                this.includedComponentsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        [System.ComponentModel.DefaultValueAttribute("1")]
        public string ItemPackageQuantity {
            get {
                return this.itemPackageQuantityField;
            }
            set {
                this.itemPackageQuantityField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("MaterialComposition", DataType="normalizedString")]
        public List<string> MaterialComposition {
            get {
                return this.materialCompositionField;
            }
            set {
                this.materialCompositionField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PetType", DataType="normalizedString")]
        public List<string> PetType {
            get {
                return this.petTypeField;
            }
            set {
                this.petTypeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("SpecialFeatures", DataType="normalizedString")]
        public List<string> SpecialFeatures {
            get {
                return this.specialFeaturesField;
            }
            set {
                this.specialFeaturesField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class GirthSizeType {
        
        private LengthDimension maximumGirthSizeField;
        
        private LengthDimension minimumGirthSizeField;
        
    public LengthDimension MaximumGirthSize {get; set;}

    public LengthDimension MinimumGirthSize {get; set;}

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class HeightRecommendationType {
        
        private LengthDimension maximumHeightRecommendationField;
        
        private LengthDimension minimumHeightRecommendationField;
        
    public LengthDimension MaximumHeightRecommendation {get; set;}

    public LengthDimension MinimumHeightRecommendation {get; set;}

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class PetPowerDimension {
        
        private decimal valueField;
        
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public PowerUnitOfMeasure unitOfMeasure {get; set;}

    [System.Xml.Serialization.XmlTextAttribute()]
    public decimal Value {get; set;}

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class NeckSizeType {
        
        private LengthDimension maximumNeckSizeField;
        
        private LengthDimension minimumNeckSizeField;
        
    public LengthDimension MaximumNeckSize {get; set;}

    public LengthDimension MinimumNeckSize {get; set;}

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class WidthSizeType {
        
        private LengthDimension maximumWidthSizeField;
        
        private LengthDimension minimumWidthSizeField;
        
    public LengthDimension MaximumWidthSize {get; set;}

    public LengthDimension MinimumWidthSize {get; set;}

    }
}