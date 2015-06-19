﻿using System;
using Core.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Core.Common
{
	public static class StringHelper
	{
		public static string Base64Encode (string str)
		{
			return Convert.ToBase64String (System.Text.Encoding.UTF8.GetBytes (str));
		}

		public static string Base64Decode (string str)
		{
			byte[] buffer = Convert.FromBase64String (str);
			return System.Text.Encoding.UTF8.GetString (buffer, 0, buffer.Length);
		}

		public static string FormatSortable (DateTime date)
		{
			return date.ToString ("yyyy-MM-ddTHH:mm:ss.fff");
		}

		public static string UppercaseFirst (this string str)
		{
			if (string.IsNullOrEmpty (str)) {
				return string.Empty;
			}
			char[] a = str.ToCharArray ();
			a [0] = char.ToUpper (a [0]);
			return new string (a);
		}

		public static string ToJson (this object obj, bool inline = false)
		{
			string result = PortableConfigHelper.WriteConfig (stuff: obj, inline: inline);
			if (inline) {
				result = result.TrimEnd ('\r', '\n');
			}
			return result;
		}

		public static string Between (this string source, string left, string right)
		{
			return Regex.Match (source, string.Format ("{0}(.*){1}", left, right)).Groups [1].Value;
		}
	}
}

