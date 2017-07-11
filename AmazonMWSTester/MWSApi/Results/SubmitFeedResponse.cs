using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AmazonMWSTester.MWSApi.Results
{
	[XmlRoot(ElementName = "SubmitFeedResponse")]
	public class SubmitFeedResponse 
	{
		[XmlElement(ElementName = "SubmitFeedResult")]
		public SubmitFeedResult SubmitFeedResult { get; set; }

		[XmlElement(ElementName = "ResponseMetadata")]
		public ResponseMetadata ResponseMetadata { get; set; }
	}


	[XmlRoot(ElementName = "SubmitFeedResult")]
	public class SubmitFeedResult
	{
		[XmlElement(ElementName = "FeedSubmissionInfo")]
		public FeedSubmissionInfo FeedSubmissionInfo { get; set; }

	}

	[XmlRoot(ElementName = "FeedSubmissionInfo")]
	public class FeedSubmissionInfo
	{
		[XmlElement(ElementName = "FeedSubmissionId")]
		public string FeedSubmissionId { get; set; }

		[XmlElement(ElementName = "FeedType")]
		public string FeedType { get; set; }

		[XmlElement(ElementName = "SubmittedDate")]
		public DateTime SubmittedDate { get; set; }

		[XmlElement(ElementName = "FeedProcessingStatus")]
		public string FeedProcessingStatus { get; set; }
	}
}
