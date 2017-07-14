using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class ToysBaby : ProductProductData
	{
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum ToysBabyToyAwardName { baby_and_you, babyworld, child_magazine, dr_toys_100_best_child_products, family_fun_toy_of_the_year_seal, games_magazine, gomama_today, junior, lion_mark, mother_and_baby, mum_knows_best, national_parenting_approval_award, oppenheim_toys, parents_choice_portfolio, parents_magazine, practical_parenting, prima_baby, reddot, the_times, toy_wishes, unknown, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ToysBabySeatLength { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public LengthUnitOfMeasure unitOfMeasure { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool unitOfMeasureSpecified { get; set; }[System.Xml.Serialization.XmlTextAttribute(DataType = "normalizedString")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ToysBabySeatLength)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ToysBabySeatWidth { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public LengthUnitOfMeasure unitOfMeasure { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool unitOfMeasureSpecified { get; set; }[System.Xml.Serialization.XmlTextAttribute(DataType = "normalizedString")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ToysBabySeatWidth)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ToysBabyTireDiameter { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public LengthUnitOfMeasure unitOfMeasure { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool unitOfMeasureSpecified { get; set; }[System.Xml.Serialization.XmlTextAttribute(DataType = "normalizedString")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ToysBabyTireDiameter)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ToysBabyUnitCount { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")] public string unitOfMeasure { get; set; }[System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ToysBabyUnitCount)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ToysBabyVariationData { private static System.Xml.Serialization.XmlSerializer serializer; public ToysBabyVariationDataParentage Parentage { get; set; } public ToysBabyVariationDataVariationTheme VariationTheme { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ToysBabyVariationData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum ToysBabyProductType { ToysAndGames, BabyProducts, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum ToysBabyTargetGender { male, female, unisex, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum ToysBabyLithiumBatteryPackaging { batteries_contained_in_equipment, batteries_only, batteries_packed_with_equipment, }

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum ToysBabyVariationDataParentage { parent, child, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum ToysBabyVariationDataVariationTheme { Size, Color, [System.Xml.Serialization.XmlEnumAttribute("Size-Color")] SizeColor, }

}
