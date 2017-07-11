using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AmazonMWSTester.MWSApi.Results
{
	[XmlRoot(ElementName = "ResponseMetadata")]
	public class ResponseMetadata
	{
		[XmlElement(ElementName = "RequestId")]
		public string RequestId { get; set; }
	}
}
