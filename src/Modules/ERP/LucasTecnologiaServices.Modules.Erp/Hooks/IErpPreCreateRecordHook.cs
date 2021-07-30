using LucasTecnologiaServices.Modules.Erp.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Hooks
{
	[Hook("Provide hook for point in code before entity record create.")]
	public interface IErpPreCreateRecordHook
	{
		void OnPreCreateRecord(string entityName, EntityRecord record, List<ErrorModel> errors);
	}
}
