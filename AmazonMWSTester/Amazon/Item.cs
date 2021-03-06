﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class Item : AmazonMessageChoice
	{
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ItemSku { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ItemSku)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ItemMarketplaceData { private PriceUnitValue contribution_marginField; private DateValue discontinue_dateField; private BooleanValue free_shippingField; private DateValue launch_dateField; private IntegerValue max_ordering_quantityField; private PriceUnitValue msrpField; private BooleanValue offering_can_ship_in_original_containerField; private DateValue release_dateField; private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")] public string market_name { get; set; } public ItemMarketplaceData() { this.release_dateField = new DateValue(); this.offering_can_ship_in_original_containerField = new BooleanValue(); this.msrpField = new PriceUnitValue(); this.max_ordering_quantityField = new IntegerValue(); this.launch_dateField = new DateValue(); this.free_shippingField = new BooleanValue(); this.discontinue_dateField = new DateValue(); this.contribution_marginField = new PriceUnitValue(); } public PriceUnitValue contribution_margin { get { return this.contribution_marginField; } set { this.contribution_marginField = value; } } public DateValue discontinue_date { get { return this.discontinue_dateField; } set { this.discontinue_dateField = value; } } public BooleanValue free_shipping { get { return this.free_shippingField; } set { this.free_shippingField = value; } } public DateValue launch_date { get { return this.launch_dateField; } set { this.launch_dateField = value; } } public IntegerValue max_ordering_quantity { get { return this.max_ordering_quantityField; } set { this.max_ordering_quantityField = value; } } public PriceUnitValue msrp { get { return this.msrpField; } set { this.msrpField = value; } } public BooleanValue offering_can_ship_in_original_container { get { return this.offering_can_ship_in_original_containerField; } set { this.offering_can_ship_in_original_containerField = value; } } public DateValue release_date { get { return this.release_dateField; } set { this.release_dateField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ItemMarketplaceData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ItemDescriptionData { private StringValue brand_nameField; private ItemDescriptionDataBullet_point bullet_pointField; private BooleanValue can_be_giftmessagedField; private BooleanValue can_be_giftwrappedField; private ItemDescriptionDataEan eanField; private ItemDescriptionDataEan8 ean8Field; private ItemDescriptionDataGtin gtinField; private ItemDescriptionDataIsbn isbnField; private ItemDescriptionDataItemDimensions itemDimensionsField; private List<ItemDescriptionDataItem_name> item_nameField; private WeightValue item_weightField; private LongStringValue manufacturerField; private ItemDescriptionDataOffering_condition offering_conditionField; private ItemDescriptionDataOffering_subcondition offering_subconditionField; private WeightValue package_weightField; private ItemDescriptionDataPart_number part_numberField; private List<ItemDescriptionDataProduct_description> product_descriptionField; private StringValue product_tax_codeField; private ItemDescriptionDataUpc upcField; private static System.Xml.Serialization.XmlSerializer serializer; public ItemDescriptionData() { this.upcField = new ItemDescriptionDataUpc(); this.product_tax_codeField = new StringValue(); this.product_descriptionField = new List<ItemDescriptionDataProduct_description>(); this.part_numberField = new ItemDescriptionDataPart_number(); this.package_weightField = new WeightValue(); this.offering_subconditionField = new ItemDescriptionDataOffering_subcondition(); this.offering_conditionField = new ItemDescriptionDataOffering_condition(); this.manufacturerField = new LongStringValue(); this.item_weightField = new WeightValue(); this.item_nameField = new List<ItemDescriptionDataItem_name>(); this.itemDimensionsField = new ItemDescriptionDataItemDimensions(); this.isbnField = new ItemDescriptionDataIsbn(); this.gtinField = new ItemDescriptionDataGtin(); this.ean8Field = new ItemDescriptionDataEan8(); this.eanField = new ItemDescriptionDataEan(); this.can_be_giftwrappedField = new BooleanValue(); this.can_be_giftmessagedField = new BooleanValue(); this.bullet_pointField = new ItemDescriptionDataBullet_point(); this.brand_nameField = new StringValue(); } public StringValue brand_name { get { return this.brand_nameField; } set { this.brand_nameField = value; } } public ItemDescriptionDataBullet_point bullet_point { get { return this.bullet_pointField; } set { this.bullet_pointField = value; } } public BooleanValue can_be_giftmessaged { get { return this.can_be_giftmessagedField; } set { this.can_be_giftmessagedField = value; } } public BooleanValue can_be_giftwrapped { get { return this.can_be_giftwrappedField; } set { this.can_be_giftwrappedField = value; } } public ItemDescriptionDataEan ean { get { return this.eanField; } set { this.eanField = value; } } public ItemDescriptionDataEan8 ean8 { get { return this.ean8Field; } set { this.ean8Field = value; } } public ItemDescriptionDataGtin gtin { get { return this.gtinField; } set { this.gtinField = value; } } public ItemDescriptionDataIsbn isbn { get { return this.isbnField; } set { this.isbnField = value; } } public ItemDescriptionDataItemDimensions ItemDimensions { get { return this.itemDimensionsField; } set { this.itemDimensionsField = value; } }[System.Xml.Serialization.XmlElementAttribute("item_name")] public List<ItemDescriptionDataItem_name> item_name { get { return this.item_nameField; } set { this.item_nameField = value; } } public WeightValue item_weight { get { return this.item_weightField; } set { this.item_weightField = value; } } public LongStringValue manufacturer { get { return this.manufacturerField; } set { this.manufacturerField = value; } } public ItemDescriptionDataOffering_condition offering_condition { get { return this.offering_conditionField; } set { this.offering_conditionField = value; } } public ItemDescriptionDataOffering_subcondition offering_subcondition { get { return this.offering_subconditionField; } set { this.offering_subconditionField = value; } } public WeightValue package_weight { get { return this.package_weightField; } set { this.package_weightField = value; } } public ItemDescriptionDataPart_number part_number { get { return this.part_numberField; } set { this.part_numberField = value; } }[System.Xml.Serialization.XmlElementAttribute("product_description")] public List<ItemDescriptionDataProduct_description> product_description { get { return this.product_descriptionField; } set { this.product_descriptionField = value; } } public StringValue product_tax_code { get { return this.product_tax_codeField; } set { this.product_tax_codeField = value; } } public ItemDescriptionDataUpc upc { get { return this.upcField; } set { this.upcField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ItemDescriptionData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ItemSearchAndBrowseData { private BooleanValue browse_suppressedField; private ItemSearchAndBrowseDataCatalog_number catalog_numberField; private ItemSearchAndBrowseDataGeneric_keywords generic_keywordsField; private ItemSearchAndBrowseDataItem_type_keyword item_type_keywordField; private ItemSearchAndBrowseDataPlatinum_keywords platinum_keywordsField; private BooleanValue recommendation_suppressedField; private ItemSearchAndBrowseDataSpecific_uses_keywords specific_uses_keywordsField; private ItemSearchAndBrowseDataTarget_audience_keywords target_audience_keywordsField; private ItemSearchAndBrowseDataThesaurus_attribute_keywords thesaurus_attribute_keywordsField; private ItemSearchAndBrowseDataThesaurus_subject_keywords thesaurus_subject_keywordsField; private static System.Xml.Serialization.XmlSerializer serializer; public ItemSearchAndBrowseData() { this.thesaurus_subject_keywordsField = new ItemSearchAndBrowseDataThesaurus_subject_keywords(); this.thesaurus_attribute_keywordsField = new ItemSearchAndBrowseDataThesaurus_attribute_keywords(); this.target_audience_keywordsField = new ItemSearchAndBrowseDataTarget_audience_keywords(); this.specific_uses_keywordsField = new ItemSearchAndBrowseDataSpecific_uses_keywords(); this.recommendation_suppressedField = new BooleanValue(); this.platinum_keywordsField = new ItemSearchAndBrowseDataPlatinum_keywords(); this.item_type_keywordField = new ItemSearchAndBrowseDataItem_type_keyword(); this.generic_keywordsField = new ItemSearchAndBrowseDataGeneric_keywords(); this.catalog_numberField = new ItemSearchAndBrowseDataCatalog_number(); this.browse_suppressedField = new BooleanValue(); } public BooleanValue browse_suppressed { get { return this.browse_suppressedField; } set { this.browse_suppressedField = value; } } public ItemSearchAndBrowseDataCatalog_number catalog_number { get { return this.catalog_numberField; } set { this.catalog_numberField = value; } } public ItemSearchAndBrowseDataGeneric_keywords generic_keywords { get { return this.generic_keywordsField; } set { this.generic_keywordsField = value; } } public ItemSearchAndBrowseDataItem_type_keyword item_type_keyword { get { return this.item_type_keywordField; } set { this.item_type_keywordField = value; } } public ItemSearchAndBrowseDataPlatinum_keywords platinum_keywords { get { return this.platinum_keywordsField; } set { this.platinum_keywordsField = value; } } public BooleanValue recommendation_suppressed { get { return this.recommendation_suppressedField; } set { this.recommendation_suppressedField = value; } } public ItemSearchAndBrowseDataSpecific_uses_keywords specific_uses_keywords { get { return this.specific_uses_keywordsField; } set { this.specific_uses_keywordsField = value; } } public ItemSearchAndBrowseDataTarget_audience_keywords target_audience_keywords { get { return this.target_audience_keywordsField; } set { this.target_audience_keywordsField = value; } } public ItemSearchAndBrowseDataThesaurus_attribute_keywords thesaurus_attribute_keywords { get { return this.thesaurus_attribute_keywordsField; } set { this.thesaurus_attribute_keywordsField = value; } } public ItemSearchAndBrowseDataThesaurus_subject_keywords thesaurus_subject_keywords { get { return this.thesaurus_subject_keywordsField; } set { this.thesaurus_subject_keywordsField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ItemSearchAndBrowseData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ItemAdditionalData { private List<System.Xml.XmlElement> anyField; private static System.Xml.Serialization.XmlSerializer serializer; public ItemAdditionalData() { this.anyField = new List<System.Xml.XmlElement>(); }[System.Xml.Serialization.XmlAnyElementAttribute()] public List<System.Xml.XmlElement> Any { get { return this.anyField; } set { this.anyField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ItemAdditionalData)); } return serializer; } } 
}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ItemDescriptionDataEan { private List<string> valueField; private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public BooleanType delete { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool deleteSpecified { get; set; } public ItemDescriptionDataEan() { this.valueField = new List<string>(); }[System.Xml.Serialization.XmlElementAttribute("value", DataType = "normalizedString")] public List<string> value { get { return this.valueField; } set { this.valueField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ItemDescriptionDataEan)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ItemDescriptionDataEan8 { private List<string> valueField; private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public BooleanType delete { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool deleteSpecified { get; set; } public ItemDescriptionDataEan8() { this.valueField = new List<string>(); }[System.Xml.Serialization.XmlElementAttribute("value", DataType = "normalizedString")] public List<string> value { get { return this.valueField; } set { this.valueField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ItemDescriptionDataEan8)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ItemDescriptionDataGtin { private List<string> valueField; private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public BooleanType delete { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool deleteSpecified { get; set; } public ItemDescriptionDataGtin() { this.valueField = new List<string>(); }[System.Xml.Serialization.XmlElementAttribute("value", DataType = "normalizedString")] public List<string> value { get { return this.valueField; } set { this.valueField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ItemDescriptionDataGtin)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ItemDescriptionDataIsbn { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string value { get; set; }[System.Xml.Serialization.XmlAttributeAttribute()] public BooleanType delete { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool deleteSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ItemDescriptionDataIsbn)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ItemDescriptionDataItemDimensions { private DimensionValue item_heightField; private DimensionValue item_lengthField; private DimensionValue item_widthField; private static System.Xml.Serialization.XmlSerializer serializer; public ItemDescriptionDataItemDimensions() { this.item_widthField = new DimensionValue(); this.item_lengthField = new DimensionValue(); this.item_heightField = new DimensionValue(); } public DimensionValue item_height { get { return this.item_heightField; } set { this.item_heightField = value; } } public DimensionValue item_length { get { return this.item_lengthField; } set { this.item_lengthField = value; } } public DimensionValue item_width { get { return this.item_widthField; } set { this.item_widthField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ItemDescriptionDataItemDimensions)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ItemDescriptionDataItem_name { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string value { get; set; }[System.Xml.Serialization.XmlAttributeAttribute()] public LanguageType language { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool languageSpecified { get; set; }[System.Xml.Serialization.XmlAttributeAttribute()] public BooleanType delete { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool deleteSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ItemDescriptionDataItem_name)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ItemDescriptionDataOffering_condition { private static System.Xml.Serialization.XmlSerializer serializer; public ItemDescriptionDataOffering_conditionValue value { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool valueSpecified { get; set; }[System.Xml.Serialization.XmlAttributeAttribute()] public BooleanType delete { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool deleteSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ItemDescriptionDataOffering_condition)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ItemDescriptionDataOffering_subcondition { private static System.Xml.Serialization.XmlSerializer serializer; public ItemDescriptionDataOffering_subconditionValue value { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool valueSpecified { get; set; }[System.Xml.Serialization.XmlAttributeAttribute()] public BooleanType delete { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool deleteSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ItemDescriptionDataOffering_subcondition)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ItemDescriptionDataPart_number { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string value { get; set; }[System.Xml.Serialization.XmlAttributeAttribute()] public BooleanType delete { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool deleteSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ItemDescriptionDataPart_number)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ItemDescriptionDataProduct_description { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string value { get; set; }[System.Xml.Serialization.XmlAttributeAttribute()] public LanguageType language { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool languageSpecified { get; set; }[System.Xml.Serialization.XmlAttributeAttribute()] public BooleanType delete { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool deleteSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ItemDescriptionDataProduct_description)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ItemDescriptionDataUpc { private List<string> valueField; private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public BooleanType delete { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool deleteSpecified { get; set; } public ItemDescriptionDataUpc() { this.valueField = new List<string>(); }[System.Xml.Serialization.XmlElementAttribute("value", DataType = "normalizedString")] public List<string> value { get { return this.valueField; } set { this.valueField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ItemDescriptionDataUpc)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ItemSearchAndBrowseDataCatalog_number { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string value { get; set; }[System.Xml.Serialization.XmlAttributeAttribute()] public BooleanType delete { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool deleteSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ItemSearchAndBrowseDataCatalog_number)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ItemSearchAndBrowseDataGeneric_keywords { private List<string> valueField; private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public BooleanType delete { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool deleteSpecified { get; set; } public ItemSearchAndBrowseDataGeneric_keywords() { this.valueField = new List<string>(); }[System.Xml.Serialization.XmlElementAttribute("value", DataType = "normalizedString")] public List<string> value { get { return this.valueField; } set { this.valueField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ItemSearchAndBrowseDataGeneric_keywords)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ItemSearchAndBrowseDataItem_type_keyword { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string value { get; set; }[System.Xml.Serialization.XmlAttributeAttribute()] public BooleanType delete { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool deleteSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ItemSearchAndBrowseDataItem_type_keyword)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ItemSearchAndBrowseDataPlatinum_keywords { private List<string> valueField; private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public BooleanType delete { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool deleteSpecified { get; set; } public ItemSearchAndBrowseDataPlatinum_keywords() { this.valueField = new List<string>(); }[System.Xml.Serialization.XmlElementAttribute("value", DataType = "normalizedString")] public List<string> value { get { return this.valueField; } set { this.valueField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ItemSearchAndBrowseDataPlatinum_keywords)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ItemSearchAndBrowseDataSpecific_uses_keywords { private List<string> valueField; private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public BooleanType delete { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool deleteSpecified { get; set; } public ItemSearchAndBrowseDataSpecific_uses_keywords() { this.valueField = new List<string>(); }[System.Xml.Serialization.XmlElementAttribute("value", DataType = "normalizedString")] public List<string> value { get { return this.valueField; } set { this.valueField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ItemSearchAndBrowseDataSpecific_uses_keywords)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ItemSearchAndBrowseDataTarget_audience_keywords { private List<string> valueField; private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public BooleanType delete { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool deleteSpecified { get; set; } public ItemSearchAndBrowseDataTarget_audience_keywords() { this.valueField = new List<string>(); }[System.Xml.Serialization.XmlElementAttribute("value", DataType = "normalizedString")] public List<string> value { get { return this.valueField; } set { this.valueField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ItemSearchAndBrowseDataTarget_audience_keywords)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ItemSearchAndBrowseDataThesaurus_attribute_keywords { private List<string> valueField; private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public BooleanType delete { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool deleteSpecified { get; set; } public ItemSearchAndBrowseDataThesaurus_attribute_keywords() { this.valueField = new List<string>(); }[System.Xml.Serialization.XmlElementAttribute("value", DataType = "normalizedString")] public List<string> value { get { return this.valueField; } set { this.valueField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ItemSearchAndBrowseDataThesaurus_attribute_keywords)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ItemSearchAndBrowseDataThesaurus_subject_keywords { private List<string> valueField; private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public BooleanType delete { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool deleteSpecified { get; set; } public ItemSearchAndBrowseDataThesaurus_subject_keywords() { this.valueField = new List<string>(); }[System.Xml.Serialization.XmlElementAttribute("value", DataType = "normalizedString")] public List<string> value { get { return this.valueField; } set { this.valueField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ItemSearchAndBrowseDataThesaurus_subject_keywords)); } return serializer; } } 
}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum ItemDescriptionDataOffering_conditionValue
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
	public enum ItemDescriptionDataOffering_subconditionValue
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

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class WebstoreItemDescriptionDataBullet_point
	{

		private List<string> valueField;


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public LanguageType language { get; set; }

		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool languageSpecified { get; set; }

		[System.Xml.Serialization.XmlAttributeAttribute()]
		public BooleanType delete { get; set; }

		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool deleteSpecified { get; set; }


	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class ItemDescriptionDataBullet_point
	{

		private List<string> valueField;

		private static System.Xml.Serialization.XmlSerializer serializer;

		[System.Xml.Serialization.XmlAttributeAttribute()]
		public LanguageType language { get; set; }

		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool languageSpecified { get; set; }

		[System.Xml.Serialization.XmlAttributeAttribute()]
		public BooleanType delete { get; set; }

		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool deleteSpecified { get; set; }


		public ItemDescriptionDataBullet_point()
		{
			this.valueField = new List<string>();
		}

		[System.Xml.Serialization.XmlElementAttribute("value", DataType = "normalizedString")]
		public List<string> value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}
	}
	}
	
	
