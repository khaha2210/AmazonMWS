using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class Offer : AmazonMessageChoice
	{
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] [System.ComponentModel.DesignerCategoryAttribute("code")] [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class OfferSku { private static System.Xml.Serialization.XmlSerializer serializer;[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(OfferSku)); } return serializer; } } }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] [System.ComponentModel.DesignerCategoryAttribute("code")] [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class OfferMarketplaceData { private DateValue launch_dateField; private static System.Xml.Serialization.XmlSerializer serializer;[System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")] public string market_name { get; set; } public OfferMarketplaceData() { this.launch_dateField = new DateValue(); } public DateValue launch_date { get { return this.launch_dateField; } set { this.launch_dateField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(OfferMarketplaceData)); } return serializer; } } }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] [System.ComponentModel.DesignerCategoryAttribute("code")] [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class OfferDescriptionData { private BooleanValue can_be_giftmessagedField; private BooleanValue can_be_giftwrappedField; private OfferDescriptionDataEan eanField; private OfferDescriptionDataIsbn isbnField; private OfferDescriptionDataOffering_condition offering_conditionField; private OfferDescriptionDataOffering_subcondition offering_subconditionField; private StringValue product_tax_codeField; private OfferDescriptionDataUpc upcField; private static System.Xml.Serialization.XmlSerializer serializer; public OfferDescriptionData() { this.upcField = new OfferDescriptionDataUpc(); this.product_tax_codeField = new StringValue(); this.offering_subconditionField = new OfferDescriptionDataOffering_subcondition(); this.offering_conditionField = new OfferDescriptionDataOffering_condition(); this.isbnField = new OfferDescriptionDataIsbn(); this.eanField = new OfferDescriptionDataEan(); this.can_be_giftwrappedField = new BooleanValue(); this.can_be_giftmessagedField = new BooleanValue(); } public BooleanValue can_be_giftmessaged { get { return this.can_be_giftmessagedField; } set { this.can_be_giftmessagedField = value; } } public BooleanValue can_be_giftwrapped { get { return this.can_be_giftwrappedField; } set { this.can_be_giftwrappedField = value; } } public OfferDescriptionDataEan ean { get { return this.eanField; } set { this.eanField = value; } } public OfferDescriptionDataIsbn isbn { get { return this.isbnField; } set { this.isbnField = value; } } public OfferDescriptionDataOffering_condition offering_condition { get { return this.offering_conditionField; } set { this.offering_conditionField = value; } } public OfferDescriptionDataOffering_subcondition offering_subcondition { get { return this.offering_subconditionField; } set { this.offering_subconditionField = value; } } public StringValue product_tax_code { get { return this.product_tax_codeField; } set { this.product_tax_codeField = value; } } public OfferDescriptionDataUpc upc { get { return this.upcField; } set { this.upcField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(OfferDescriptionData)); } return serializer; } } }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] [System.ComponentModel.DesignerCategoryAttribute("code")] [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class OfferAdditionalData { private List<System.Xml.XmlElement> anyField; private static System.Xml.Serialization.XmlSerializer serializer; public OfferAdditionalData() { this.anyField = new List<System.Xml.XmlElement>(); }[System.Xml.Serialization.XmlAnyElementAttribute()] public List<System.Xml.XmlElement> Any { get { return this.anyField; } set { this.anyField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(OfferAdditionalData)); } return serializer; } } }

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] [System.ComponentModel.DesignerCategoryAttribute("code")] [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class OfferDescriptionDataEan { private List<string> valueField; private static System.Xml.Serialization.XmlSerializer serializer;[System.Xml.Serialization.XmlAttributeAttribute()] public BooleanType delete { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool deleteSpecified { get; set; } public OfferDescriptionDataEan() { this.valueField = new List<string>(); }[System.Xml.Serialization.XmlElementAttribute("value", DataType = "normalizedString")] public List<string> value { get { return this.valueField; } set { this.valueField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(OfferDescriptionDataEan)); } return serializer; } } }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] [System.ComponentModel.DesignerCategoryAttribute("code")] [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class OfferDescriptionDataIsbn { private static System.Xml.Serialization.XmlSerializer serializer;[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string value { get; set; }[System.Xml.Serialization.XmlAttributeAttribute()] public BooleanType delete { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool deleteSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(OfferDescriptionDataIsbn)); } return serializer; } } }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] [System.ComponentModel.DesignerCategoryAttribute("code")] [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class OfferDescriptionDataOffering_condition { private static System.Xml.Serialization.XmlSerializer serializer; public OfferDescriptionDataOffering_conditionValue value { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool valueSpecified { get; set; }[System.Xml.Serialization.XmlAttributeAttribute()] public BooleanType delete { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool deleteSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(OfferDescriptionDataOffering_condition)); } return serializer; } } }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] [System.ComponentModel.DesignerCategoryAttribute("code")] [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class OfferDescriptionDataOffering_subcondition { private static System.Xml.Serialization.XmlSerializer serializer; public OfferDescriptionDataOffering_subconditionValue value { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool valueSpecified { get; set; }[System.Xml.Serialization.XmlAttributeAttribute()] public BooleanType delete { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool deleteSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(OfferDescriptionDataOffering_subcondition)); } return serializer; } } }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] [System.ComponentModel.DesignerCategoryAttribute("code")] [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class OfferDescriptionDataUpc { private List<string> valueField; private static System.Xml.Serialization.XmlSerializer serializer;[System.Xml.Serialization.XmlAttributeAttribute()] public BooleanType delete { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool deleteSpecified { get; set; } public OfferDescriptionDataUpc() { this.valueField = new List<string>(); }[System.Xml.Serialization.XmlElementAttribute("value", DataType = "normalizedString")] public List<string> value { get { return this.valueField; } set { this.valueField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(OfferDescriptionDataUpc)); } return serializer; } } }

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum OfferDescriptionDataOffering_conditionValue
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
	public enum OfferDescriptionDataOffering_subconditionValue
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
