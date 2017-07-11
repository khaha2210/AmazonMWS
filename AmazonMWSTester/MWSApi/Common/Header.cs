using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AmazonMWSTester.Common
{
	[XmlRoot(ElementName = "Header")]
	public class Header
	{
		[XmlElement(ElementName = "DocumentVersion")]
		public string DocumentVersion { get; set; }
		[XmlElement(ElementName = "MerchantIdentifier")]
		public string MerchantIdentifier { get; set; }

		public Header() {

		}
	}
}
