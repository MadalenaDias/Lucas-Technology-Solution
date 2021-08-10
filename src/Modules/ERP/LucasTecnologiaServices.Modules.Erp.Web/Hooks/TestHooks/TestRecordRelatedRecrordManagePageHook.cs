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
	public class TestRecordRelatedRecrordManagePageHook : IRecordRelatedRecordManagePageHook
	{
		public IActionResult OnPostManageRecord(EntityRecord record, Entity entity, RecordRelatedRecordManagePageModel pageModel)
		{
			pageModel.TempData.Put("ScreenMessage", new ScreenMessage() { Message = "Record is updated successfully" });
			return null;
		}

		public IActionResult OnPreManageRecord(EntityRecord record, Entity entity, RecordRelatedRecordManagePageModel pageModel, List<ValidationError> validationErrors)
		{
			if (record.Properties.ContainsKey("name"))
			{
				if (record["name"] as string == "123")
					validationErrors.Add(new ValidationError("name", "123 as item name is not permitted"));
			}
			return null;
		}
	}
}
