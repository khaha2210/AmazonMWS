using AmazonMWSTester.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.MWSApi.MessageTypes
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public partial class ProcessingReport2 : MessageChoice2
	{

		private string documentTransactionIDField;

		private ProcessingReportStatusCode2 statusCodeField;

		private ProcessingReportProcessingSummary2 processingSummaryField;

		private ProcessingReportResult2[] resultField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
		public string DocumentTransactionID
		{
			get
			{
				return this.documentTransactionIDField;
			}
			set
			{
				this.documentTransactionIDField = value;
			}
		}

		/// <remarks/>
		public ProcessingReportStatusCode2 StatusCode
		{
			get
			{
				return this.statusCodeField;
			}
			set
			{
				this.statusCodeField = value;
			}
		}

		/// <remarks/>
		public ProcessingReportProcessingSummary2 ProcessingSummary
		{
			get
			{
				return this.processingSummaryField;
			}
			set
			{
				this.processingSummaryField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Result")]
		public ProcessingReportResult2[] Result
		{
			get
			{
				return this.resultField;
			}
			set
			{
				this.resultField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum ProcessingReportStatusCode2
	{

		/// <remarks/>
		Complete,

		/// <remarks/>
		Processing,

		/// <remarks/>
		Rejected,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class ProcessingReportProcessingSummary2
	{

		private string messagesProcessedField;

		private string messagesSuccessfulField;

		private string messagesWithErrorField;

		private string messagesWithWarningField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
		public string MessagesProcessed
		{
			get
			{
				return this.messagesProcessedField;
			}
			set
			{
				this.messagesProcessedField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
		public string MessagesSuccessful
		{
			get
			{
				return this.messagesSuccessfulField;
			}
			set
			{
				this.messagesSuccessfulField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
		public string MessagesWithError
		{
			get
			{
				return this.messagesWithErrorField;
			}
			set
			{
				this.messagesWithErrorField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
		public string MessagesWithWarning
		{
			get
			{
				return this.messagesWithWarningField;
			}
			set
			{
				this.messagesWithWarningField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class ProcessingReportResult2
	{

		private string messageIDField;
		
		private ProcessingReportResultResultCode2 resultCodeField;

		private string resultMessageCodeField;

		private string resultDescriptionField;

		private ProcessingReportResultAdditionalInfo2 additionalInfoField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
		public string MessageID
		{
			get
			{
				return this.messageIDField;
			}
			set
			{
				this.messageIDField = value;
			}
		}

		/// <remarks/>
		public ProcessingReportResultResultCode2 ResultCode
		{
			get
			{
				return this.resultCodeField;
			}
			set
			{
				this.resultCodeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
		public string ResultMessageCode
		{
			get
			{
				return this.resultMessageCodeField;
			}
			set
			{
				this.resultMessageCodeField = value;
			}
		}

		/// <remarks/>
		public string ResultDescription
		{
			get
			{
				return this.resultDescriptionField;
			}
			set
			{
				this.resultDescriptionField = value;
			}
		}

		/// <remarks/>
		public ProcessingReportResultAdditionalInfo2 AdditionalInfo
		{
			get
			{
				return this.additionalInfoField;
			}
			set
			{
				this.additionalInfoField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum ProcessingReportResultResultCode2
	{

		/// <remarks/>
		Error,

		/// <remarks/>
		Warning,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class ProcessingReportResultAdditionalInfo2
	{

		private string sKUField;

		private string fulfillmentCenterIDField;

		private string amazonOrderIDField;

		private string amazonOrderItemCodeField;

		private string marketplaceField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
		public string SKU
		{
			get
			{
				return this.sKUField;
			}
			set
			{
				this.sKUField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
		public string FulfillmentCenterID
		{
			get
			{
				return this.fulfillmentCenterIDField;
			}
			set
			{
				this.fulfillmentCenterIDField = value;
			}
		}

		/// <remarks/>
		public string AmazonOrderID
		{
			get
			{
				return this.amazonOrderIDField;
			}
			set
			{
				this.amazonOrderIDField = value;
			}
		}

		/// <remarks/>
		public string AmazonOrderItemCode
		{
			get
			{
				return this.amazonOrderItemCodeField;
			}
			set
			{
				this.amazonOrderItemCodeField = value;
			}
		}

		/// <remarks/>
		public string Marketplace
		{
			get
			{
				return this.marketplaceField;
			}
			set
			{
				this.marketplaceField = value;
			}
		}
	}
}
