using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class ProcessingReport : AmazonMessageChoice
	{
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ProcessingReportProcessingSummary { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")] public string MessagesProcessed { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")] public string MessagesSuccessful { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")] public string MessagesWithError { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")] public string MessagesWithWarning { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ProcessingReportProcessingSummary)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ProcessingReportResult { private ProcessingReportResultAdditionalInfo additionalInfoField; private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")] public string MessageID { get; set; } public ProcessingReportResultResultCode ResultCode { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")] public string ResultMessageCode { get; set; } public string ResultDescription { get; set; } public ProcessingReportResult() { this.additionalInfoField = new ProcessingReportResultAdditionalInfo(); } public ProcessingReportResultAdditionalInfo AdditionalInfo { get { return this.additionalInfoField; } set { this.additionalInfoField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ProcessingReportResult)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum ProcessingReportStatusCode { Complete, Processing, Rejected, }

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ProcessingReportResultAdditionalInfo { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string SKU { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string FulfillmentCenterID { get; set; } public string AmazonOrderID { get; set; } public string AmazonOrderItemCode { get; set; } public string Marketplace { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ProcessingReportResultAdditionalInfo)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum ProcessingReportResultResultCode { Error, Warning, }

}
