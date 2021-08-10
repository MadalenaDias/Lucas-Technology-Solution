using LucasTecnologiaServices.Modules.Erp.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.Hooks
{
	[Hook("Record related record list page hooks")]
	public interface IRecordRelatedRecordsListPageHook
	{
		IActionResult OnGet(RecordRelatedRecordsListPageModel pageModel);
		IActionResult OnPost(RecordRelatedRecordsListPageModel pageModel);
	}
}
