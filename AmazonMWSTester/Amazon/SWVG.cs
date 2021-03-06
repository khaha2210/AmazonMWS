﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class SWVG : ProductProductData
	{
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class SoftwareVideoGamesProductType { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute("HandheldSoftwareDownloads", typeof(HandheldSoftwareDownloads))]
[System.Xml.Serialization.XmlElementAttribute("Software", typeof(Software))]
[System.Xml.Serialization.XmlElementAttribute("SoftwareGames", typeof(SoftwareGames))]
[System.Xml.Serialization.XmlElementAttribute("VideoGames", typeof(VideoGames))]
[System.Xml.Serialization.XmlElementAttribute("VideoGamesAccessories", typeof(VideoGamesAccessories))]
[System.Xml.Serialization.XmlElementAttribute("VideoGamesHardware", typeof(VideoGamesHardware))] public object Item { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(SoftwareVideoGamesProductType)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum LanguageSWVG { adygei, afrikaans, albanian, alsatian, amharic, arabic, armenian, assamese, bambara, basque, bengali, berber, breton, bulgarian, buryat, cantonese_chinese, castillian, catalan, cayuga, cheyenne, chinese, classical_newari, cornish, corsican, creole, crimean_tatar, croatian, czech, danish, dargwa, dutch, english, esperanto, estonian, farsi, filipino, finnish, flemish, french, french_canadian, georgian, german, gibberish, greek, gujarati, gullah, hausa, hawaiian, hebrew, hindi, hmong, hungarian, icelandic, indo_european, indonesian, ingush, inuktitun, inuktitut, inupiaq, irish, italian, japanese, kalaallisut, kalmyk, karachay_balkar, kashubian, kazakh, khmer, klingon, korean, kurdish, ladino, lao, lapp, latin, lithuanian, lojban, lower_sorbian, macedonian, malagasy, malay, malayalam, maltese, mandarin_chinese, maori, mende, middle_english, mirandese, moksha, mongo, mongolian, multilingual, navaho, nogai, norwegian, old_english, persian, pig_latin, polish, portuguese, romance, romanian, romany, russian, samaritan, sanskrit, serbian, [System.Xml.Serialization.XmlEnumAttribute("serbo-croatian")] serbocroatian, sichuan_yi, sicilian, sign_language, slavic, slovak, slovene, somali, spanish, sumerian, swahili, swedish, swiss_german, tagalog, taiwanese_chinese, tamil, thai, tibetan, turkish, udmurt, ukrainian, unknown, urdu, vietnamese, welsh, wolof, xhosa, yiddish, zulu, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum SoftwareVideoGamesParentage { parent, child, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum SoftwareVideoGamesVariationTheme { Color, Size, [System.Xml.Serialization.XmlEnumAttribute("Size-Color")] SizeColor, Scent, [System.Xml.Serialization.XmlEnumAttribute("Size-Scent")] SizeScent, CustomerPackageType, [System.Xml.Serialization.XmlEnumAttribute("ColorName-CustomerPackageType")] ColorNameCustomerPackageType, [System.Xml.Serialization.XmlEnumAttribute("SizeName-CustomerPackageType")] SizeNameCustomerPackageType, [System.Xml.Serialization.XmlEnumAttribute("SizeName-ColorName-CustomerPackageType")] SizeNameColorNameCustomerPackageType, [System.Xml.Serialization.XmlEnumAttribute("StyleName-CustomerPackageType")] StyleNameCustomerPackageType, [System.Xml.Serialization.XmlEnumAttribute("SizeName-StyleName-CustomerPackageType")] SizeNameStyleNameCustomerPackageType, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum SoftwareVideoGamesIdentityPackageType { bulk, frustration_free, traditional, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum SoftwareVideoGamesLithiumBatteryPackaging { batteries_contained_in_equipment, batteries_only, batteries_packed_with_equipment, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum SoftwareVideoGamesTargetGender { male, female, unisex, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum BBFCRatingType { ages_12_and_over, ages_15_and_over, ages_18_and_over, exempt, parental_guidance, to_be_announced, universal_childrens, universal, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum PEGIRatingType { ages_3_and_over, ages_7_and_over, ages_12_and_over, ages_16_and_over, ages_18_and_over, unknown, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum USKRatingType { ages_6_and_over, ages_12_and_over, ages_16_and_over, ages_18_and_over, cannot_publicize, checked_by_legal_department, not_checked, without_age_limitation, unknown, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum HardwarePlatformType { linux, mac, windows, unix, }

}
