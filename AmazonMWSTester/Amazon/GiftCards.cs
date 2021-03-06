﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class GiftCards : ProductProductData
	{
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class GiftCardProductType { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute("ElectronicGiftCard", typeof(object))]
[System.Xml.Serialization.XmlElementAttribute("GiftCard", typeof(GiftCardProductTypeGiftCard))]
[System.Xml.Serialization.XmlElementAttribute("PhysicalGiftCard", typeof(GiftCardProductTypePhysicalGiftCard))] public object Item { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(GiftCardProductType)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum GiftCardsFormatType { email_gift_cards, plastic_gift_cards, print_at_home, multi_pack, facebook, gift_box, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class GiftCardVariationData { private static System.Xml.Serialization.XmlSerializer serializer; public GiftCardVariationDataParentage Parentage { get; set; } public GiftCardVariationDataVariationTheme VariationTheme { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; } public decimal Denomination { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool DenominationSpecified { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string StyleName { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(GiftCardVariationData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum GiftCardTargetGender { male, female, unisex, }

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class GiftCardProductTypeGiftCard { private LengthDimension itemDisplayHeightField; private LengthDimension itemDisplayLengthField; private WeightDimension itemDisplayWeightField; private LengthDimension itemDisplayWidthField; private static System.Xml.Serialization.XmlSerializer serializer; public GiftCardProductTypeGiftCard() { this.itemDisplayWidthField = new LengthDimension(); this.itemDisplayWeightField = new WeightDimension(); this.itemDisplayLengthField = new LengthDimension(); this.itemDisplayHeightField = new LengthDimension(); } public LengthDimension ItemDisplayHeight { get { return this.itemDisplayHeightField; } set { this.itemDisplayHeightField = value; } } public LengthDimension ItemDisplayLength { get { return this.itemDisplayLengthField; } set { this.itemDisplayLengthField = value; } } public WeightDimension ItemDisplayWeight { get { return this.itemDisplayWeightField; } set { this.itemDisplayWeightField = value; } } public LengthDimension ItemDisplayWidth { get { return this.itemDisplayWidthField; } set { this.itemDisplayWidthField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(GiftCardProductTypeGiftCard)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class GiftCardProductTypePhysicalGiftCard { private LengthDimension itemDisplayHeightField; private LengthDimension itemDisplayLengthField; private WeightDimension itemDisplayWeightField; private LengthDimension itemDisplayWidthField; private static System.Xml.Serialization.XmlSerializer serializer; public GiftCardProductTypePhysicalGiftCard() { this.itemDisplayWidthField = new LengthDimension(); this.itemDisplayWeightField = new WeightDimension(); this.itemDisplayLengthField = new LengthDimension(); this.itemDisplayHeightField = new LengthDimension(); } public LengthDimension ItemDisplayHeight { get { return this.itemDisplayHeightField; } set { this.itemDisplayHeightField = value; } } public LengthDimension ItemDisplayLength { get { return this.itemDisplayLengthField; } set { this.itemDisplayLengthField = value; } } public WeightDimension ItemDisplayWeight { get { return this.itemDisplayWeightField; } set { this.itemDisplayWeightField = value; } } public LengthDimension ItemDisplayWidth { get { return this.itemDisplayWidthField; } set { this.itemDisplayWidthField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(GiftCardProductTypePhysicalGiftCard)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum GiftCardVariationDataParentage { parent, child, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum GiftCardVariationDataVariationTheme { Denomination, [System.Xml.Serialization.XmlEnumAttribute("Denomination-DesignName")] DenominationDesignName, StyleName, [System.Xml.Serialization.XmlEnumAttribute("Denomination-DesignName-StyleName")] DenominationDesignNameStyleName, }

}
