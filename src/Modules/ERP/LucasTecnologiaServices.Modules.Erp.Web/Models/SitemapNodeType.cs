using LucasTecnologiaServices.Modules.Erp.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.Models
{
	public enum SitemapNodeType
	{
		[SelectOption(Label = "entity list")]
		EntityList = 1,
		[SelectOption(Label = "application page")]
		ApplicationPage = 2,
		[SelectOption(Label = "url")]
		Url = 3,
	}
}
