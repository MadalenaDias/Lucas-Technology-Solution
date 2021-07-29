using LucasTecnologiaServices.Modules.Erp.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Hooks
{
	[Hook("Provide hook for point in code after entity record is created.")]
	public interface IErpPostCreateRecordHook
	{
		void OnPostCreateRecord(string entityName, EntityRecord record);
	}
}
