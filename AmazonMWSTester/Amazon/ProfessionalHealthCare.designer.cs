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
    public partial class ProfessionalHealthCare {
        
        private ProfessionalHealthCareProductType productTypeField;
        
        private ProfessionalHealthCareVariationData variationDataField;
        
        private string sizeNameField;
        
        private string colorNameField;
        
        private string colorMapField;
        
        private string scentNameField;
        
        private string finishTypeField;
        
        private string materialTypeField;
        
        private string itemFormField;
        
        private List<string> specificUsesForProductField;
        
        private List<string> skinToneField;
        
        private string coverageField;
        
        private List<string> skinTypeField;
        
        private List<string> hairTypeField;
        
        private string directionsField;
        
        private string ingredientsField;
        
        private string indicationsField;
        
        private List<string> includedComponentsField;
        
        private string powerSourceField;
        
        private string numberOfPiecesField;
        
        private string plugTypeField;
        
        private string harmonizedCodeField;
        
        private List<string> specialFeaturesField;
        
        private WeightDimension minimumWeightRecommendationField;
        
        private WeightDimension maximumWeightRecommendationField;
        
        private bool isAdultProductField;
        
        private bool isAdultProductFieldSpecified;
        
        private decimal batteryAverageLifeField;
        
        private bool batteryAverageLifeFieldSpecified;
        
        private bool batteryCellCompositionFieldSpecified;
        
        private decimal batteryAverageLifeStandbyField;
        
        private bool batteryAverageLifeStandbyFieldSpecified;
        
        private decimal batteryChargeTimeField;
        
        private bool batteryChargeTimeFieldSpecified;
        
        private string batteryDescriptionField;
        
        private string batteryFormFactorField;
        
        private BatteryPowerIntegerDimension batteryPowerField;
        
        private decimal lithiumBatteryEnergyContentField;
        
        private bool lithiumBatteryEnergyContentFieldSpecified;
        
        private bool lithiumBatteryPackagingFieldSpecified;
        
        private decimal lithiumBatteryVoltageField;
        
        private bool lithiumBatteryVoltageFieldSpecified;
        
        private decimal lithiumBatteryWeightField;
        
        private bool lithiumBatteryWeightFieldSpecified;
        
        private string numberOfItemsField;
        
        private string fdaDeviceClassificationField;
        
        private string fdaIndicationOfUseField;
        
        private string fdaInstructionsForUseTypeField;
        
        private string fdaLabelTypeField;
        
        private string fdaPremarketApprovalNumber510kField;
        
        private string fdaPremarketApprovalNumberPmaField;
        
        private ProfessionalHealthCareUnitCount unitCountField;
        
        private string businessPriceField;
        
        private string quantityPriceTypeField;
        
        private string productExpirationTypeField;
        
        private string fcShelfLifeField;
        
        private string fcShelfLifePadTimeField;
        
        private string fcShelfLifePadTime2qField;
        
        private string fcReceivePadTimeField;
        
        private string organizationTaxRole1Field;
        
        private string organizationTaxCode1Field;
        
        private string organizationTaxRole2Field;
        
        private string organizationTaxCode2Field;
        
        private string organizationTaxRole3Field;
        
        private string organizationTaxCode3Field;
        
        private string organizationTaxRole4Field;
        
        private string organizationTaxCode4Field;
        
        private string organizationTaxRole5Field;
        
        private string organizationTaxCode5Field;
        
    public ProfessionalHealthCareProductType ProductType {get; set;}

    public ProfessionalHealthCareVariationData VariationData {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string SizeName {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string ColorName {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string ColorMap {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string ScentName {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string FinishType {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string MaterialType {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string ItemForm {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Coverage {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Directions {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Ingredients {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Indications {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string PowerSource {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string NumberOfPieces {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string PlugType {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string HarmonizedCode {get; set;}

    public WeightDimension MinimumWeightRecommendation {get; set;}

    public WeightDimension MaximumWeightRecommendation {get; set;}

    public bool IsAdultProduct {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool IsAdultProductSpecified {get; set;}

    public decimal BatteryAverageLife {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool BatteryAverageLifeSpecified {get; set;}

    public BatteryCellTypeValues BatteryCellComposition {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool BatteryCellCompositionSpecified {get; set;}

    public decimal BatteryAverageLifeStandby {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool BatteryAverageLifeStandbySpecified {get; set;}

    public decimal BatteryChargeTime {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool BatteryChargeTimeSpecified {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string BatteryDescription {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string BatteryFormFactor {get; set;}

    public BatteryPowerIntegerDimension BatteryPower {get; set;}

    public decimal LithiumBatteryEnergyContent {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool LithiumBatteryEnergyContentSpecified {get; set;}

    public LithiumBatteryPackagingType LithiumBatteryPackaging {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool LithiumBatteryPackagingSpecified {get; set;}

    public decimal LithiumBatteryVoltage {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool LithiumBatteryVoltageSpecified {get; set;}

    public decimal LithiumBatteryWeight {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool LithiumBatteryWeightSpecified {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string NumberOfItems {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string FdaDeviceClassification {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string FdaIndicationOfUse {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string FdaInstructionsForUseType {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string FdaLabelType {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string FdaPremarketApprovalNumber510k {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string FdaPremarketApprovalNumberPma {get; set;}

    public ProfessionalHealthCareUnitCount UnitCount {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string BusinessPrice {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string QuantityPriceType {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string ProductExpirationType {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string FcShelfLife {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string FcShelfLifePadTime {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string FcShelfLifePadTime2q {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string FcReceivePadTime {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string OrganizationTaxRole1 {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string OrganizationTaxCode1 {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string OrganizationTaxRole2 {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string OrganizationTaxCode2 {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string OrganizationTaxRole3 {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string OrganizationTaxCode3 {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string OrganizationTaxRole4 {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string OrganizationTaxCode4 {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string OrganizationTaxRole5 {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string OrganizationTaxCode5 {get; set;}

        
        public ProfessionalHealthCare() {
            this.unitCountField = new ProfessionalHealthCareUnitCount();
            this.batteryPowerField = new BatteryPowerIntegerDimension();
            this.specialFeaturesField = new List<string>();
            this.includedComponentsField = new List<string>();
            this.hairTypeField = new List<string>();
            this.skinTypeField = new List<string>();
            this.skinToneField = new List<string>();
            this.specificUsesForProductField = new List<string>();
            this.variationDataField = new ProfessionalHealthCareVariationData();
            this.productTypeField = new ProfessionalHealthCareProductType();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("SpecificUsesForProduct", DataType="normalizedString")]
        public List<string> SpecificUsesForProduct {
            get {
                return this.specificUsesForProductField;
            }
            set {
                this.specificUsesForProductField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("SkinTone", DataType="normalizedString")]
        public List<string> SkinTone {
            get {
                return this.skinToneField;
            }
            set {
                this.skinToneField = value;
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
