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
    public partial class Gourmet {
        
        private GourmetProductType productTypeField;
        
    public GourmetProductType ProductType {get; set;}

        
        public Gourmet() {
            this.productTypeField = new GourmetProductType();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class GourmetMisc {
        
        private GourmetMiscVariationData variationDataField;
        
        private string countryProducedInField;
        
        private string ingredientsField;
        
        private string nutritionalFactsField;
        
        private List<string> kosherCertificationField;
        
        private List<string> organicCertificationField;
        
        private List<string> itemSpecialtyField;
        
        private string warningsField;
        
        private string directionsField;
        
        private string itemPackageQuantityField;
        
        private string numberOfItemsField;
        
        private LengthDimension displayLengthField;
        
        private WeightDimension displayWeightField;
        
        private VolumeDimension displayVolumeField;
        
        private GourmetMiscUnitCount unitCountField;
        
    public GourmetMiscVariationData VariationData {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string CountryProducedIn {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Ingredients {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string NutritionalFacts {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Warnings {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Directions {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string ItemPackageQuantity {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string NumberOfItems {get; set;}

    public LengthDimension DisplayLength {get; set;}

    public WeightDimension DisplayWeight {get; set;}

    public VolumeDimension DisplayVolume {get; set;}

    public GourmetMiscUnitCount UnitCount {get; set;}

        
        public GourmetMisc() {
            this.unitCountField = new GourmetMiscUnitCount();
            this.displayVolumeField = new VolumeDimension();
            this.itemSpecialtyField = new List<string>();
            this.organicCertificationField = new List<string>();
            this.kosherCertificationField = new List<string>();
            this.variationDataField = new GourmetMiscVariationData();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("KosherCertification", DataType="normalizedString")]
        public List<string> KosherCertification {
            get {
                return this.kosherCertificationField;
            }
            set {
                this.kosherCertificationField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("OrganicCertification", DataType="normalizedString")]
        public List<string> OrganicCertification {
            get {
                return this.organicCertificationField;
            }
            set {
                this.organicCertificationField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ItemSpecialty", DataType="normalizedString")]
        public List<string> ItemSpecialty {
            get {
                return this.itemSpecialtyField;
            }
            set {
                this.itemSpecialtyField = value;
            }
        }
    }
}