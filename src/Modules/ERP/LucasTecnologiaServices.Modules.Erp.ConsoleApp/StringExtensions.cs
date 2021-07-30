using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.ConsoleApp
{
	public static class StringExtensions
	{
		//utility method to get configuration file path
		public static string ToApplicationPath(this string fileName)
		{
			var exePath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase);
			Regex appPathMatcher = new Regex(@"(?<!fil)[A-Za-z]:\\+[\S\s]*?(?=\\+bin)");
			var appRoot = appPathMatcher.Match(exePath).Value;
			return Path.Combine(appRoot, fileName);
		}
	}
}
