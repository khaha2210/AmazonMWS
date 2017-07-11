using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AmazonMWSTester.MWSApi
{
	public class MwsUtilities
	{
		private static readonly Regex backSlashPtn = new Regex("\\\\");
		private static readonly Regex equalPtn = new Regex("=");
		private static readonly string escBackSlash = "\\\\";
		private static readonly string escEqual = "\\=";
		private static readonly string escForwardSlash = "\\/";
		private static readonly string escLParen = "\\(";
		private static readonly string escRParen = "\\)";
		private static readonly string escSemicolon = "\\;";
		private static readonly Regex forwardSlashPtn = new Regex("/");
		private static readonly Regex lParenPtn = new Regex("\\(");
		private static readonly Regex outerWhiteSpacesPtn = new Regex("\\A(\\s)+|(\\s)+\\z");
		private static readonly Regex rParenPtn = new Regex("\\)");
		private static readonly Regex semicolonPtn = new Regex(";");
		private static readonly Regex whiteSpacesPtn = new Regex("\\s+");
		private static readonly Encoding defaultEncoding = Encoding.UTF8;
		private static readonly Regex plusPtn = new Regex("\\+");
		private static readonly Regex exlamationPoint = new Regex("\\!");
		private static readonly Regex asteriskPtn = new Regex("\\*");
		private static readonly Regex pct7EPtn = new Regex("%7[e|E]");
		private static readonly Regex pctSingleQuotePtn = new Regex("'");
		private static readonly Regex pct2FPtn = new Regex("%2[f|F]");

		public static string SerializeXml<T>(T body) {
			var xmlSerializer = new XmlSerializer(typeof(T));

			using (var textWriter = new StringWriter())
			{
				xmlSerializer.Serialize(textWriter, body);
				return textWriter.ToString();
			}
		}

		public static T Deserialize<T>(string input) 
		{
			try
			{
				var deserializer = new XmlSerializer(typeof(T), "http://mws.amazonaws.com/doc/2009-01-01/");
				using (var stringReader = new StringReader(input)) 
				{
					return (T)deserializer.Deserialize(stringReader);
				}
			}
			catch (Exception ex) 
			{
				// TODO: log
				//throw new Exception($"Deserializing type: {typeof(T)} failed.", ex);
				return default(T);
			}
	
		}

		public static string HashXml(string body)
		{
			using (var md5 = MD5.Create())
			{
				var base64 = Convert.ToBase64String(md5.ComputeHash(Encoding.UTF8.GetBytes(body)));
				return base64;
			}
		}

		public static string Sign(string parameters, string key)
		{
			using (var hmacSHA256 = new HMACSHA256(Encoding.UTF8.GetBytes(key)))
			{
				var resultHash = hmacSHA256.ComputeHash(Encoding.UTF8.GetBytes(parameters.ToCharArray()));
				var base64Encode = Convert.ToBase64String(resultHash);
				return base64Encode;
			}
		}

		public static string GetSignedQuery(SortedDictionary<string, string> parameters, string address)
		{
			var stringBuilder = new StringBuilder();

			stringBuilder.Append("POST\n");
			stringBuilder.Append(address);
			stringBuilder.Append("\n/\n");

			foreach (var pair in parameters)
			{
				stringBuilder.Append(UrlEncode(pair.Key) + "=");
				stringBuilder.Append(UrlEncode(pair.Value) + "&");
			}

			stringBuilder.Remove(stringBuilder.Length - 1, 1);

			return stringBuilder.ToString();
		}

		public static string AddQueryString(string url, SortedDictionary<string, string> parameters)
		{
			if (parameters.Keys.Count == 0)
				return url;
			var stringBuilder = new StringBuilder(url + "?");
			foreach (var key in parameters.Keys)
			{
				stringBuilder.Append(key + "=" + UrlEncode(parameters[key]) + "&");
			}

			return stringBuilder.ToString();
		}


		public static string ByteArrayToString(byte[] ba)
		{
			string hex = BitConverter.ToString(ba);
			return hex.Replace("-", "");
		}

		public static string Base64Encode(string input)
		{
			var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(input);
			return Convert.ToBase64String(plainTextBytes);
		}

		public static string UrlEncode(string value)
		{
			try
			{
				value = Uri.EscapeDataString(value);
			}
			catch (NotSupportedException ex)
			{
				throw new SystemException("Unsupported encoding", (Exception)ex);
			}
			value = ReplaceAll(value, asteriskPtn, "%2A");
			value = ReplaceAll(value, pct7EPtn, "~");
			value = ReplaceAll(value, pctSingleQuotePtn, "%27");
			value = ReplaceAll(value, exlamationPoint, "%21");
			value = ReplaceAll(value, lParenPtn, "%28");
			value = ReplaceAll(value, rParenPtn, "%29");

			return value;
		}

		public static string ReplaceAll(string s, Regex p, string r)
		{
			int num = s != null ? s.Length : 0;
			if (num == 0)
				return s;
			Match match = p.Match(s);
			if (!match.Success)
				return s;
			StringBuilder stringBuilder = new StringBuilder(num + 12);
			int startIndex = 0;
			do
			{
				stringBuilder.Append(s, startIndex, match.Index - startIndex);
				stringBuilder.Append(r);
				startIndex = match.Index + match.Length;
			}
			while ((match = match.NextMatch()).Success);
			if (startIndex < num)
				stringBuilder.Append(s, startIndex, num - startIndex);
			return stringBuilder.ToString();
		}
	}

	public class SortDecendingBytes : IComparer<string>
	{
		public int Compare(string key1, string key2)
		{
			return string.Compare(key1, key2, StringComparison.Ordinal);
		}
	}
}
