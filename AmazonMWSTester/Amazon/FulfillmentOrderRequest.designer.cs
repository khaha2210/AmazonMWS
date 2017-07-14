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
    public partial class FulfillmentOrderRequest {
        
        private string merchantFulfillmentOrderIDField;
        
        private string displayableOrderIDField;
        
        private System.DateTime displayableOrderDateField;
        
        private bool displayableOrderDateFieldSpecified;
        
        private string displayableOrderCommentField;
        
        private string deliverySLAField;
        
        private string fulfillmentPolicyField;
        
        private string fulfillmentMethodField;
        
        private string fulfillmentActionField;
        
        private string notificationEmailField;
        
        private AddressTypeSupportNonCity destinationAddressField;
        
        private List<FulfillmentOrderRequestItem> itemField;
        
    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string MerchantFulfillmentOrderID {get; set;}

    public string DisplayableOrderID {get; set;}

    public System.DateTime DisplayableOrderDate {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DisplayableOrderDateSpecified {get; set;}

    public string DisplayableOrderComment {get; set;}

    public string DeliverySLA {get; set;}

    public string FulfillmentPolicy {get; set;}

    public string FulfillmentMethod {get; set;}

    public string FulfillmentAction {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string NotificationEmail {get; set;}

    public AddressTypeSupportNonCity DestinationAddress {get; set;}

        
        public FulfillmentOrderRequest() {
            this.itemField = new List<FulfillmentOrderRequestItem>();
            this.destinationAddressField = new AddressTypeSupportNonCity();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Item")]
        public List<FulfillmentOrderRequestItem> Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
}