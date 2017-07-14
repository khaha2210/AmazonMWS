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
    public partial class GiftCard {
        
        private GiftCardProductType productTypeField;
        
        private string colorField;
        
        private string countField;
        
        private string designNameField;
        
        private List<GiftCardsFormatType> formatField;
        
        private List<string> genreField;
        
        private bool isAdultProductField;
        
        private bool isAdultProductFieldSpecified;
        
        private List<string> occasionTypeField;
        
        private List<string> stateField;
        
        private bool targetGenderFieldSpecified;
        
        private string themeField;
        
        private string eventKeywordsField;
        
        private string subjectKeywordsField;
        
        private string customerReturnPolicyField;
        
        private GiftCardVariationData variationDataField;
        
    public GiftCardProductType ProductType {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Color {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string Count {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string DesignName {get; set;}

    public bool IsAdultProduct {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool IsAdultProductSpecified {get; set;}

    public GiftCardTargetGender TargetGender {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TargetGenderSpecified {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Theme {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string EventKeywords {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string SubjectKeywords {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string CustomerReturnPolicy {get; set;}

    public GiftCardVariationData VariationData {get; set;}

        
        public GiftCard() {
            this.variationDataField = new GiftCardVariationData();
            this.stateField = new List<string>();
            this.occasionTypeField = new List<string>();
            this.genreField = new List<string>();
            this.formatField = new List<GiftCardsFormatType>();
            this.productTypeField = new GiftCardProductType();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Format")]
        public List<GiftCardsFormatType> Format {
            get {
                return this.formatField;
            }
            set {
                this.formatField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Genre", DataType="normalizedString")]
        public List<string> Genre {
            get {
                return this.genreField;
            }
            set {
                this.genreField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("OccasionType", DataType="normalizedString")]
        public List<string> OccasionType {
            get {
                return this.occasionTypeField;
            }
            set {
                this.occasionTypeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("State", DataType="normalizedString")]
        public List<string> State {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }
    }
}
