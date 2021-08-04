using LucasTecnologiaServices.Modules.Erp.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.Models
{
	public enum PageType
	{
		[SelectOption(Label = "home")]
		Home = 0,
		[SelectOption(Label = "site")]
		Site = 1,
		[SelectOption(Label = "application")]
		Application = 2,
		[SelectOption(Label = "record list")]
		RecordList = 3,
		[SelectOption(Label = "record create")]
		RecordCreate = 4,
		[SelectOption(Label = "record details")]
		RecordDetails = 5,
		[SelectOption(Label = "record manage")]
		RecordManage = 6
	}
}
