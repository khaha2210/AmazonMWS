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
    public partial class OrderFulfillment {
        
        private string itemField;
        
        private string merchantFulfillmentIDField;
        
        private System.DateTime fulfillmentDateField;
        
        private OrderFulfillmentFulfillmentData fulfillmentDataField;
        
        private List<OrderFulfillmentItem> item1Field;
        
    [System.Xml.Serialization.XmlElementAttribute("AmazonOrderID",typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("MerchantOrderID",typeof(string),DataType="normalizedString")]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public string Item {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemChoiceType ItemElementName {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string MerchantFulfillmentID {get; set;}

    public System.DateTime FulfillmentDate {get; set;}

    public OrderFulfillmentFulfillmentData FulfillmentData {get; set;}

        
        public OrderFulfillment() {
            this.item1Field = new List<OrderFulfillmentItem>();
            this.fulfillmentDataField = new OrderFulfillmentFulfillmentData();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Item")]
        public List<OrderFulfillmentItem> Item1 {
            get {
                return this.item1Field;
            }
            set {
                this.item1Field = value;
            }
        }
    }
}
