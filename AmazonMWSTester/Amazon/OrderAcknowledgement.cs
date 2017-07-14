using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class OrderAcknowledgement : AmazonMessageChoice
	{
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] [System.ComponentModel.DesignerCategoryAttribute("code")] [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class OrderAcknowledgementItem { private static System.Xml.Serialization.XmlSerializer serializer; public string AmazonOrderItemCode { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string MerchantOrderItemID { get; set; } public OrderAcknowledgementItemCancelReason CancelReason { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool CancelReasonSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(OrderAcknowledgementItem)); } return serializer; } } }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum OrderAcknowledgementStatusCode { Success, Failure, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum OrderAcknowledgementItemCancelReason { NoInventory, ShippingAddressUndeliverable, CustomerExchange, BuyerCanceled, GeneralAdjustment, CarrierCreditDecision, RiskAssessmentInformationNotValid, CarrierCoverageFailure, CustomerReturn, MerchandiseNotReceived, }

}
