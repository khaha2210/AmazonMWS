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
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class ConveyabilityValue {
        
        private bool valueFieldSpecified;
        
        private bool deleteFieldSpecified;
        
    public ConveyabilityValueValue value {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool valueSpecified {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public BooleanType delete {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool deleteSpecified {get; set;}

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class DataTransferRateValue {
        
        private DataTransferRateValueValue valueField;
        
        private BooleanType deleteField;
        
        private bool deleteFieldSpecified;
        
    public DataTransferRateValueValue value {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public BooleanType delete {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool deleteSpecified {get; set;}

        
        public DataTransferRateValue() {
            this.valueField = new DataTransferRateValueValue();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class ElectricalPowerValue {
        
        private ElectricalPowerValueValue valueField;
        
        private BooleanType deleteField;
        
        private bool deleteFieldSpecified;
        
    public ElectricalPowerValueValue value {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public BooleanType delete {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool deleteSpecified {get; set;}

        
        public ElectricalPowerValue() {
            this.valueField = new ElectricalPowerValueValue();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class NoiseValue {
        
        private NoiseValueValue valueField;
        
        private BooleanType deleteField;
        
        private bool deleteFieldSpecified;
        
    public NoiseValueValue value {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public BooleanType delete {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool deleteSpecified {get; set;}

        
        public NoiseValue() {
            this.valueField = new NoiseValueValue();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class EnergyValue {
        
        private EnergyValueValue valueField;
        
        private BooleanType deleteField;
        
        private bool deleteFieldSpecified;
        
    public EnergyValueValue value {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public BooleanType delete {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool deleteSpecified {get; set;}

        
        public EnergyValue() {
            this.valueField = new EnergyValueValue();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class ItemStringNotNullValueType {
        
        private string data_providerField;
        
        private string valueField;
        
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
    public string data_provider {get; set;}

    [System.Xml.Serialization.XmlTextAttribute(DataType="normalizedString")]
    public string Value {get; set;}

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class ItemLongStringNotNullValueType {
        
        private string data_providerField;
        
        private string valueField;
        
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
    public string data_provider {get; set;}

    [System.Xml.Serialization.XmlTextAttribute(DataType="normalizedString")]
    public string Value {get; set;}

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class ItemMediumStringNotNullValueType {
        
        private string data_providerField;
        
        private string valueField;
        
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
    public string data_provider {get; set;}

    [System.Xml.Serialization.XmlTextAttribute(DataType="normalizedString")]
    public string Value {get; set;}

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class DateValue {
        
        private System.DateTime valueField;
        
        private bool valueFieldSpecified;
        
        private BooleanType deleteField;
        
        private bool deleteFieldSpecified;
        
    public System.DateTime value {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool valueSpecified {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public BooleanType delete {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool deleteSpecified {get; set;}

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class DateValueRequired {
        
        private System.DateTime valueField;
        
        private BooleanType deleteField;
        
        private bool deleteFieldSpecified;
        
    public System.DateTime value {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public BooleanType delete {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool deleteSpecified {get; set;}

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class PriceUnitValue {
        
        private PriceUnitValueValue valueField;
        
        private BooleanType deleteField;
        
        private bool deleteFieldSpecified;
        
    public PriceUnitValueValue value {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public BooleanType delete {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool deleteSpecified {get; set;}

        
        public PriceUnitValue() {
            this.valueField = new PriceUnitValueValue();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class DecimalValue {
        
        private decimal valueField;
        
        private bool valueFieldSpecified;
        
        private BooleanType deleteField;
        
        private bool deleteFieldSpecified;
        
    public decimal value {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool valueSpecified {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public BooleanType delete {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool deleteSpecified {get; set;}

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class LongDecimalValue {
        
        private decimal valueField;
        
        private bool valueFieldSpecified;
        
        private BooleanType deleteField;
        
        private bool deleteFieldSpecified;
        
    public decimal value {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool valueSpecified {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public BooleanType delete {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool deleteSpecified {get; set;}

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class IntegerValue {
        
        private string valueField;
        
        private BooleanType deleteField;
        
        private bool deleteFieldSpecified;
        
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string value {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public BooleanType delete {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool deleteSpecified {get; set;}

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class BooleanValue {
        
        private BooleanType valueField;
        
        private bool valueFieldSpecified;
        
        private BooleanType deleteField;
        
        private bool deleteFieldSpecified;
        
    public BooleanType value {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool valueSpecified {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public BooleanType delete {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool deleteSpecified {get; set;}

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class StringValue {
        
        private string valueField;
        
        private BooleanType deleteField;
        
        private bool deleteFieldSpecified;
        
        private LanguageType languageField;
        
        private bool languageFieldSpecified;
        
    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string value {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public BooleanType delete {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool deleteSpecified {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public LanguageType language {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool languageSpecified {get; set;}

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class UnboundedStringValue {
        
        private List<string> valueField;
        
        private BooleanType deleteField;
        
        private bool deleteFieldSpecified;
        
        private LanguageType languageField;
        
        private bool languageFieldSpecified;
        
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public BooleanType delete {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool deleteSpecified {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public LanguageType language {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool languageSpecified {get; set;}

        
        public UnboundedStringValue() {
            this.valueField = new List<string>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("value", DataType="normalizedString")]
        public List<string> value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class EightyStringValue {
        
        private string valueField;
        
        private BooleanType deleteField;
        
        private bool deleteFieldSpecified;
        
        private LanguageType languageField;
        
        private bool languageFieldSpecified;
        
    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string value {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public BooleanType delete {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool deleteSpecified {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public LanguageType language {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool languageSpecified {get; set;}

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class HundredStringValue {
        
        private string valueField;
        
        private BooleanType deleteField;
        
        private bool deleteFieldSpecified;
        
        private LanguageType languageField;
        
        private bool languageFieldSpecified;
        
    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string value {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public BooleanType delete {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool deleteSpecified {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public LanguageType language {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool languageSpecified {get; set;}

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class LongStringValue {
        
        private string valueField;
        
        private BooleanType deleteField;
        
        private bool deleteFieldSpecified;
        
        private LanguageType languageField;
        
        private bool languageFieldSpecified;
        
    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string value {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public BooleanType delete {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool deleteSpecified {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public LanguageType language {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool languageSpecified {get; set;}

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class TwoFiftyStringValue {
        
        private string valueField;
        
        private BooleanType deleteField;
        
        private bool deleteFieldSpecified;
        
    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
    public string value {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public BooleanType delete {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool deleteSpecified {get; set;}

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class WeightValue {
        
        private WeightValueValue valueField;
        
        private BooleanType deleteField;
        
        private bool deleteFieldSpecified;
        
    public WeightValueValue value {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public BooleanType delete {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool deleteSpecified {get; set;}

        
        public WeightValue() {
            this.valueField = new WeightValueValue();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class PositiveNonZeroWeightValue {
        
        private PositiveNonZeroWeightValueValue valueField;
        
        private BooleanType deleteField;
        
        private bool deleteFieldSpecified;
        
    public PositiveNonZeroWeightValueValue value {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public BooleanType delete {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool deleteSpecified {get; set;}

        
        public PositiveNonZeroWeightValue() {
            this.valueField = new PositiveNonZeroWeightValueValue();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class WeightValueNoDelete {
        
        private WeightValueNoDeleteValue valueField;
        
    public WeightValueNoDeleteValue value {get; set;}

        
        public WeightValueNoDelete() {
            this.valueField = new WeightValueNoDeleteValue();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class DimensionValue {
        
        private DimensionValueValue valueField;
        
        private BooleanType deleteField;
        
        private bool deleteFieldSpecified;
        
    public DimensionValueValue value {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public BooleanType delete {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool deleteSpecified {get; set;}

        
        public DimensionValue() {
            this.valueField = new DimensionValueValue();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class RestrictedDimensionValue {
        
        private RestrictedDimensionValueValue valueField;
        
    public RestrictedDimensionValueValue value {get; set;}

        
        public RestrictedDimensionValue() {
            this.valueField = new RestrictedDimensionValueValue();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class PackageDimensionsType {
        
        private decimal package_heightField;
        
        private decimal package_widthField;
        
        private decimal package_lengthField;
        
        private RestrictedDimensionType unitValueField;
        
    public decimal package_height {get; set;}

    public decimal package_width {get; set;}

    public decimal package_length {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public RestrictedDimensionType unitValue {get; set;}

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class LongDimensionValue {
        
        private LongDimensionValueValue valueField;
        
        private BooleanType deleteField;
        
        private bool deleteFieldSpecified;
        
    public LongDimensionValueValue value {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public BooleanType delete {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool deleteSpecified {get; set;}

        
        public LongDimensionValue() {
            this.valueField = new LongDimensionValueValue();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class PowerValue {
        
        private PowerValueValue valueField;
        
        private BooleanType deleteField;
        
        private bool deleteFieldSpecified;
        
    public PowerValueValue value {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public BooleanType delete {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool deleteSpecified {get; set;}

        
        public PowerValue() {
            this.valueField = new PowerValueValue();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class PrinterResolutionValue {
        
        private PrinterResolutionValueValue valueField;
        
        private BooleanType deleteField;
        
        private bool deleteFieldSpecified;
        
    public PrinterResolutionValueValue value {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public BooleanType delete {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool deleteSpecified {get; set;}

        
        public PrinterResolutionValue() {
            this.valueField = new PrinterResolutionValueValue();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class TimeValue {
        
        private TimeValueValue valueField;
        
        private BooleanType deleteField;
        
        private bool deleteFieldSpecified;
        
    public TimeValueValue value {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public BooleanType delete {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool deleteSpecified {get; set;}

        
        public TimeValue() {
            this.valueField = new TimeValueValue();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class MemorySizeValue {
        
        private MemorySizeValueValue valueField;
        
        private BooleanType deleteField;
        
        private bool deleteFieldSpecified;
        
    public MemorySizeValueValue value {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public BooleanType delete {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool deleteSpecified {get; set;}

        
        public MemorySizeValue() {
            this.valueField = new MemorySizeValueValue();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class VolumeValue {
        
        private VolumeValueValue valueField;
        
        private BooleanType deleteField;
        
        private bool deleteFieldSpecified;
        
    public VolumeValueValue value {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public BooleanType delete {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool deleteSpecified {get; set;}

        
        public VolumeValue() {
            this.valueField = new VolumeValueValue();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class ToleranceValue {
        
        private ToleranceValueValue valueField;
        
        private BooleanType deleteField;
        
        private bool deleteFieldSpecified;
        
    public ToleranceValueValue value {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public BooleanType delete {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool deleteSpecified {get; set;}

        
        public ToleranceValue() {
            this.valueField = new ToleranceValueValue();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class CapacityValue {
        
        private CapacityValueValue valueField;
        
        private BooleanType deleteField;
        
        private bool deleteFieldSpecified;
        
    public CapacityValueValue value {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public BooleanType delete {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool deleteSpecified {get; set;}

        
        public CapacityValue() {
            this.valueField = new CapacityValueValue();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class ApertureValue {
        
        private ApertureValueValue valueField;
        
        private BooleanType deleteField;
        
        private bool deleteFieldSpecified;
        
    public ApertureValueValue value {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public BooleanType delete {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool deleteSpecified {get; set;}

        
        public ApertureValue() {
            this.valueField = new ApertureValueValue();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class PixelValue {
        
        private PixelValueValue valueField;
        
        private BooleanType deleteField;
        
        private bool deleteFieldSpecified;
        
    public PixelValueValue value {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public BooleanType delete {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool deleteSpecified {get; set;}

        
        public PixelValue() {
            this.valueField = new PixelValueValue();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class ZoomType {
        
        private decimal valueField;
        
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ZoomTypeUnitValue unitValue {get; set;}

    [System.Xml.Serialization.XmlTextAttribute()]
    public decimal Value {get; set;}

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class JewelryWeightValue {
        
        private JewelryWeightValueValue valueField;
        
        private BooleanType deleteField;
        
        private bool deleteFieldSpecified;
        
    public JewelryWeightValueValue value {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public BooleanType delete {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool deleteSpecified {get; set;}

        
        public JewelryWeightValue() {
            this.valueField = new JewelryWeightValueValue();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class LongJewelryWeightValue {
        
        private LongJewelryWeightValueValue valueField;
        
        private BooleanType deleteField;
        
        private bool deleteFieldSpecified;
        
    public LongJewelryWeightValueValue value {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public BooleanType delete {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool deleteSpecified {get; set;}

        
        public LongJewelryWeightValue() {
            this.valueField = new LongJewelryWeightValueValue();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class MarketplaceSearchIndexability {
        
        private bool valueFieldSpecified;
        
        private BooleanType deleteField;
        
        private bool deleteFieldSpecified;
        
    public MarketplaceSearchIndexabilityValue value {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool valueSpecified {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public BooleanType delete {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool deleteSpecified {get; set;}

    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class PositiveIntegerValue {
        
        private string valueField;
        
        private BooleanType deleteField;
        
        private bool deleteFieldSpecified;
        
    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string value {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public BooleanType delete {get; set;}

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool deleteSpecified {get; set;}

    }

	public partial class DataTransferRateValueValue
	{
		unitValue value { get; set; }
	}

	public enum unitValue
	{
		Bps,
		bps,
		Kbps,
		Mbps,
		Gbps,
		KBps,
		MBps,
		GBps
	}

	public partial class PositiveNonZeroWeightValueValue
	{
		unitValue value { get; set; } //TODO I think this is messed up
	}
	public partial class RestrictedDimensionValueValue
	{

	}
}
