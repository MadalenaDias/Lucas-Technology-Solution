using LucasTecnologiaServices.Modules.Erp.PluginsProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.PluginsProject.Hooks.Api
{
	[HookAttachment("comment")]
	public class Comment : IErpPreCreateRecordHook, IErpPostCreateRecordHook
	{

		public void OnPreCreateRecord(string entityName, EntityRecord record, List<ErrorModel> errors)
		{
			new CommentService().PreCreateApiHookLogic(entityName, record, errors);
		}

		public void OnPostCreateRecord(string entityName, EntityRecord record)
		{
			new CommentService().PostCreateApiHookLogic(entityName, record);
		}

	}
}
