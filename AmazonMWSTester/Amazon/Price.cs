﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class Price : AmazonMessageChoice
	{
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class PriceQuantityPrice { private static System.Xml.Serialization.XmlSerializer serializer; public decimal QuantityPrice1 { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool QuantityPrice1Specified { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")] public string QuantityLowerBound1 { get; set; } public decimal QuantityPrice2 { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool QuantityPrice2Specified { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")] public string QuantityLowerBound2 { get; set; } public decimal QuantityPrice3 { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool QuantityPrice3Specified { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")] public string QuantityLowerBound3 { get; set; } public decimal QuantityPrice4 { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool QuantityPrice4Specified { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")] public string QuantityLowerBound4 { get; set; } public decimal QuantityPrice5 { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool QuantityPrice5Specified { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")] public string QuantityLowerBound5 { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(PriceQuantityPrice)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class PriceSale { private OverrideCurrencyAmount salePriceField; private static System.Xml.Serialization.XmlSerializer serializer; public System.DateTime StartDate { get; set; } public System.DateTime EndDate { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")] public string SalePricePoints { get; set; } public PriceSale() { this.salePriceField = new OverrideCurrencyAmount(); } public OverrideCurrencyAmount SalePrice { get { return this.salePriceField; } set { this.salePriceField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(PriceSale)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class PriceRental_0 { private OverrideCurrencyAmountWithTax rentalPriceField; private static System.Xml.Serialization.XmlSerializer serializer; public System.DateTime StartDate { get; set; } public System.DateTime EndDate { get; set; } public PriceRental_0() { this.rentalPriceField = new OverrideCurrencyAmountWithTax(); } public OverrideCurrencyAmountWithTax RentalPrice { get { return this.rentalPriceField; } set { this.rentalPriceField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(PriceRental_0)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class PriceRental_1 { private OverrideCurrencyAmountWithTax rentalPriceField; private static System.Xml.Serialization.XmlSerializer serializer; public System.DateTime StartDate { get; set; } public System.DateTime EndDate { get; set; } public PriceRental_1() { this.rentalPriceField = new OverrideCurrencyAmountWithTax(); } public OverrideCurrencyAmountWithTax RentalPrice { get { return this.rentalPriceField; } set { this.rentalPriceField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(PriceRental_1)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class PriceRental_2 { private OverrideCurrencyAmountWithTax rentalPriceField; private static System.Xml.Serialization.XmlSerializer serializer; public System.DateTime StartDate { get; set; } public System.DateTime EndDate { get; set; } public PriceRental_2() { this.rentalPriceField = new OverrideCurrencyAmountWithTax(); } public OverrideCurrencyAmountWithTax RentalPrice { get { return this.rentalPriceField; } set { this.rentalPriceField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(PriceRental_2)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class PriceRental_3 { private OverrideCurrencyAmountWithTax rentalPriceField; private static System.Xml.Serialization.XmlSerializer serializer; public System.DateTime StartDate { get; set; } public System.DateTime EndDate { get; set; } public PriceRental_3() { this.rentalPriceField = new OverrideCurrencyAmountWithTax(); } public OverrideCurrencyAmountWithTax RentalPrice { get { return this.rentalPriceField; } set { this.rentalPriceField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(PriceRental_3)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class PriceRental_4 { private OverrideCurrencyAmountWithTax rentalPriceField; private static System.Xml.Serialization.XmlSerializer serializer; public System.DateTime StartDate { get; set; } public System.DateTime EndDate { get; set; } public PriceRental_4() { this.rentalPriceField = new OverrideCurrencyAmountWithTax(); } public OverrideCurrencyAmountWithTax RentalPrice { get { return this.rentalPriceField; } set { this.rentalPriceField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(PriceRental_4)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class PriceRental_5 { private OverrideCurrencyAmountWithTax rentalPriceField; private static System.Xml.Serialization.XmlSerializer serializer; public System.DateTime StartDate { get; set; } public System.DateTime EndDate { get; set; } public PriceRental_5() { this.rentalPriceField = new OverrideCurrencyAmountWithTax(); } public OverrideCurrencyAmountWithTax RentalPrice { get { return this.rentalPriceField; } set { this.rentalPriceField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(PriceRental_5)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class PriceRental_6 { private OverrideCurrencyAmountWithTax rentalPriceField; private static System.Xml.Serialization.XmlSerializer serializer; public System.DateTime StartDate { get; set; } public System.DateTime EndDate { get; set; } public PriceRental_6() { this.rentalPriceField = new OverrideCurrencyAmountWithTax(); } public OverrideCurrencyAmountWithTax RentalPrice { get { return this.rentalPriceField; } set { this.rentalPriceField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(PriceRental_6)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class PriceRental_7 { private OverrideCurrencyAmountWithTax rentalPriceField; private static System.Xml.Serialization.XmlSerializer serializer; public System.DateTime StartDate { get; set; } public System.DateTime EndDate { get; set; } public PriceRental_7() { this.rentalPriceField = new OverrideCurrencyAmountWithTax(); } public OverrideCurrencyAmountWithTax RentalPrice { get { return this.rentalPriceField; } set { this.rentalPriceField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(PriceRental_7)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class PriceRental_8 { private OverrideCurrencyAmountWithTax rentalPriceField; private static System.Xml.Serialization.XmlSerializer serializer; public System.DateTime StartDate { get; set; } public System.DateTime EndDate { get; set; } public PriceRental_8() { this.rentalPriceField = new OverrideCurrencyAmountWithTax(); } public OverrideCurrencyAmountWithTax RentalPrice { get { return this.rentalPriceField; } set { this.rentalPriceField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(PriceRental_8)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class PriceRental_9 { private OverrideCurrencyAmountWithTax rentalPriceField; private static System.Xml.Serialization.XmlSerializer serializer; public System.DateTime StartDate { get; set; } public System.DateTime EndDate { get; set; } public PriceRental_9() { this.rentalPriceField = new OverrideCurrencyAmountWithTax(); } public OverrideCurrencyAmountWithTax RentalPrice { get { return this.rentalPriceField; } set { this.rentalPriceField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(PriceRental_9)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum QuantityPriceTypes { @fixed, percent, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum BaseCurrencyCodeWithDefault { USD, GBP, EUR, JPY, CAD, CNY, INR, AUD, BRL, MXN, DEFAULT, }

}
