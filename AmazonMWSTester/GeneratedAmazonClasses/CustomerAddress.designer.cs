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
    public partial class CustomerAddresses {
        
        private List<CustomerAddress> customerAddressField;
        
        public CustomerAddresses() {
            this.customerAddressField = new List<CustomerAddress>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("CustomerAddress")]
        public List<CustomerAddress> CustomerAddress {
            get {
                return this.customerAddressField;
            }
            set {
                this.customerAddressField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class CustomerAddress {
        
        private string nameField;
        
        private string addressFieldOneField;
        
        private string addressFieldTwoField;
        
        private string addressFieldThreeField;
        
        private string cityField;
        
        private string stateOrRegionField;
        
        private string postalCodeField;
        
        private string countryCodeField;
        
        private string phoneNumberField;
        
        private bool isBillingField;
        
        private bool isBillingFieldSpecified;
        
        private bool isShippingField;
        
        private bool isShippingFieldSpecified;
        
        private bool isDefaultShippingField;
        
        private bool isDefaultShippingFieldSpecified;
        
        private string merchantAddressIDField;
        
    public string Name {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string AddressFieldOne {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string AddressFieldTwo {get; set;}

    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string AddressFieldThree {get; set;}

    public string City {get; set;}

    public string StateOrRegion {get; set;}

    public string PostalCode {get; set;}

    public string CountryCode {get; set;}

    public string PhoneNumber {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool isBilling {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool isBillingSpecified {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool isShipping {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool isShippingSpecified {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool isDefaultShipping {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool isDefaultShippingSpecified {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string MerchantAddressID {get; set;}

    }
}