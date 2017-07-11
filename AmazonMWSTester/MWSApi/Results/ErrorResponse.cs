using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AmazonMWSTester.MWSApi.Results
{

	/// <remarks/>
	[XmlRoot(ElementName = "ErrorResponse", Namespace = "http://mws.amazonaws.com/doc/2009-01-01/", IsNullable = true)]
	public partial class ErrorResponse
	{

		private ErrorResponseError errorField;

		private string requestIDField;

		/// <remarks/>
		public ErrorResponseError Error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}

		/// <remarks/>
		public string RequestID
		{
			get
			{
				return this.requestIDField;
			}
			set
			{
				this.requestIDField = value;
			}
		}
	}

	/// <remarks/>
	[SerializableAttribute()]
	public partial class ErrorResponseError
	{

		private string typeField;

		private string codeField;

		private string messageField;

		private object detailField;

		/// <remarks/>
		public string Type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}

		/// <remarks/>
		public string Code
		{
			get
			{
				return this.codeField;
			}
			set
			{
				this.codeField = value;
			}
		}

		/// <remarks/>
		public string Message
		{
			get
			{
				return this.messageField;
			}
			set
			{
				this.messageField = value;
			}
		}

		/// <remarks/>
		public object Detail
		{
			get
			{
				return this.detailField;
			}
			set
			{
				this.detailField = value;
			}
		}
	}


}



