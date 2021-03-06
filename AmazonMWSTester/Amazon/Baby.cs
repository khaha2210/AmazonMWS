﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class Baby : ProductProductData
	{
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class BabyProductType
	{
		private BabyProducts itemField; private static System.Xml.Serialization.XmlSerializer serializer; public BabyProductType() { this.itemField = new BabyProducts(); }
		[System.Xml.Serialization.XmlElementAttribute("BabyProducts")] public BabyProducts Item { get { return this.itemField; } set { this.itemField = value; } }
		private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(BabyProductType)); } return serializer; } }
	}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum CarSeatWeightGroupEUType { group_zero, group_zero_plus, group_one, group_two, group_three, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class BabyProductsVariationData
	{
		private static System.Xml.Serialization.XmlSerializer serializer; public BabyProductsVariationDataParentage Parentage { get; set; }
		public BabyProductsVariationDataVariationTheme VariationTheme { get; set; }
		[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; }
		private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(BabyProductsVariationData)); } return serializer; } }
	}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class BabyProductsUnitCount
	{
		private static System.Xml.Serialization.XmlSerializer serializer;
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")] public string unitOfMeasure { get; set; }
		[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; }
		private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(BabyProductsUnitCount)); } return serializer; } }
	}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum LanguageStringType { Abkhazian, Adygei, Afar, Afrikaans, Albanian, Alsatian, Amharic, Arabic, Aramaic, Armenian, Assamese, Aymara, Azerbaijani, Bambara, Bashkir, Basque, Bengali, Berber, Bhutani, Bihari, Bislama, Breton, Bulgarian, Burmese, Buryat, Byelorussian, CantoneseChinese, Castillian, Catalan, Cayuga, Cheyenne, Chinese, ClassicalNewari, Cornish, Corsican, Creole, CrimeanTatar, Croatian, Czech, Danish, Dargwa, Dutch, English, Esperanto, Estonian, Faroese, Farsi, Fiji, Filipino, Finnish, Flemish, French, FrenchCanadian, Frisian, Galician, Georgian, German, Gibberish, Greek, Greenlandic, Guarani, Gujarati, Gullah, Hausa, Hawaiian, Hebrew, Hindi, Hmong, Hungarian, Icelandic, IndoEuropean, Indonesian, Ingush, Interlingua, Interlingue, Inuktitun, Inuktitut, Inupiak, Inupiaq, Irish, Italian, Japanese, Javanese, Kalaallisut, Kalmyk, Kannada, KarachayBalkar, Kashmiri, Kashubian, Kazakh, Khmer, Kinyarwanda, Kirghiz, Kirundi, Klingon, Korean, Kurdish, Ladino, Lao, Lapp, Latin, Latvian, Lingala, Lithuanian, Lojban, LowerSorbian, Macedonian, Malagasy, Malay, Malayalam, Maltese, MandarinChinese, Maori, Marathi, Mende, MiddleEnglish, Mirandese, Moksha, Moldavian, Mongo, Mongolian, Multilingual, Nauru, Navaho, Nepali, Nogai, Norwegian, Occitan, OldEnglish, Oriya, Oromo, Pashto, Persian, PigLatin, Polish, Portuguese, Punjabi, Quechua, Romance, Romanian, Romany, Russian, Samaritan, Samoan, Sangho, Sanskrit, Serbian, [System.Xml.Serialization.XmlEnumAttribute("Serbo-Croatian")] SerboCroatian, Sesotho, Setswana, Shona, SichuanYi, Sicilian, SignLanguage, Sindhi, Sinhalese, Siswati, Slavic, Slovak, Slovakian, Slovene, Somali, Spanish, Sumerian, Sundanese, Swahili, Swedish, SwissGerman, Syriac, Tagalog, TaiwaneseChinese, Tajik, Tamil, Tatar, Telugu, Thai, Tibetan, Tigrinya, Tonga, Tsonga, Turkish, Turkmen, Twi, Udmurt, Uighur, Ukrainian, Ukranian, Unknown, Urdu, Uzbek, Vietnamese, Volapuk, Welsh, Wolof, Xhosa, Yiddish, Yoruba, Zhuang, Zulu, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum BabyProductsLithiumBatteryPackaging { batteries_contained_in_equipment, batteries_only, batteries_packed_with_equipment, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum TargetGenderType { male, female, unisex, }

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum BabyProductsVariationDataParentage { parent, child, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum BabyProductsVariationDataVariationTheme { Size, Color, [System.Xml.Serialization.XmlEnumAttribute("Size-Color")] SizeColor, }


}
