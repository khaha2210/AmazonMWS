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
    public partial class RawMaterials {
        
        private PressureDimension airEntryPressureField;
        
        private string backingTypeField;
        
        private string ballTypeField;
        
        private decimal compatibleWithTubeGaugeField;
        
        private bool compatibleWithTubeGaugeFieldSpecified;
        
        private string cornerStyleField;
        
        private string countryOfOriginField;
        
        private LengthDimension discDiameterStringField;
        
        private string durometerHardnessField;
        
        private string exteriorFinishField;
        
        private string foamStructureField;
        
        private string gaugeStringField;
        
        private string gradeRatingField;
        
        private string holeCountField;
        
        private LengthDimension insideDiameterStringField;
        
        private LengthDimension insideDiameterToleranceStringField;
        
        private LengthDimension itemDiameterField;
        
        private LengthDimension itemDiameterToleranceStringField;
        
        private string itemHardnessField;
        
        private LengthDimension itemLengthToleranceStringField;
        
        private string itemShapeField;
        
        private string itemTemperField;
        
        private LengthDimension itemThicknessField;
        
        private LengthDimension itemThicknessToleranceStringField;
        
        private LengthDimension itemWidthToleranceStringField;
        
        private PressureDimension lowerBubblingPressureField;
        
        private TemperatureDimension lowerTemperatureRatingField;
        
        private decimal mapField;
        
        private bool mapFieldSpecified;
        
        private string materialTypeField;
        
        private PressureDimension maximumPressureField;
        
        private string measurementSystemField;
        
        private MeshCountDimension meshCountField;
        
        private string meshFormField;
        
        private string meshNumberField;
        
        private string meshOpeningShapeField;
        
        private LengthDimension meshOpeningSizeField;
        
        private string metalConstructionTypeField;
        
        private LengthDimension notchDepthField;
        
        private LengthDimension notchWidthField;
        
        private decimal openAreaPercentageField;
        
        private bool openAreaPercentageFieldSpecified;
        
        private LengthDimension poreDiameterField;
        
        private string shimTypeField;
        
        private LengthDimension slotDepthField;
        
        private LengthDimension slotWidthField;
        
        private string specificationMetField;
        
        private LengthDimension sphericityStringField;
        
        private string standardConstructionField;
        
        private string subjectContentField;
        
        private TensileStrengthDimension tensileStrengthField;
        
        private LengthDimension threadDiameterStringField;
        
        private string toleranceHeldField;
        
        private string tubingWallTypeField;
        
        private PressureDimension upperBubblingPressureField;
        
        private TemperatureDimension upperTemperatureRatingField;
        
        private decimal voidVolumePercentageField;
        
        private bool voidVolumePercentageFieldSpecified;
        
        private LengthDimension wallThicknessField;
        
        private LengthDimension wallThicknessToleranceStringField;
        
        private LengthDimension wireDiameterStringField;
        
    public RawMaterialsProductType ProductType {get; set;}

    public PressureDimension AirEntryPressure {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string BackingType {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string BallType {get; set;}

    public decimal CompatibleWithTubeGauge {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool CompatibleWithTubeGaugeSpecified {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string CornerStyle {get; set;}

    public string CountryOfOrigin {get; set;}

    public LengthDimension DiscDiameterString {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string DurometerHardness {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string ExteriorFinish {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string FoamStructure {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string GaugeString {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string GradeRating {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string HoleCount {get; set;}

    public LengthDimension InsideDiameterString {get; set;}

    public LengthDimension InsideDiameterToleranceString {get; set;}

    public LengthDimension ItemDiameter {get; set;}

    public LengthDimension ItemDiameterToleranceString {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string ItemHardness {get; set;}

    public LengthDimension ItemLengthToleranceString {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string ItemShape {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string ItemTemper {get; set;}

    public LengthDimension ItemThickness {get; set;}

    public LengthDimension ItemThicknessToleranceString {get; set;}

    public LengthDimension ItemWidthToleranceString {get; set;}

    public PressureDimension LowerBubblingPressure {get; set;}

    public TemperatureDimension LowerTemperatureRating {get; set;}

    public decimal Map {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool MapSpecified {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string MaterialType {get; set;}

    public PressureDimension MaximumPressure {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string MeasurementSystem {get; set;}

    public MeshCountDimension MeshCount {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string MeshForm {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string MeshNumber {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string MeshOpeningShape {get; set;}

    public LengthDimension MeshOpeningSize {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string MetalConstructionType {get; set;}

    public LengthDimension NotchDepth {get; set;}

    public LengthDimension NotchWidth {get; set;}

    public decimal OpenAreaPercentage {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool OpenAreaPercentageSpecified {get; set;}

    public LengthDimension PoreDiameter {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string ShimType {get; set;}

    public LengthDimension SlotDepth {get; set;}

    public LengthDimension SlotWidth {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string SpecificationMet {get; set;}

    public LengthDimension SphericityString {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string StandardConstruction {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string SubjectContent {get; set;}

    public TensileStrengthDimension TensileStrength {get; set;}

    public LengthDimension ThreadDiameterString {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string ToleranceHeld {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string TubingWallType {get; set;}

    public PressureDimension UpperBubblingPressure {get; set;}

    public TemperatureDimension UpperTemperatureRating {get; set;}

    public decimal VoidVolumePercentage {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool VoidVolumePercentageSpecified {get; set;}

    public LengthDimension WallThickness {get; set;}

    public LengthDimension WallThicknessToleranceString {get; set;}

    public LengthDimension WireDiameterString {get; set;}

        
        public RawMaterials() {
            this.upperTemperatureRatingField = new TemperatureDimension();
            this.upperBubblingPressureField = new PressureDimension();
            this.tensileStrengthField = new TensileStrengthDimension();
            this.meshCountField = new MeshCountDimension();
            this.maximumPressureField = new PressureDimension();
            this.lowerTemperatureRatingField = new TemperatureDimension();
            this.lowerBubblingPressureField = new PressureDimension();
            this.airEntryPressureField = new PressureDimension();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class MeshCountDimension {
        
        private string valueField;
        
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public MeshCountUnitOfMeasure unitOfMeasure {get; set;}

    [System.Xml.Serialization.XmlTextAttribute(DataType="positiveInteger")]
    public string Value {get; set;}

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class TensileStrengthDimension {
        
        private decimal valueField;
        
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ForceUnitOfMeasure unitOfMeasure {get; set;}

    [System.Xml.Serialization.XmlTextAttribute()]
    public decimal Value {get; set;}

    }
}
