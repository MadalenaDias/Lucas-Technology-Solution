using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.PluginsProject.Utils
{
	public static class UrlUtils
{
		public static string FullyQualifiedApplicationPath(HttpContext context)
		{
			//Return variable declaration
			var appPath = string.Empty;

			//Checking the current context content
			if (context != null)
			{
				//Formatting the fully qualified website url/name
				appPath = string.Format("{0}://{1}",
										context.Request.Scheme,
										context.Request.Host);
			}

			return appPath;
		}
	}
}
