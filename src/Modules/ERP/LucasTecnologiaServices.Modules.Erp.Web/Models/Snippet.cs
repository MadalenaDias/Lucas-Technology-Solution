using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.Models
{
	internal class Snippet
	{
		public string Name { get; set; }

		public Assembly Assembly { get; set; }

		public string GetText()
		{
			Stream resource = Assembly.GetManifestResourceStream(Name);
			StreamReader reader = new StreamReader(resource);
			return reader.ReadToEnd();
		}

	}
}
