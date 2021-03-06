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
    public partial class CatPIL {
        
        private List<piType> piField;
        
        private string itemSKUField;
        
    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string ItemSKU {get; set;}

        
        public CatPIL() {
            this.piField = new List<piType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("pi")]
        public List<piType> pi {
            get {
                return this.piField;
            }
            set {
                this.piField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class piType {
        
        private string nameField;
        
        private string typeField;
        
        private string unitField;
        
        private string unitTypeField;
        
        private string unitValueField;
        
        private string destinationField;
        
        private string valueField;
        
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unitType {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unitValue {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string destination {get; set;}

    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value {get; set;}

    }
}
