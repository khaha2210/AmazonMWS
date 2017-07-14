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
    public partial class SettlementReport {
        
        private SettlementReportSettlementData settlementDataField;
        
        private List<SettlementReportOrder> orderField;
        
        private List<SettlementReportAdjustment> adjustmentField;
        
        private List<SettlementReportOtherFee> otherFeeField;
        
        private List<SettlementReportOtherTransaction> otherTransactionField;
        
        private List<SettlementReportMiscEvent> miscEventField;
        
    public SettlementReportSettlementData SettlementData {get; set;}

        
        public SettlementReport() {
            this.miscEventField = new List<SettlementReportMiscEvent>();
            this.otherTransactionField = new List<SettlementReportOtherTransaction>();
            this.otherFeeField = new List<SettlementReportOtherFee>();
            this.adjustmentField = new List<SettlementReportAdjustment>();
            this.orderField = new List<SettlementReportOrder>();
            this.settlementDataField = new SettlementReportSettlementData();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Order")]
        public List<SettlementReportOrder> Order {
            get {
                return this.orderField;
            }
            set {
                this.orderField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Adjustment")]
        public List<SettlementReportAdjustment> Adjustment {
            get {
                return this.adjustmentField;
            }
            set {
                this.adjustmentField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("OtherFee")]
        public List<SettlementReportOtherFee> OtherFee {
            get {
                return this.otherFeeField;
            }
            set {
                this.otherFeeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("OtherTransaction")]
        public List<SettlementReportOtherTransaction> OtherTransaction {
            get {
                return this.otherTransactionField;
            }
            set {
                this.otherTransactionField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("MiscEvent")]
        public List<SettlementReportMiscEvent> MiscEvent {
            get {
                return this.miscEventField;
            }
            set {
                this.miscEventField = value;
            }
        }
    }
}