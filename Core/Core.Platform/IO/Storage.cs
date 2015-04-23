﻿//
// Storage.cs
//
// Author:
//       Tobias Schulz <tobiasschulz.code@outlook.de>
//
// Copyright (c) 2015 Tobias Schulz
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
using System;
using System.IO;

namespace Core.Common
{
	public static class Storage
	{
		public static string DefaultLogFile { get { return getLocation (name: "output", extension: "log"); } }

		public static string DefaultConfigFile { get { return getLocation (name: "config", extension: "json"); } }

		private static string getLocation (string name, string extension)
		{
			string appData = Environment.GetFolderPath (Environment.SpecialFolder.ApplicationData);
			string appName = Path.GetFileNameWithoutExtension (System.Reflection.Assembly.GetEntryAssembly ().Location);
			string fileName = name + "." + extension;
			
			string fullPath = Path.Combine (appData, appName, fileName);

			Console.WriteLine (fullPath);
			return fullPath;
		}
	}
}
