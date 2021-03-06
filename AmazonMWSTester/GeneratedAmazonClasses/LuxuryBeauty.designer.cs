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
    public partial class LuxuryBeauty {
        
        private LuxuryBeautyVariationData variationDataField;
        
        private Battery batteryField;
        
        private LuxuryBeautyUnitCount unitCountField;
        
        private string styleNameField;
        
        private LuxuryBeautyColorSpecification colorSpecificationField;
        
        private string sizeField;
        
        private string eachUnitCountField;
        
        private string scentNameField;
        
        private List<string> materialTypeField;
        
        private string finishField;
        
        private string targetGenderField;
        
        private string itemFormField;
        
        private string flavorField;
        
        private string specialtyField;
        
        private string specificUsesForProductField;
        
        private string coverageField;
        
        private SunProtectionDimension sunProtectionField;
        
        private List<string> skinTypeField;
        
        private List<string> hairTypeField;
        
        private string directionsField;
        
        private string ingredientsField;
        
        private string indicationsField;
        
        private List<string> includedComponentsField;
        
        private string plugFormatField;
        
        private string powerSourceTypeField;
        
        private VoltageDecimalDimension voltageField;
        
        private WattageDimension wattageField;
        
        private bool isAdultProductField;
        
        private bool isAdultProductFieldSpecified;
        
        private TimeDimension batteryAverageLifeField;
        
        private bool batteryCellTypeFieldSpecified;
        
        private TimeDimension batteryChargeTimeField;
        
        private string batteryFormFactorField;
        
        private BatteryPowerIntegerDimension batteryPowerField;
        
        private EnergyConsumptionDimension lithiumBatteryEnergyContentField;
        
        private object lithiumBatteryPackagingField;
        
        private VoltageDecimalDimension lithiumBatteryVoltageField;
        
        private WeightDimension lithiumBatteryWeightField;
        
        private string numberOfLithiumIonCellsField;
        
        private string numberOfLithiumMetalCellsField;
        
        private List<string> awardsWonField;
        
    public LuxuryBeautyProductType ProductType {get; set;}

    public LuxuryBeautyVariationData VariationData {get; set;}

    public Battery Battery {get; set;}

    public LuxuryBeautyUnitCount UnitCount {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string StyleName {get; set;}

    public LuxuryBeautyColorSpecification ColorSpecification {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Size {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string EachUnitCount {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string ScentName {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Finish {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string TargetGender {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string ItemForm {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Flavor {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Specialty {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string SpecificUsesForProduct {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Coverage {get; set;}

    public SunProtectionDimension SunProtection {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Directions {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Ingredients {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Indications {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string PlugFormat {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string PowerSourceType {get; set;}

    public VoltageDecimalDimension Voltage {get; set;}

    public WattageDimension Wattage {get; set;}

    public bool IsAdultProduct {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool IsAdultProductSpecified {get; set;}

    public TimeDimension BatteryAverageLife {get; set;}

    public BatteryCellTypeValues BatteryCellType {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool BatteryCellTypeSpecified {get; set;}

    public TimeDimension BatteryChargeTime {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string BatteryFormFactor {get; set;}

    public BatteryPowerIntegerDimension BatteryPower {get; set;}

    public EnergyConsumptionDimension LithiumBatteryEnergyContent {get; set;}

    public object LithiumBatteryPackaging {get; set;}

    public VoltageDecimalDimension LithiumBatteryVoltage {get; set;}

    public WeightDimension LithiumBatteryWeight {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string NumberOfLithiumIonCells {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string NumberOfLithiumMetalCells {get; set;}

        
        public LuxuryBeauty() {
            this.awardsWonField = new List<string>();
            this.lithiumBatteryVoltageField = new VoltageDecimalDimension();
            this.lithiumBatteryEnergyContentField = new EnergyConsumptionDimension();
            this.batteryPowerField = new BatteryPowerIntegerDimension();
            this.batteryChargeTimeField = new TimeDimension();
            this.batteryAverageLifeField = new TimeDimension();
            this.wattageField = new WattageDimension();
            this.voltageField = new VoltageDecimalDimension();
            this.includedComponentsField = new List<string>();
            this.hairTypeField = new List<string>();
            this.skinTypeField = new List<string>();
            this.sunProtectionField = new SunProtectionDimension();
            this.materialTypeField = new List<string>();
            this.colorSpecificationField = new LuxuryBeautyColorSpecification();
            this.unitCountField = new LuxuryBeautyUnitCount();
            this.variationDataField = new LuxuryBeautyVariationData();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("MaterialType", DataType="normalizedString")]
        public List<string> MaterialType {
            get {
                return this.materialTypeField;
            }
            set {
                this.materialTypeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("SkinType", DataType="normalizedString")]
        public List<string> SkinType {
            get {
                return this.skinTypeField;
            }
            set {
                this.skinTypeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("HairType", DataType="normalizedString")]
        public List<string> HairType {
            get {
                return this.hairTypeField;
            }
            set {
                this.hairTypeField = value;
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
        
        [System.Xml.Serialization.XmlElementAttribute("AwardsWon", DataType="normalizedString")]
        public List<string> AwardsWon {
            get {
                return this.awardsWonField;
            }
            set {
                this.awardsWonField = value;
            }
        }
    }
}
