using LucasTecnologiaServices.Modules.Erp.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.Hooks
{
	[Hook("Record list page hooks")]
	public interface IRecordListPageHook
	{
		IActionResult OnGet(RecordListPageModel pageModel);
		IActionResult OnPost(RecordListPageModel pageModel);
	}
}
