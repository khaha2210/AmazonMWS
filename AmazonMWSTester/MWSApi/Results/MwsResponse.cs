using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.MWSApi.Results
{
	public class MwsResponse<T>
	{
		public ErrorResponse Error { get; set; } 
		public string ExceptionMessage { get; set; } 
		public T Result { get; set; }
	}
}
