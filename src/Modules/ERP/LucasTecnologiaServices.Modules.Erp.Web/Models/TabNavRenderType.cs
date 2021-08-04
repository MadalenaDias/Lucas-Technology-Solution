using LucasTecnologiaServices.Modules.Erp.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.Models
{
	public enum TabNavRenderType
	{
		[SelectOption(Label = "Tabs")]
		TABS = 1,
		[SelectOption(Label = "Pills")]
		PILLS = 2
	}
}
