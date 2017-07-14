using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class Store : AmazonMessageChoice
	{
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class StoreWarehouse { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string WarehouseLocationID { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "date")] public System.DateTime StartDate { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "date")] public System.DateTime EndDate { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool EndDateSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(StoreWarehouse)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class StoreStoreFeatures { private static System.Xml.Serialization.XmlSerializer serializer; public StoreStoreFeaturesStoreFeatureType StoreFeatureType { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string StoreFeatureTypeValue { get; set; } public bool IsActive { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool IsActiveSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(StoreStoreFeatures)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class StoreStandardStoreHours { private List<StoreStandardStoreHoursMidDayClosures> midDayClosuresField; private static System.Xml.Serialization.XmlSerializer serializer; public StoreStandardStoreHoursDayOfWeek DayOfWeek { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "time")] public System.DateTime OpeningHour { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool OpeningHourSpecified { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "time")] public System.DateTime ClosingHour { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool ClosingHourSpecified { get; set; } public StoreStandardStoreHours() { this.midDayClosuresField = new List<StoreStandardStoreHoursMidDayClosures>(); }[System.Xml.Serialization.XmlElementAttribute("MidDayClosures")] public List<StoreStandardStoreHoursMidDayClosures> MidDayClosures { get { return this.midDayClosuresField; } set { this.midDayClosuresField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(StoreStandardStoreHours)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class StoreStoreHourExceptions { private List<StoreStoreHourExceptionsMidDayClosures> midDayClosuresField; private static System.Xml.Serialization.XmlSerializer serializer; public System.DateTime ExceptionDate { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "time")] public System.DateTime OpeningHour { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool OpeningHourSpecified { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "time")] public System.DateTime ClosingHour { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool ClosingHourSpecified { get; set; } public bool IsActive { get; set; } public StoreStoreHourExceptions() { this.midDayClosuresField = new List<StoreStoreHourExceptionsMidDayClosures>(); }[System.Xml.Serialization.XmlElementAttribute("MidDayClosures")] public List<StoreStoreHourExceptionsMidDayClosures> MidDayClosures { get { return this.midDayClosuresField; } set { this.midDayClosuresField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(StoreStoreHourExceptions)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class StoreStoreAddress { private static System.Xml.Serialization.XmlSerializer serializer; public string AddressFieldOne { get; set; } public string AddressFieldTwo { get; set; } public string AddressFieldThree { get; set; } public string City { get; set; } public string DistrictOrCounty { get; set; } public string StateOrRegion { get; set; } public string PostalCode { get; set; } public string VoicePhone { get; set; } public string FaxPhone { get; set; } public string CountryCode { get; set; } public float Latitude { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool LatitudeSpecified { get; set; } public float Longitude { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool LongitudeSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(StoreStoreAddress)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class StoreStoreImage { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string StoreImageTitle { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string ImageCaption { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI")] public string ImageURL { get; set; } public bool IsActive { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool IsActiveSpecified { get; set; } public bool IsPrimary { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool IsPrimarySpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(StoreStoreImage)); } return serializer; } } 
}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum StoreStoreFeaturesStoreFeatureType { CollectionPoint, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class StoreStandardStoreHoursMidDayClosures { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "time")] public System.DateTime ClosingHour { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool ClosingHourSpecified { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "time")] public System.DateTime OpeningHour { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool OpeningHourSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(StoreStandardStoreHoursMidDayClosures)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum StoreStandardStoreHoursDayOfWeek { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class StoreStoreHourExceptionsMidDayClosures { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "time")] public System.DateTime ClosingHour { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool ClosingHourSpecified { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "time")] public System.DateTime OpeningHour { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool OpeningHourSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(StoreStoreHourExceptionsMidDayClosures)); } return serializer; } } 
}

}
