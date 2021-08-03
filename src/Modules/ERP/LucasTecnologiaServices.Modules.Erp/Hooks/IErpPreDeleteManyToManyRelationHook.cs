using LucasTecnologiaServices.Modules.Erp.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Hooks
{
	[Hook("Provide hook for point in code before delete NN relation record.")]
	public interface IErpPreDeleteManyToManyRelationHook
	{
		void OnPreDelete(string relationName, Guid? originId, Guid? targetId, List<ErrorModel> errors);
	}
}
