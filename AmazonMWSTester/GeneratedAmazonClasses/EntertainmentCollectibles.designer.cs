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
    public partial class EntertainmentCollectibles {
        
        private EntertainmentCollectiblesProductType productTypeField;
        
    public EntertainmentCollectiblesProductType ProductType {get; set;}

        
        public EntertainmentCollectibles() {
            this.productTypeField = new EntertainmentCollectiblesProductType();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class EntertainmentMemorabilia {
        
        private List<string> actorField;
        
        private List<string> artistField;
        
        private string authenticityNumberField;
        
        private string bandField;
        
        private List<string> composerField;
        
        private List<string> conductorField;
        
        private string countryOfOriginField;
        
        private System.DateTime dateOfPerformanceField;
        
        private bool dateOfPerformanceFieldSpecified;
        
        private LengthDimension displayDepthField;
        
        private LengthDimension displayDiameterField;
        
        private LengthDimension displayHeightField;
        
        private LengthDimension displayLengthField;
        
        private WeightDimension displayWeightField;
        
        private LengthDimension displayWidthField;
        
        private string entertainmentBrandField;
        
        private string entertainmentTypeField;
        
        private string eventNameField;
        
        private string genreField;
        
        private bool isAdultProductField;
        
        private bool isAdultProductFieldSpecified;
        
        private string isPerformanceUsedField;
        
        private string gradeRatingField;
        
        private LengthDimension itemThicknessStringField;
        
        private string limitedEditionQuantityField;
        
        private string limitedEditionNumberField;
        
        private string publisherField;
        
        private string numberOfItemsField;
        
        private string numberOfPagesField;
        
        private string numberOfPiecesField;
        
        private List<string> orchestraField;
        
        private string packagingField;
        
        private System.DateTime publicationDateField;
        
        private bool publicationDateFieldSpecified;
        
        private string safetyWarningField;
        
        private string signedByField;
        
        private string studioField;
        
        private List<string> subjectKeywordsField;
        
        private string venueNameField;
        
        private bool vinylRecordDetailsFieldSpecified;
        
        private List<string> whatsInTheBoxField;
        
        private string yearField;
        
        private string makeAnOfferMinimumPercentageField;
        
        private string seriesNumberField;
        
        private string cardNumberField;
        
        private bool isVeryHighValueField;
        
        private bool isVeryHighValueFieldSpecified;
        
        private string contributorField;
        
        private string additionalProductInformationField;
        
    public AuthenticatedByType AuthenticatedBy {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string AuthenticityNumber {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Band {get; set;}

    public CollectibleType CollectibleType {get; set;}

    public ConditionProvidedByType ConditionProvidedBy {get; set;}

    public string CountryOfOrigin {get; set;}

    public System.DateTime DateOfPerformance {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DateOfPerformanceSpecified {get; set;}

    public LengthDimension DisplayDepth {get; set;}

    public LengthDimension DisplayDiameter {get; set;}

    public LengthDimension DisplayHeight {get; set;}

    public LengthDimension DisplayLength {get; set;}

    public WeightDimension DisplayWeight {get; set;}

    public LengthDimension DisplayWidth {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string EntertainmentBrand {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string EntertainmentType {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string EventName {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Genre {get; set;}

    public bool IsAdultProduct {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool IsAdultProductSpecified {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string IsPerformanceUsed {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string GradeRating {get; set;}

    public LengthDimension ItemThicknessString {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string LimitedEditionQuantity {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string LimitedEditionNumber {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Publisher {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string NumberOfItems {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string NumberOfPages {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string NumberOfPieces {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Packaging {get; set;}

    public System.DateTime PublicationDate {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool PublicationDateSpecified {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string SafetyWarning {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string SignedBy {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Studio {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string VenueName {get; set;}

    public VinylRecordDetailsType VinylRecordDetails {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool VinylRecordDetailsSpecified {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string Year {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string MakeAnOfferMinimumPercentage {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string SeriesNumber {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string CardNumber {get; set;}

    public bool IsVeryHighValue {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool IsVeryHighValueSpecified {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string Contributor {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string AdditionalProductInformation {get; set;}

        
        public EntertainmentMemorabilia() {
            this.whatsInTheBoxField = new List<string>();
            this.subjectKeywordsField = new List<string>();
            this.orchestraField = new List<string>();
            this.conductorField = new List<string>();
            this.composerField = new List<string>();
            this.artistField = new List<string>();
            this.actorField = new List<string>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Actor", DataType="normalizedString")]
        public List<string> Actor {
            get {
                return this.actorField;
            }
            set {
                this.actorField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Artist", DataType="normalizedString")]
        public List<string> Artist {
            get {
                return this.artistField;
            }
            set {
                this.artistField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Composer", DataType="normalizedString")]
        public List<string> Composer {
            get {
                return this.composerField;
            }
            set {
                this.composerField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Conductor", DataType="normalizedString")]
        public List<string> Conductor {
            get {
                return this.conductorField;
            }
            set {
                this.conductorField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Orchestra", DataType="normalizedString")]
        public List<string> Orchestra {
            get {
                return this.orchestraField;
            }
            set {
                this.orchestraField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("SubjectKeywords", DataType="normalizedString")]
        public List<string> SubjectKeywords {
            get {
                return this.subjectKeywordsField;
            }
            set {
                this.subjectKeywordsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("WhatsInTheBox", DataType="normalizedString")]
        public List<string> WhatsInTheBox {
            get {
                return this.whatsInTheBoxField;
            }
            set {
                this.whatsInTheBoxField = value;
            }
        }
    }
}
