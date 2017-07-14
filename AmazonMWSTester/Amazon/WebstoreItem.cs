using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class WebstoreItem : AmazonMessageChoice
	{
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class WebstoreItemSku { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(WebstoreItemSku)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class WebstoreItemMarketplaceData { private PriceUnitValue contribution_marginField; private DateValue discontinue_dateField; private BooleanValue free_shippingField; private DateValue launch_dateField; private IntegerValue max_ordering_quantityField; private PriceUnitValue msrpField; private BooleanValue offering_can_ship_in_original_containerField; private DateValue release_dateField; private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")] public string market_name { get; set; } public WebstoreItemMarketplaceData() { this.release_dateField = new DateValue(); this.offering_can_ship_in_original_containerField = new BooleanValue(); this.msrpField = new PriceUnitValue(); this.max_ordering_quantityField = new IntegerValue(); this.launch_dateField = new DateValue(); this.free_shippingField = new BooleanValue(); this.discontinue_dateField = new DateValue(); this.contribution_marginField = new PriceUnitValue(); } public PriceUnitValue contribution_margin { get { return this.contribution_marginField; } set { this.contribution_marginField = value; } } public DateValue discontinue_date { get { return this.discontinue_dateField; } set { this.discontinue_dateField = value; } } public BooleanValue free_shipping { get { return this.free_shippingField; } set { this.free_shippingField = value; } } public DateValue launch_date { get { return this.launch_dateField; } set { this.launch_dateField = value; } } public IntegerValue max_ordering_quantity { get { return this.max_ordering_quantityField; } set { this.max_ordering_quantityField = value; } } public PriceUnitValue msrp { get { return this.msrpField; } set { this.msrpField = value; } } public BooleanValue offering_can_ship_in_original_container { get { return this.offering_can_ship_in_original_containerField; } set { this.offering_can_ship_in_original_containerField = value; } } public DateValue release_date { get { return this.release_dateField; } set { this.release_dateField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(WebstoreItemMarketplaceData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class WebstoreItemDescriptionData { private StringValue brand_nameField; private WebstoreItemDescriptionDataBullet_point bullet_pointField; private BooleanValue can_be_giftmessagedField; private BooleanValue can_be_giftwrappedField; private WebstoreItemDescriptionDataEan eanField; private WebstoreItemDescriptionDataEan8 ean8Field; private WebstoreItemDescriptionDataGtin gtinField; private WebstoreItemDescriptionDataIsbn isbnField; private WebstoreItemDescriptionDataItemDimensions itemDimensionsField; private List<WebstoreItemDescriptionDataItem_name> item_nameField; private WeightValue item_weightField; private LongStringValue manufacturerField; private WebstoreItemDescriptionDataOffering_condition offering_conditionField; private WebstoreItemDescriptionDataOffering_subcondition offering_subconditionField; private WeightValue package_weightField; private WebstoreItemDescriptionDataPart_number part_numberField; private List<WebstoreItemDescriptionDataProduct_description> product_descriptionField; private StringValue product_tax_codeField; private WebstoreItemDescriptionDataUpc upcField; private static System.Xml.Serialization.XmlSerializer serializer; public WebstoreItemDescriptionData() { this.upcField = new WebstoreItemDescriptionDataUpc(); this.product_tax_codeField = new StringValue(); this.product_descriptionField = new List<WebstoreItemDescriptionDataProduct_description>(); this.part_numberField = new WebstoreItemDescriptionDataPart_number(); this.package_weightField = new WeightValue(); this.offering_subconditionField = new WebstoreItemDescriptionDataOffering_subcondition(); this.offering_conditionField = new WebstoreItemDescriptionDataOffering_condition(); this.manufacturerField = new LongStringValue(); this.item_weightField = new WeightValue(); this.item_nameField = new List<WebstoreItemDescriptionDataItem_name>(); this.itemDimensionsField = new WebstoreItemDescriptionDataItemDimensions(); this.isbnField = new WebstoreItemDescriptionDataIsbn(); this.gtinField = new WebstoreItemDescriptionDataGtin(); this.ean8Field = new WebstoreItemDescriptionDataEan8(); this.eanField = new WebstoreItemDescriptionDataEan(); this.can_be_giftwrappedField = new BooleanValue(); this.can_be_giftmessagedField = new BooleanValue(); this.bullet_pointField = new WebstoreItemDescriptionDataBullet_point(); this.brand_nameField = new StringValue(); } public StringValue brand_name { get { return this.brand_nameField; } set { this.brand_nameField = value; } } public WebstoreItemDescriptionDataBullet_point bullet_point { get { return this.bullet_pointField; } set { this.bullet_pointField = value; } } public BooleanValue can_be_giftmessaged { get { return this.can_be_giftmessagedField; } set { this.can_be_giftmessagedField = value; } } public BooleanValue can_be_giftwrapped { get { return this.can_be_giftwrappedField; } set { this.can_be_giftwrappedField = value; } } public WebstoreItemDescriptionDataEan ean { get { return this.eanField; } set { this.eanField = value; } } public WebstoreItemDescriptionDataEan8 ean8 { get { return this.ean8Field; } set { this.ean8Field = value; } } public WebstoreItemDescriptionDataGtin gtin { get { return this.gtinField; } set { this.gtinField = value; } } public WebstoreItemDescriptionDataIsbn isbn { get { return this.isbnField; } set { this.isbnField = value; } } public WebstoreItemDescriptionDataItemDimensions ItemDimensions { get { return this.itemDimensionsField; } set { this.itemDimensionsField = value; } }[System.Xml.Serialization.XmlElementAttribute("item_name")] public List<WebstoreItemDescriptionDataItem_name> item_name { get { return this.item_nameField; } set { this.item_nameField = value; } } public WeightValue item_weight { get { return this.item_weightField; } set { this.item_weightField = value; } } public LongStringValue manufacturer { get { return this.manufacturerField; } set { this.manufacturerField = value; } } public WebstoreItemDescriptionDataOffering_condition offering_condition { get { return this.offering_conditionField; } set { this.offering_conditionField = value; } } public WebstoreItemDescriptionDataOffering_subcondition offering_subcondition { get { return this.offering_subconditionField; } set { this.offering_subconditionField = value; } } public WeightValue package_weight { get { return this.package_weightField; } set { this.package_weightField = value; } } public WebstoreItemDescriptionDataPart_number part_number { get { return this.part_numberField; } set { this.part_numberField = value; } }[System.Xml.Serialization.XmlElementAttribute("product_description")] public List<WebstoreItemDescriptionDataProduct_description> product_description { get { return this.product_descriptionField; } set { this.product_descriptionField = value; } } public StringValue product_tax_code { get { return this.product_tax_codeField; } set { this.product_tax_codeField = value; } } public WebstoreItemDescriptionDataUpc upc { get { return this.upcField; } set { this.upcField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(WebstoreItemDescriptionData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class WebstoreItemSearchAndBrowseData { private BooleanValue browse_suppressedField; private WebstoreItemSearchAndBrowseDataCatalog_number catalog_numberField; private WebstoreItemSearchAndBrowseDataGeneric_keywords generic_keywordsField; private WebstoreItemSearchAndBrowseDataItem_type_keyword item_type_keywordField; private WebstoreItemSearchAndBrowseDataPlatinum_keywords platinum_keywordsField; private BooleanValue recommendation_suppressedField; private WebstoreItemSearchAndBrowseDataSpecific_uses_keywords specific_uses_keywordsField; private WebstoreItemSearchAndBrowseDataTarget_audience_keywords target_audience_keywordsField; private WebstoreItemSearchAndBrowseDataThesaurus_attribute_keywords thesaurus_attribute_keywordsField; private WebstoreItemSearchAndBrowseDataThesaurus_subject_keywords thesaurus_subject_keywordsField; private static System.Xml.Serialization.XmlSerializer serializer; public WebstoreItemSearchAndBrowseData() { this.thesaurus_subject_keywordsField = new WebstoreItemSearchAndBrowseDataThesaurus_subject_keywords(); this.thesaurus_attribute_keywordsField = new WebstoreItemSearchAndBrowseDataThesaurus_attribute_keywords(); this.target_audience_keywordsField = new WebstoreItemSearchAndBrowseDataTarget_audience_keywords(); this.specific_uses_keywordsField = new WebstoreItemSearchAndBrowseDataSpecific_uses_keywords(); this.recommendation_suppressedField = new BooleanValue(); this.platinum_keywordsField = new WebstoreItemSearchAndBrowseDataPlatinum_keywords(); this.item_type_keywordField = new WebstoreItemSearchAndBrowseDataItem_type_keyword(); this.generic_keywordsField = new WebstoreItemSearchAndBrowseDataGeneric_keywords(); this.catalog_numberField = new WebstoreItemSearchAndBrowseDataCatalog_number(); this.browse_suppressedField = new BooleanValue(); } public BooleanValue browse_suppressed { get { return this.browse_suppressedField; } set { this.browse_suppressedField = value; } } public WebstoreItemSearchAndBrowseDataCatalog_number catalog_number { get { return this.catalog_numberField; } set { this.catalog_numberField = value; } } public WebstoreItemSearchAndBrowseDataGeneric_keywords generic_keywords { get { return this.generic_keywordsField; } set { this.generic_keywordsField = value; } } public WebstoreItemSearchAndBrowseDataItem_type_keyword item_type_keyword { get { return this.item_type_keywordField; } set { this.item_type_keywordField = value; } } public WebstoreItemSearchAndBrowseDataPlatinum_keywords platinum_keywords { get { return this.platinum_keywordsField; } set { this.platinum_keywordsField = value; } } public BooleanValue recommendation_suppressed { get { return this.recommendation_suppressedField; } set { this.recommendation_suppressedField = value; } } public WebstoreItemSearchAndBrowseDataSpecific_uses_keywords specific_uses_keywords { get { return this.specific_uses_keywordsField; } set { this.specific_uses_keywordsField = value; } } public WebstoreItemSearchAndBrowseDataTarget_audience_keywords target_audience_keywords { get { return this.target_audience_keywordsField; } set { this.target_audience_keywordsField = value; } } public WebstoreItemSearchAndBrowseDataThesaurus_attribute_keywords thesaurus_attribute_keywords { get { return this.thesaurus_attribute_keywordsField; } set { this.thesaurus_attribute_keywordsField = value; } } public WebstoreItemSearchAndBrowseDataThesaurus_subject_keywords thesaurus_subject_keywords { get { return this.thesaurus_subject_keywordsField; } set { this.thesaurus_subject_keywordsField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(WebstoreItemSearchAndBrowseData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class WebstoreItemAdditionalData { private List<System.Xml.XmlElement> anyField; private static System.Xml.Serialization.XmlSerializer serializer; public WebstoreItemAdditionalData() { this.anyField = new List<System.Xml.XmlElement>(); }[System.Xml.Serialization.XmlAnyElementAttribute()] public List<System.Xml.XmlElement> Any { get { return this.anyField; } set { this.anyField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(WebstoreItemAdditionalData)); } return serializer; } } 
}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class WebstoreItemDescriptionDataEan { private List<string> valueField; private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public BooleanType delete { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool deleteSpecified { get; set; } public WebstoreItemDescriptionDataEan() { this.valueField = new List<string>(); }[System.Xml.Serialization.XmlElementAttribute("value", DataType = "normalizedString")] public List<string> value { get { return this.valueField; } set { this.valueField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(WebstoreItemDescriptionDataEan)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class WebstoreItemDescriptionDataEan8 { private List<string> valueField; private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public BooleanType delete { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool deleteSpecified { get; set; } public WebstoreItemDescriptionDataEan8() { this.valueField = new List<string>(); }[System.Xml.Serialization.XmlElementAttribute("value", DataType = "normalizedString")] public List<string> value { get { return this.valueField; } set { this.valueField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(WebstoreItemDescriptionDataEan8)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class WebstoreItemDescriptionDataGtin { private List<string> valueField; private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public BooleanType delete { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool deleteSpecified { get; set; } public WebstoreItemDescriptionDataGtin() { this.valueField = new List<string>(); }[System.Xml.Serialization.XmlElementAttribute("value", DataType = "normalizedString")] public List<string> value { get { return this.valueField; } set { this.valueField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(WebstoreItemDescriptionDataGtin)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class WebstoreItemDescriptionDataIsbn { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string value { get; set; }[System.Xml.Serialization.XmlAttributeAttribute()] public BooleanType delete { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool deleteSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(WebstoreItemDescriptionDataIsbn)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class WebstoreItemDescriptionDataItemDimensions { private DimensionValue item_heightField; private DimensionValue item_lengthField; private DimensionValue item_widthField; private static System.Xml.Serialization.XmlSerializer serializer; public WebstoreItemDescriptionDataItemDimensions() { this.item_widthField = new DimensionValue(); this.item_lengthField = new DimensionValue(); this.item_heightField = new DimensionValue(); } public DimensionValue item_height { get { return this.item_heightField; } set { this.item_heightField = value; } } public DimensionValue item_length { get { return this.item_lengthField; } set { this.item_lengthField = value; } } public DimensionValue item_width { get { return this.item_widthField; } set { this.item_widthField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(WebstoreItemDescriptionDataItemDimensions)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class WebstoreItemDescriptionDataItem_name { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string value { get; set; }[System.Xml.Serialization.XmlAttributeAttribute()] public LanguageType language { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool languageSpecified { get; set; }[System.Xml.Serialization.XmlAttributeAttribute()] public BooleanType delete { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool deleteSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(WebstoreItemDescriptionDataItem_name)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class WebstoreItemDescriptionDataOffering_condition { private static System.Xml.Serialization.XmlSerializer serializer; public WebstoreItemDescriptionDataOffering_conditionValue value { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool valueSpecified { get; set; }[System.Xml.Serialization.XmlAttributeAttribute()] public BooleanType delete { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool deleteSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(WebstoreItemDescriptionDataOffering_condition)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class WebstoreItemDescriptionDataOffering_subcondition { private static System.Xml.Serialization.XmlSerializer serializer; public WebstoreItemDescriptionDataOffering_subconditionValue value { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool valueSpecified { get; set; }[System.Xml.Serialization.XmlAttributeAttribute()] public BooleanType delete { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool deleteSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(WebstoreItemDescriptionDataOffering_subcondition)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class WebstoreItemDescriptionDataPart_number { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string value { get; set; }[System.Xml.Serialization.XmlAttributeAttribute()] public BooleanType delete { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool deleteSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(WebstoreItemDescriptionDataPart_number)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class WebstoreItemDescriptionDataProduct_description { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string value { get; set; }[System.Xml.Serialization.XmlAttributeAttribute()] public LanguageType language { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool languageSpecified { get; set; }[System.Xml.Serialization.XmlAttributeAttribute()] public BooleanType delete { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool deleteSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(WebstoreItemDescriptionDataProduct_description)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class WebstoreItemDescriptionDataUpc { private List<string> valueField; private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public BooleanType delete { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool deleteSpecified { get; set; } public WebstoreItemDescriptionDataUpc() { this.valueField = new List<string>(); }[System.Xml.Serialization.XmlElementAttribute("value", DataType = "normalizedString")] public List<string> value { get { return this.valueField; } set { this.valueField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(WebstoreItemDescriptionDataUpc)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class WebstoreItemSearchAndBrowseDataCatalog_number { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string value { get; set; }[System.Xml.Serialization.XmlAttributeAttribute()] public BooleanType delete { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool deleteSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(WebstoreItemSearchAndBrowseDataCatalog_number)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class WebstoreItemSearchAndBrowseDataGeneric_keywords { private List<string> valueField; private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public BooleanType delete { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool deleteSpecified { get; set; } public WebstoreItemSearchAndBrowseDataGeneric_keywords() { this.valueField = new List<string>(); }[System.Xml.Serialization.XmlElementAttribute("value", DataType = "normalizedString")] public List<string> value { get { return this.valueField; } set { this.valueField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(WebstoreItemSearchAndBrowseDataGeneric_keywords)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class WebstoreItemSearchAndBrowseDataItem_type_keyword { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string value { get; set; }[System.Xml.Serialization.XmlAttributeAttribute()] public BooleanType delete { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool deleteSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(WebstoreItemSearchAndBrowseDataItem_type_keyword)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class WebstoreItemSearchAndBrowseDataPlatinum_keywords { private List<string> valueField; private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public BooleanType delete { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool deleteSpecified { get; set; } public WebstoreItemSearchAndBrowseDataPlatinum_keywords() { this.valueField = new List<string>(); }[System.Xml.Serialization.XmlElementAttribute("value", DataType = "normalizedString")] public List<string> value { get { return this.valueField; } set { this.valueField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(WebstoreItemSearchAndBrowseDataPlatinum_keywords)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class WebstoreItemSearchAndBrowseDataSpecific_uses_keywords { private List<string> valueField; private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public BooleanType delete { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool deleteSpecified { get; set; } public WebstoreItemSearchAndBrowseDataSpecific_uses_keywords() { this.valueField = new List<string>(); }[System.Xml.Serialization.XmlElementAttribute("value", DataType = "normalizedString")] public List<string> value { get { return this.valueField; } set { this.valueField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(WebstoreItemSearchAndBrowseDataSpecific_uses_keywords)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class WebstoreItemSearchAndBrowseDataTarget_audience_keywords { private List<string> valueField; private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public BooleanType delete { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool deleteSpecified { get; set; } public WebstoreItemSearchAndBrowseDataTarget_audience_keywords() { this.valueField = new List<string>(); }[System.Xml.Serialization.XmlElementAttribute("value", DataType = "normalizedString")] public List<string> value { get { return this.valueField; } set { this.valueField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(WebstoreItemSearchAndBrowseDataTarget_audience_keywords)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class WebstoreItemSearchAndBrowseDataThesaurus_attribute_keywords { private List<string> valueField; private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public BooleanType delete { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool deleteSpecified { get; set; } public WebstoreItemSearchAndBrowseDataThesaurus_attribute_keywords() { this.valueField = new List<string>(); }[System.Xml.Serialization.XmlElementAttribute("value", DataType = "normalizedString")] public List<string> value { get { return this.valueField; } set { this.valueField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(WebstoreItemSearchAndBrowseDataThesaurus_attribute_keywords)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class WebstoreItemSearchAndBrowseDataThesaurus_subject_keywords { private List<string> valueField; private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public BooleanType delete { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool deleteSpecified { get; set; } public WebstoreItemSearchAndBrowseDataThesaurus_subject_keywords() { this.valueField = new List<string>(); }[System.Xml.Serialization.XmlElementAttribute("value", DataType = "normalizedString")] public List<string> value { get { return this.valueField; } set { this.valueField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(WebstoreItemSearchAndBrowseDataThesaurus_subject_keywords)); } return serializer; } } 
}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum WebstoreItemDescriptionDataOffering_conditionValue
	{

		/// <remarks/>
		New,

		/// <remarks/>
		Used,

		/// <remarks/>
		Collectible,

		/// <remarks/>
		Refurbished,

		/// <remarks/>
		Club,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum WebstoreItemDescriptionDataOffering_subconditionValue
	{

		/// <remarks/>
		New,

		/// <remarks/>
		LikeNew,

		/// <remarks/>
		VeryGood,

		/// <remarks/>
		Good,

		/// <remarks/>
		Acceptable,

		/// <remarks/>
		Refurbished,
	}
}
