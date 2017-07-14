using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class Toys : ProductProductData
	{
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ToysVariationData { private static System.Xml.Serialization.XmlSerializer serializer; public ToysVariationDataParentage Parentage { get; set; } public ToysVariationDataVariationTheme VariationTheme { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ToysVariationData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ToysProductType { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute("CollectibleCard", typeof(CollectibleCard))]
[System.Xml.Serialization.XmlElementAttribute("Costume", typeof(Costume))]
[System.Xml.Serialization.XmlElementAttribute("Hobbies", typeof(Hobbies))]
[System.Xml.Serialization.XmlElementAttribute("ToysAndGames", typeof(ToysAndGames))] public object Item { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ToysProductType)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum ToyAwardType { australia_toy_fair_boys_toy_of_the_year, australia_toy_fair_toy_of_the_year, baby_and_you, babyworld, child_magazine, creative_child_magazine, dr_toys_100_best_child_products, energizer_battery_operated_toy_of_the_yr, family_fun_toy_of_the_year_seal, games_magazine, gomama_today, german_toy_association_toy_of_the_year, hamleys_toy_of_the_year, junior, lion_mark, mother_and_baby, mum_knows_best, national_parenting_approval_award, norwegian_toy_association_toy_of_the_yr, oppenheim_toys, parents_choice_portfolio, parents_magazine, practical_parenting, prima_baby, reddot, rdj_france_best_electronic_toy_of_the_yr, rdj_france_best_toy_of_the_year, the_times, toy_wishes, uk_npd_report_number_one_selling_toy, unknown, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum HobbiesLithiumBatteryPackaging { batteries_contained_in_equipment, batteries_only, batteries_packed_with_equipment, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum ToysAndGamesLithiumBatteryPackaging { batteries_contained_in_equipment, batteries_only, batteries_packed_with_equipment, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum ToysAndGamesTargetGender { male, female, unisex, }

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum ToysVariationDataParentage { parent, child, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum ToysVariationDataVariationTheme { Color, Size, SizeColor, Style, Edition, }

}
