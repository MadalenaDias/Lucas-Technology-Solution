using LucasTecnologiaServices.Modules.Erp.PluginsProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.PluginsProject.Jobs
{
	[Job("3D18B8D8-74B8-45B1-B121-9582F7B8A4F4", "Start tasks on start_date", true, JobPriority.Low)]
	public class StartTasksOnStartDate : ErpJob
	{
		public override void Execute(JobContext context)
		{
			using (SecurityContext.OpenSystemScope())
			{
				var tasks = new TaskService().GetTasksThatNeedStarting();
				foreach (var task in tasks)
				{
					var patchRecord = new EntityRecord();
					patchRecord["id"] = (Guid)task["id"];
					patchRecord["status_id"] = new Guid("20d73f63-3501-4565-a55e-2d291549a9bd");
					var updateResult = new RecordManager().UpdateRecord("task", patchRecord);
					if (!updateResult.Success)
					{
						throw new Exception(updateResult.Message);
					}
				}
			}
		}
	}
}
