using System;
using System.IO;
using System.Reflection;

namespace KStore.Utility
{
	public class DirectoryHelper
	{
		public DirectoryHelper()
		{
		}

		public string CurrentAssemblyDirectory()
		{
			var codeBase = Assembly.GetExecutingAssembly().CodeBase;
			var uri = new UriBuilder(codeBase);
			var path = Uri.UnescapeDataString(uri.Path);
			return Path.GetDirectoryName(path);
		}
	}
}
