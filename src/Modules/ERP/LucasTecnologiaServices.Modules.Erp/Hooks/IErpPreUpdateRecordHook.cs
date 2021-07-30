using LucasTecnologiaServices.Modules.Erp.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Hooks
{
	[Hook("Provide hook for point in code before entity record update.")]
	public interface IErpPreUpdateRecordHook
	{
		void OnPreUpdateRecord(string entityName, EntityRecord record, List<ErrorModel> errors);
	}
}
