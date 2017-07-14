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
    public partial class MaterialHandling {
        
        private decimal cFMat90PSIField;
        
        private bool cFMat90PSIFieldSpecified;
        
        private LengthDimension compatibleBeamFlangeWidthField;
        
        private LengthDimension compatibleMinBeamCurveRadiusField;
        
        private LengthDimension compatibleMinBeamHeightField;
        
        private LengthDimension controlCordLengthField;
        
        private LengthDimension drumCapacityField;
        
        private LengthDimension hangerHoleDiameterField;
        
        private decimal horsepowerField;
        
        private bool horsepowerFieldSpecified;
        
        private LengthDimension hydraulicRamHoleDiameterField;
        
        private LengthDimension hydraulicRamOutsideDiameterField;
        
        private string hydraulicRamTypeField;
        
        private LengthDimension leverLengthField;
        
        private string liftingMaterialTypeField;
        
        private string liftingMechanismField;
        
        private WeightDimension loadCapacityField;
        
        private string materialTypeField;
        
        private LengthDimension maximumHeightField;
        
        private LengthDimension maximumLiftingHeightField;
        
        private SpeedDimension maximumLiftingSpeedField;
        
        private PressureDimension maximumPressureField;
        
        private LengthDimension maximumTensionLoadField;
        
        private LengthDimension measurementSystemField;
        
        private LengthDimension minimumClearanceField;
        
        private LengthDimension minimumHeightField;
        
        private string modelNumberField;
        
        private string motorPhaseField;
        
        private LengthDimension mountingHoleDiameterField;
        
        private string mountingTypeField;
        
        private string numberOfLinksField;
        
        private string numberOfPointsField;
        
        private string numberOfSpeedsField;
        
        private VolumeDimension oilCapacityField;
        
        private LengthDimension pistonStrokeLengthField;
        
        private string powerSourceTypeField;
        
        private string sizeNameField;
        
        private List<string> specialFeaturesField;
        
        private string specificationMetField;
        
        private string strandTypeField;
        
        private LengthDimension tensionRatingField;
        
        private decimal voltageField;
        
        private bool voltageFieldSpecified;
        
        private LengthDimension wheelTreadWidthField;
        
    public MaterialHandlingParentage Parentage {get; set;}

    public decimal CFMat90PSI {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool CFMat90PSISpecified {get; set;}

    public LengthDimension CompatibleBeamFlangeWidth {get; set;}

    public LengthDimension CompatibleMinBeamCurveRadius {get; set;}

    public LengthDimension CompatibleMinBeamHeight {get; set;}

    public LengthDimension ControlCordLength {get; set;}

    public LengthDimension DrumCapacity {get; set;}

    public LengthDimension HangerHoleDiameter {get; set;}

    public decimal Horsepower {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool HorsepowerSpecified {get; set;}

    public LengthDimension HydraulicRamHoleDiameter {get; set;}

    public LengthDimension HydraulicRamOutsideDiameter {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string HydraulicRamType {get; set;}

    public LengthDimension LeverLength {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string LiftingMaterialType {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string LiftingMechanism {get; set;}

    public WeightDimension LoadCapacity {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string MaterialType {get; set;}

    public LengthDimension MaximumHeight {get; set;}

    public LengthDimension MaximumLiftingHeight {get; set;}

    public SpeedDimension MaximumLiftingSpeed {get; set;}

    public PressureDimension MaximumPressure {get; set;}

    public LengthDimension MaximumTensionLoad {get; set;}

    public LengthDimension MeasurementSystem {get; set;}

    public LengthDimension MinimumClearance {get; set;}

    public LengthDimension MinimumHeight {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string ModelNumber {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string MotorPhase {get; set;}

    public LengthDimension MountingHoleDiameter {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string MountingType {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string NumberOfLinks {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string NumberOfPoints {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string NumberOfSpeeds {get; set;}

    public VolumeDimension OilCapacity {get; set;}

    public LengthDimension PistonStrokeLength {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string PowerSourceType {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string SizeName {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string SpecificationMet {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string StrandType {get; set;}

    public LengthDimension TensionRating {get; set;}

    public decimal Voltage {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool VoltageSpecified {get; set;}

    public LengthDimension WheelTreadWidth {get; set;}

        
        public MaterialHandling() {
            this.specialFeaturesField = new List<string>();
            this.oilCapacityField = new VolumeDimension();
            this.maximumPressureField = new PressureDimension();
            this.maximumLiftingSpeedField = new SpeedDimension();
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
}