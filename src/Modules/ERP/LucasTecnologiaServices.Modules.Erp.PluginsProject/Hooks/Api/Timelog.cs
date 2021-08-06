using LucasTecnologiaServices.Modules.Erp.PluginsProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.PluginsProject.Hooks.Api
{
	[HookAttachment("timelog")]
	public class Timelog : IErpPreCreateRecordHook, IErpPreDeleteRecordHook
	{

		public void OnPreCreateRecord(string entityName, EntityRecord record, List<ErrorModel> errors)
		{
			new TimeLogService().PreCreateApiHookLogic(entityName, record, errors);
		}

		public void OnPreDeleteRecord(string entityName, EntityRecord record, List<ErrorModel> errors)
		{
			new TimeLogService().PreDeleteApiHookLogic(entityName, record, errors);
		}

	}
}
