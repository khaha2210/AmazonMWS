using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class Loyalty : AmazonMessageChoice
	{
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] [System.ComponentModel.DesignerCategoryAttribute("code")] [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class LoyaltyReward { private CurrencyAmount balanceField; private static System.Xml.Serialization.XmlSerializer serializer;[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "nonNegativeInteger")] public string RewardCertificateID { get; set; }[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] public System.DateTime EarnedOnDate { get; set; }[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] public System.DateTime ExpirationDateDisplay { get; set; }[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] public System.DateTime ExpirationDateEnforced { get; set; } public LoyaltyReward() { this.balanceField = new CurrencyAmount(); }[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] public CurrencyAmount Balance { get { return this.balanceField; } set { this.balanceField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(LoyaltyReward)); } return serializer; } } }

}
