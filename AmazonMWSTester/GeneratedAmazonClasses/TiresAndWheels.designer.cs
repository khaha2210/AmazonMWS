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
    public partial class TiresAndWheels {
        
        private TiresAndWheelsProductType productTypeField;
        
    public TiresAndWheelsProductType ProductType {get; set;}

        
        public TiresAndWheels() {
            this.productTypeField = new TiresAndWheelsProductType();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class TireAndWheelAssemblies {
        
        private LengthDimension boreDiameterField;
        
        private ColorSpecification colorSpecificationField;
        
        private string constructionTypeField;
        
        private LengthDimension offsetField;
        
        private string loadIndexField;
        
        private string materialField;
        
        private string numberOfHolesField;
        
        private string oemEquivalentPartNumberField;
        
        private LengthDimension pitchCircleDiameterField;
        
        private LengthDimension rimDiameterField;
        
        private LengthDimension rimWidthField;
        
        private string seasonsField;
        
        private LengthDimension sectionWidthField;
        
        private List<string> specialFeaturesField;
        
        private bool speedRatingFieldSpecified;
        
        private string modelNameField;
        
        private LengthDimension tireAspectRatioField;
        
        private string tireTypeField;
        
        private string treadTypeField;
        
        private AmperageDimension amperageField;
        
        private string careInstructionsField;
        
        private LengthDimension diameterField;
        
        private LengthDimension displayLengthField;
        
        private VolumeDimension displayVolumeField;
        
        private WeightDimension displayWeightField;
        
        private string lifestyleField;
        
        private string manufacturerWarrantyDescriptionField;
        
        private string modelYearField;
        
        private string numberOfPiecesField;
        
        private string recallDescriptionField;
        
        private string sizeField;
        
        private string sizeMapField;
        
        private string specificationMetField;
        
        private string styleNameField;
        
        private TireAndWheelAssembliesVariationData variationDataField;
        
        private VoltageDecimalDimension voltageField;
        
        private WattageDimension wattageField;
        
        private string vehicleFitmentCodeField;
        
    public LengthDimension BoreDiameter {get; set;}

    public ColorSpecification ColorSpecification {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string ConstructionType {get; set;}

    public LengthDimension Offset {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string LoadIndex {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Material {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string NumberOfHoles {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string OemEquivalentPartNumber {get; set;}

    public LengthDimension PitchCircleDiameter {get; set;}

    public LengthDimension RimDiameter {get; set;}

    public LengthDimension RimWidth {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Seasons {get; set;}

    public LengthDimension SectionWidth {get; set;}

    public TireAndWheelAssembliesSpeedRating SpeedRating {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool SpeedRatingSpecified {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string ModelName {get; set;}

    public LengthDimension TireAspectRatio {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string TireType {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string TreadType {get; set;}

    public AmperageDimension Amperage {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string CareInstructions {get; set;}

    public LengthDimension Diameter {get; set;}

    public LengthDimension DisplayLength {get; set;}

    public VolumeDimension DisplayVolume {get; set;}

    public WeightDimension DisplayWeight {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Lifestyle {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string ManufacturerWarrantyDescription {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string ModelYear {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string NumberOfPieces {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string RecallDescription {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Size {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string SizeMap {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string SpecificationMet {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string StyleName {get; set;}

    public TireAndWheelAssembliesVariationData VariationData {get; set;}

    public VoltageDecimalDimension Voltage {get; set;}

    public WattageDimension Wattage {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string VehicleFitmentCode {get; set;}

        
        public TireAndWheelAssemblies() {
            this.wattageField = new WattageDimension();
            this.voltageField = new VoltageDecimalDimension();
            this.variationDataField = new TireAndWheelAssembliesVariationData();
            this.displayVolumeField = new VolumeDimension();
            this.amperageField = new AmperageDimension();
            this.specialFeaturesField = new List<string>();
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Tires {
        
        private string vehicleServiceTypeField;
        
        private bool constructionTypeFieldSpecified;
        
        private string loadIndexField;
        
        private bool speedRatingFieldSpecified;
        
        private string uTQGRatingField;
        
        private bool specialFeaturesFieldSpecified;
        
        private string modelNameField;
        
        private LengthDimension rimDiameterField;
        
        private LengthDimension sectionWidthField;
        
        private LengthDimension tireAspectRatioField;
        
        private LengthDimension treadDepthField;
        
        private string partTypeIDField;
        
        private string itemPackageQuantityField;
        
        private ColorSpecification colorSpecificationField;
        
        private string materialField;
        
        private string oemEquivalentPartNumberField;
        
        private string seasonsField;
        
        private string tireTypeField;
        
        private string treadTypeField;
        
        private AmperageDimension amperageField;
        
        private string careInstructionsField;
        
        private LengthDimension diameterField;
        
        private LengthDimension displayLengthField;
        
        private VolumeDimension displayVolumeField;
        
        private WeightDimension displayWeightField;
        
        private string lifestyleField;
        
        private string manufacturerWarrantyDescriptionField;
        
        private string modelYearField;
        
        private string numberOfPiecesField;
        
        private string recallDescriptionField;
        
        private string sizeField;
        
        private string sizeMapField;
        
        private string specificationMetField;
        
        private string styleNameField;
        
        private TiresVariationData variationDataField;
        
        private VoltageDecimalDimension voltageField;
        
        private WattageDimension wattageField;
        
        private string vehicleFitmentCodeField;
        
    public string VehicleServiceType {get; set;}

    public TiresConstructionType ConstructionType {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ConstructionTypeSpecified {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string LoadIndex {get; set;}

    public TiresSpeedRating SpeedRating {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool SpeedRatingSpecified {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string UTQGRating {get; set;}

    public TiresSpecialFeatures SpecialFeatures {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool SpecialFeaturesSpecified {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string ModelName {get; set;}

    public LengthDimension RimDiameter {get; set;}

    public LengthDimension SectionWidth {get; set;}

    public LengthDimension TireAspectRatio {get; set;}

    public LengthDimension TreadDepth {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string PartTypeID {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string ItemPackageQuantity {get; set;}

    public ColorSpecification ColorSpecification {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Material {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string OemEquivalentPartNumber {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Seasons {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string TireType {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string TreadType {get; set;}

    public AmperageDimension Amperage {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string CareInstructions {get; set;}

    public LengthDimension Diameter {get; set;}

    public LengthDimension DisplayLength {get; set;}

    public VolumeDimension DisplayVolume {get; set;}

    public WeightDimension DisplayWeight {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Lifestyle {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string ManufacturerWarrantyDescription {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string ModelYear {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string NumberOfPieces {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string RecallDescription {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Size {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string SizeMap {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string SpecificationMet {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string StyleName {get; set;}

    public TiresVariationData VariationData {get; set;}

    public VoltageDecimalDimension Voltage {get; set;}

    public WattageDimension Wattage {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string VehicleFitmentCode {get; set;}

        
        public Tires() {
            this.variationDataField = new TiresVariationData();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Wheels {
        
        private List<LengthDimension> pitchCircleDiameterField;
        
        private bool constructionTypeFieldSpecified;
        
        private ColorSpecification colorSpecificationField;
        
        private string exteriorFinishField;
        
        private bool exteriorFinishMapFieldSpecified;
        
        private bool specialFeaturesFieldSpecified;
        
        private string modelNameField;
        
        private string numberOfHolesField;
        
        private string numberOfSpokesField;
        
        private LengthDimension wheelBackspacingField;
        
        private LengthDimension rimDiameterField;
        
        private LengthDimension rimWidthField;
        
        private LengthDimension boreDiameterField;
        
        private LengthDimension offsetField;
        
        private string partTypeIDField;
        
        private string itemPackageQuantityField;
        
        private string materialField;
        
        private string oemEquivalentPartNumberField;
        
        private string seasonsField;
        
        private AmperageDimension amperageField;
        
        private string careInstructionsField;
        
        private LengthDimension diameterField;
        
        private LengthDimension displayLengthField;
        
        private VolumeDimension displayVolumeField;
        
        private WeightDimension displayWeightField;
        
        private string lifestyleField;
        
        private string manufacturerWarrantyDescriptionField;
        
        private string modelYearField;
        
        private string numberOfPiecesField;
        
        private string recallDescriptionField;
        
        private string sizeField;
        
        private string sizeMapField;
        
        private string specificationMetField;
        
        private string styleNameField;
        
        private WheelsVariationData variationDataField;
        
        private VoltageDecimalDimension voltageField;
        
        private WattageDimension wattageField;
        
        private string vehicleFitmentCodeField;
        
        private LengthDimension sectionWidthField;
        
    public WheelsConstructionType ConstructionType {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ConstructionTypeSpecified {get; set;}

    public ColorSpecification ColorSpecification {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string ExteriorFinish {get; set;}

    public WheelsExteriorFinishMap ExteriorFinishMap {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ExteriorFinishMapSpecified {get; set;}

    public WheelsSpecialFeatures SpecialFeatures {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool SpecialFeaturesSpecified {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string ModelName {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string NumberOfHoles {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string NumberOfSpokes {get; set;}

    public LengthDimension WheelBackspacing {get; set;}

    public LengthDimension RimDiameter {get; set;}

    public LengthDimension RimWidth {get; set;}

    public LengthDimension BoreDiameter {get; set;}

    public LengthDimension Offset {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string PartTypeID {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string ItemPackageQuantity {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Material {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string OemEquivalentPartNumber {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Seasons {get; set;}

    public AmperageDimension Amperage {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string CareInstructions {get; set;}

    public LengthDimension Diameter {get; set;}

    public LengthDimension DisplayLength {get; set;}

    public VolumeDimension DisplayVolume {get; set;}

    public WeightDimension DisplayWeight {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Lifestyle {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string ManufacturerWarrantyDescription {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string ModelYear {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string NumberOfPieces {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string RecallDescription {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Size {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string SizeMap {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string SpecificationMet {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string StyleName {get; set;}

    public WheelsVariationData VariationData {get; set;}

    public VoltageDecimalDimension Voltage {get; set;}

    public WattageDimension Wattage {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string VehicleFitmentCode {get; set;}

    public LengthDimension SectionWidth {get; set;}

        
        public Wheels() {
            this.variationDataField = new WheelsVariationData();
            this.pitchCircleDiameterField = new List<LengthDimension>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PitchCircleDiameter")]
        public List<LengthDimension> PitchCircleDiameter {
            get {
                return this.pitchCircleDiameterField;
            }
            set {
                this.pitchCircleDiameterField = value;
            }
        }
    }
}
