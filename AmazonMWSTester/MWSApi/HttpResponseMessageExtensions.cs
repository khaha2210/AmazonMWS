using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using AmazonMWSTester.MWSApi;

namespace AmazonMWSTester.MWSApi
{
	public static class HttpResponseMessageExtensions
	{
		public static async Task<T> GetResult<T>(this string message) 
		{
			//var messageText = await message.Content.ReadAsStringAsync();
			return MwsUtilities.Deserialize<T>(message);
		}

	}
}
