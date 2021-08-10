using LucasTecnologiaServices.Modules.Erp.Api.Models;
using LucasTecnologiaServices.Modules.Erp.Exceptions;
using LucasTecnologiaServices.Modules.Erp.Hooks;
using LucasTecnologiaServices.Modules.Erp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.Hooks.TestHooks
{
	[HookAttachment()]
	public class TestRecordManagePageHook : IRecordManagePageHook
	{
		public IActionResult OnPostManageRecord(EntityRecord record, Entity entity, RecordManagePageModel pageModel)
		{
			pageModel.TempData.Put("ScreenMessage", new ScreenMessage() { Message = "Record is updated successfully" });
			return null;
		}

		public IActionResult OnPreManageRecord(EntityRecord record, Entity entity, RecordManagePageModel pageModel, List<ValidationError> validationErrors)
		{
			if (record.Properties.ContainsKey("text"))
			{
				if (record["text"] as string == "123")
					validationErrors.Add(new ValidationError("text", "123 value is not permitted"));
			}
			return null;
		}
	}
}
