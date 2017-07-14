using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class FulfillmentCenter : AmazonMessageChoice
	{
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class FulfillmentCenterOperatingHours { private OperatingHoursBase mondayField; private OperatingHoursBase tuesdayField; private OperatingHoursBase wednesdayField; private OperatingHoursBase thursdayField; private OperatingHoursBase fridayField; private OperatingHoursBase saturdayField; private OperatingHoursBase sundayField; private static System.Xml.Serialization.XmlSerializer serializer; public FulfillmentCenterOperatingHours() { this.sundayField = new OperatingHoursBase(); this.saturdayField = new OperatingHoursBase(); this.fridayField = new OperatingHoursBase(); this.thursdayField = new OperatingHoursBase(); this.wednesdayField = new OperatingHoursBase(); this.tuesdayField = new OperatingHoursBase(); this.mondayField = new OperatingHoursBase(); } public OperatingHoursBase Monday { get { return this.mondayField; } set { this.mondayField = value; } } public OperatingHoursBase Tuesday { get { return this.tuesdayField; } set { this.tuesdayField = value; } } public OperatingHoursBase Wednesday { get { return this.wednesdayField; } set { this.wednesdayField = value; } } public OperatingHoursBase Thursday { get { return this.thursdayField; } set { this.thursdayField = value; } } public OperatingHoursBase Friday { get { return this.fridayField; } set { this.fridayField = value; } } public OperatingHoursBase Saturday { get { return this.saturdayField; } set { this.saturdayField = value; } } public OperatingHoursBase Sunday { get { return this.sundayField; } set { this.sundayField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(FulfillmentCenterOperatingHours)); } return serializer; } } 
}

}
