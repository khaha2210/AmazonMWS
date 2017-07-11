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
	public partial class ProcessingReport : MessageChoice
	{

		private string documentTransactionIDField;

		private ProcessingReportStatusCode statusCodeField;

		private ProcessingReportProcessingSummary processingSummaryField;

		private ProcessingReportResult[] resultField;

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
		public ProcessingReportStatusCode StatusCode
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
		public ProcessingReportProcessingSummary ProcessingSummary
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
		public ProcessingReportResult[] Result
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
	public enum ProcessingReportStatusCode
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
	public partial class ProcessingReportProcessingSummary
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
	public partial class ProcessingReportResult
	{

		private string messageIDField;

		private ProcessingReportResultResultCode resultCodeField;

		private string resultMessageCodeField;

		private string resultDescriptionField;

		private ProcessingReportResultAdditionalInfo additionalInfoField;

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
		public ProcessingReportResultResultCode ResultCode
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
		public ProcessingReportResultAdditionalInfo AdditionalInfo
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
	public enum ProcessingReportResultResultCode
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
	public partial class ProcessingReportResultAdditionalInfo
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
