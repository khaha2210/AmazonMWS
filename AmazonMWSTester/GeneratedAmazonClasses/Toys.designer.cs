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
    public partial class Toys {
        
        private ToysVariationData variationDataField;
        
        private ToysProductType productTypeField;
        
        private Battery batteryField;
        
        private string assemblyInstructionsField;
        
        private AgeRecommendation ageRecommendationField;
        
        private AssemblyTimeDimension assemblyTimeField;
        
        private ColorSpecification colorSpecificationField;
        
        private string editionField;
        
        private bool isAdultProductField;
        
        private bool isAdultProductFieldSpecified;
        
        private bool isAssemblyRequiredField;
        
        private bool isAssemblyRequiredFieldSpecified;
        
        private string manufacturerSafetyWarningField;
        
        private string manufacturerWarrantyDescriptionField;
        
        private WeightRecommendation weightRecommendationField;
        
        private string numberOfPiecesField;
        
        private string numberOfPlayersField;
        
        private string partNumberField;
        
        private Recall recallField;
        
        private string sizeField;
        
        private string sizeMapField;
        
        private string styleNameField;
        
        private List<string> subjectCharacterField;
        
    public ToysVariationData VariationData {get; set;}

    public ToysProductType ProductType {get; set;}

    public Battery Battery {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string AssemblyInstructions {get; set;}

    public AgeRecommendation AgeRecommendation {get; set;}

    public AssemblyTimeDimension AssemblyTime {get; set;}

    public ColorSpecification ColorSpecification {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Edition {get; set;}

    public bool IsAdultProduct {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool IsAdultProductSpecified {get; set;}

    public bool IsAssemblyRequired {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool IsAssemblyRequiredSpecified {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string ManufacturerSafetyWarning {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string ManufacturerWarrantyDescription {get; set;}

    public WeightRecommendation WeightRecommendation {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string NumberOfPieces {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string NumberOfPlayers {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string PartNumber {get; set;}

    public Recall Recall {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Size {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string SizeMap {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string StyleName {get; set;}

        
        public Toys() {
            this.subjectCharacterField = new List<string>();
            this.assemblyTimeField = new AssemblyTimeDimension();
            this.productTypeField = new ToysProductType();
            this.variationDataField = new ToysVariationData();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("SubjectCharacter", DataType="normalizedString")]
        public List<string> SubjectCharacter {
            get {
                return this.subjectCharacterField;
            }
            set {
                this.subjectCharacterField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class CollectibleCard {
        
        private string collectionField;
        
        private string educationalObjectiveField;
        
        private string genreField;
        
        private string rarityField;
        
        private string cardNumberField;
        
        private string cardTypeField;
        
    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Collection {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string EducationalObjective {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Genre {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Rarity {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string CardNumber {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string CardType {get; set;}

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Costume {
        
        private string countryOfOriginField;
        
        private string materialTypeField;
        
    public string CountryOfOrigin {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string MaterialType {get; set;}

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Hobbies {
        
        private string activeSurfaceAreaField;
        
        private string wingAreaField;
        
        private string collectionNameField;
        
        private string genreField;
        
        private string initialPrintRunRarityField;
        
        private string specificUsesForProductField;
        
        private string brakeStyleField;
        
        private string controlTypeField;
        
        private string countryOfOriginField;
        
        private string driveSystemField;
        
        private string educationalObjectiveField;
        
        private string frameMaterialTypeField;
        
        private VolumeDimension fuelCapacityField;
        
        private string fuelTypeField;
        
        private bool isElectricField;
        
        private bool isElectricFieldSpecified;
        
        private string materialTypeField;
        
        private LengthDimension maximumRangeField;
        
        private SpeedDimension maximumSpeedField;
        
        private string motorTypeField;
        
        private string publisherContributorField;
        
        private LengthDimension displaySizeField;
        
        private string displayTypeField;
        
        private VolumeDimension engineDisplacementField;
        
        private VolumeDimension liquidVolumeField;
        
        private EnergyConsumptionDimension lithiumBatteryEnergyContentField;
        
        private bool lithiumBatteryPackagingFieldSpecified;
        
        private VoltageDecimalDimension lithiumBatteryVoltageField;
        
        private WeightDimension lithiumBatteryWeightField;
        
        private string numberOfFrequencyChannelsField;
        
        private string movementTypeField;
        
        private string surfaceRecommendationField;
        
        private string animalTypeField;
        
        private string publisherField;
        
        private string radioBandsSupportedField;
        
        private string railTypeField;
        
        private string scaleField;
        
        private string skillLevelField;
        
        private string suspensionTypeField;
        
        private string productThemeField;
        
        private string tireTypeField;
        
        private List<ToyAwardType> toyAwardNameField;
        
        private LengthDimension wheelDiameterField;
        
        private string wheelTypeField;
        
        private bool distributionDesignationFieldSpecified;
        
        private string countryStringField;
        
    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string ActiveSurfaceArea {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string WingArea {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string CollectionName {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Genre {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string InitialPrintRunRarity {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string SpecificUsesForProduct {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string BrakeStyle {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string ControlType {get; set;}

    public string CountryOfOrigin {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string DriveSystem {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string EducationalObjective {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string FrameMaterialType {get; set;}

    public VolumeDimension FuelCapacity {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string FuelType {get; set;}

    public bool IsElectric {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool IsElectricSpecified {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string MaterialType {get; set;}

    public LengthDimension MaximumRange {get; set;}

    public SpeedDimension MaximumSpeed {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string MotorType {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string PublisherContributor {get; set;}

    public LengthDimension DisplaySize {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string DisplayType {get; set;}

    public VolumeDimension EngineDisplacement {get; set;}

    public VolumeDimension LiquidVolume {get; set;}

    public EnergyConsumptionDimension LithiumBatteryEnergyContent {get; set;}

    public HobbiesLithiumBatteryPackaging LithiumBatteryPackaging {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool LithiumBatteryPackagingSpecified {get; set;}

    public VoltageDecimalDimension LithiumBatteryVoltage {get; set;}

    public WeightDimension LithiumBatteryWeight {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string NumberOfFrequencyChannels {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string MovementType {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string SurfaceRecommendation {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string AnimalType {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Publisher {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string RadioBandsSupported {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string RailType {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Scale {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string SkillLevel {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string SuspensionType {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string ProductTheme {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string TireType {get; set;}

    public LengthDimension WheelDiameter {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string WheelType {get; set;}

    public DistributionDesignationValues DistributionDesignation {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DistributionDesignationSpecified {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string CountryString {get; set;}

        
        public Hobbies() {
            this.toyAwardNameField = new List<ToyAwardType>();
            this.lithiumBatteryVoltageField = new VoltageDecimalDimension();
            this.lithiumBatteryEnergyContentField = new EnergyConsumptionDimension();
            this.liquidVolumeField = new VolumeDimension();
            this.engineDisplacementField = new VolumeDimension();
            this.maximumSpeedField = new SpeedDimension();
            this.fuelCapacityField = new VolumeDimension();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ToyAwardName")]
        public List<ToyAwardType> ToyAwardName {
            get {
                return this.toyAwardNameField;
            }
            set {
                this.toyAwardNameField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class ToysAndGames {
        
        private string awardsWonField;
        
        private TimeDimension batteryAverageLifeField;
        
        private TimeDimension batteryAverageLifeStandbyField;
        
        private TimeDimension batteryChargeTimeField;
        
        private string colorField;
        
        private string colorMapField;
        
        private string directionsField;
        
        private EnergyConsumptionDimension lithiumBatteryEnergyContentField;
        
        private bool lithiumBatteryPackagingFieldSpecified;
        
        private VoltageDecimalDimension lithiumBatteryVoltageField;
        
        private WeightDimension lithiumBatteryWeightField;
        
        private string numberOfLithiumIonCellsField;
        
        private string numberOfLithiumMetalCellsField;
        
        private string numberOfFrequencyChannelsField;
        
        private string numberOfControlChannelsField;
        
        private string frequencyBandsSupportedField;
        
        private bool languageFieldSpecified;
        
        private bool includesRemoteField;
        
        private bool includesRemoteFieldSpecified;
        
        private string ingredientsField;
        
        private string powerSourceTypeField;
        
        private string recommendedUseField;
        
        private string remoteControlTechnologyField;
        
        private string railGaugeField;
        
        private string regionOfOriginField;
        
        private string countryOfOriginField;
        
        private string educationalObjectiveField;
        
        private string engineTypeField;
        
        private bool isElectricField;
        
        private bool isElectricFieldSpecified;
        
        private string materialTypeField;
        
        private string materialCompositionField;
        
        private string mfrWarrantyDescriptionLaborField;
        
        private string mfrWarrantyDescriptionPartsField;
        
        private string mfrWarrantyDescriptionTypeField;
        
        private List<string> careInstructionsField;
        
        private List<string> specialFeaturesField;
        
        private LengthDimension handleHeightField;
        
        private LengthDimension seatLengthField;
        
        private LengthDimension seatWidthField;
        
        private string tireMaterialField;
        
        private LengthDimension tireDiameterField;
        
        private string sellerWarrantyDescriptionField;
        
        private bool targetGenderFieldSpecified;
        
        private LengthDimension displayLengthField;
        
        private VolumeDimension displayVolumeField;
        
        private WeightDimension displayWeightField;
        
        private string animalTypeField;
        
        private string publisherField;
        
        private string skillLevelField;
        
        private List<string> styleKeywordsField;
        
        private string productThemeField;
        
        private List<ToyAwardType> toyAwardNameField;
        
        private string publisherContributorField;
        
        private string warrantyDescriptionField;
        
        private string unknownSubjectField;
        
        private string scaleNameField;
        
        private string batteryTypeLithiumIonField;
        
        private string batteryTypeLithiumMetalField;
        
        private string specificationMetField;
        
        private DistributionDesignationValues distributionDesignationField;
        
        private bool distributionDesignationFieldSpecified;
        
        private string countryStringField;
        
    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string AwardsWon {get; set;}

    public TimeDimension BatteryAverageLife {get; set;}

    public TimeDimension BatteryAverageLifeStandby {get; set;}

    public TimeDimension BatteryChargeTime {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Color {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string ColorMap {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Directions {get; set;}

    public EnergyConsumptionDimension LithiumBatteryEnergyContent {get; set;}

    public ToysAndGamesLithiumBatteryPackaging LithiumBatteryPackaging {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool LithiumBatteryPackagingSpecified {get; set;}

    public VoltageDecimalDimension LithiumBatteryVoltage {get; set;}

    public WeightDimension LithiumBatteryWeight {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string NumberOfLithiumIonCells {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string NumberOfLithiumMetalCells {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string NumberOfFrequencyChannels {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string NumberOfControlChannels {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string FrequencyBandsSupported {get; set;}

    public LanguageStringType Language {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool LanguageSpecified {get; set;}

    public bool IncludesRemote {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool IncludesRemoteSpecified {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Ingredients {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string PowerSourceType {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string RecommendedUse {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string RemoteControlTechnology {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string RailGauge {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string RegionOfOrigin {get; set;}

    public string CountryOfOrigin {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string EducationalObjective {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string EngineType {get; set;}

    public bool IsElectric {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool IsElectricSpecified {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string MaterialType {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string MaterialComposition {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string MfrWarrantyDescriptionLabor {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string MfrWarrantyDescriptionParts {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string MfrWarrantyDescriptionType {get; set;}

    public LengthDimension HandleHeight {get; set;}

    public LengthDimension SeatLength {get; set;}

    public LengthDimension SeatWidth {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string TireMaterial {get; set;}

    public LengthDimension TireDiameter {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string SellerWarrantyDescription {get; set;}

    public ToysAndGamesTargetGender TargetGender {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TargetGenderSpecified {get; set;}

    public LengthDimension DisplayLength {get; set;}

    public VolumeDimension DisplayVolume {get; set;}

    public WeightDimension DisplayWeight {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string AnimalType {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Publisher {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string SkillLevel {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string ProductTheme {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string PublisherContributor {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string WarrantyDescription {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string UnknownSubject {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string ScaleName {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string BatteryTypeLithiumIon {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string BatteryTypeLithiumMetal {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string SpecificationMet {get; set;}

    public DistributionDesignationValues DistributionDesignation {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DistributionDesignationSpecified {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string CountryString {get; set;}

        
        public ToysAndGames() {
            this.toyAwardNameField = new List<ToyAwardType>();
            this.styleKeywordsField = new List<string>();
            this.specialFeaturesField = new List<string>();
            this.careInstructionsField = new List<string>();
            this.batteryChargeTimeField = new TimeDimension();
            this.batteryAverageLifeStandbyField = new TimeDimension();
            this.batteryAverageLifeField = new TimeDimension();
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
        
        [System.Xml.Serialization.XmlElementAttribute("SpecialFeatures", DataType="normalizedString")]
        public List<string> SpecialFeatures {
            get {
                return this.specialFeaturesField;
            }
            set {
                this.specialFeaturesField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("StyleKeywords", DataType="normalizedString")]
        public List<string> StyleKeywords {
            get {
                return this.styleKeywordsField;
            }
            set {
                this.styleKeywordsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ToyAwardName")]
        public List<ToyAwardType> ToyAwardName {
            get {
                return this.toyAwardNameField;
            }
            set {
                this.toyAwardNameField = value;
            }
        }
    }
}
