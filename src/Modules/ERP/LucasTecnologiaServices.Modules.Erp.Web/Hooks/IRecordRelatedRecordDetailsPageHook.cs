using LucasTecnologiaServices.Modules.Erp.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.Hooks
{
	[Hook("Related record details page hooks")]
	public interface IRecordRelatedRecordDetailsPageHook
	{
		IActionResult OnPost(RecordRelatedRecordDetailsPageModel pageModel);
	}
}
