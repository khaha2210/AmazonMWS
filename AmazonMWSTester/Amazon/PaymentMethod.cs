using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class PaymentMethod
	{
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum PaymentTypes {[System.Xml.Serialization.XmlEnumAttribute("Bank Account")] BankAccount, [System.Xml.Serialization.XmlEnumAttribute("Credit Card")] CreditCard, [System.Xml.Serialization.XmlEnumAttribute("Credit Line")] CreditLine, [System.Xml.Serialization.XmlEnumAttribute("Debit Card")] DebitCard, [System.Xml.Serialization.XmlEnumAttribute("Invoice Account")] InvoiceAccount, [System.Xml.Serialization.XmlEnumAttribute("Store Card")] StoreCard, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum Issuers { Visa, MasterCard, Discover, Amex, JCB, Switch, DinersClub, Other, }

}
