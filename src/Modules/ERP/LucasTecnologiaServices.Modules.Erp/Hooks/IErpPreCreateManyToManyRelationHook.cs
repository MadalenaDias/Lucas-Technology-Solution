using LucasTecnologiaServices.Modules.Erp.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Hooks
{
	[Hook("Provide hook for point in code before NN relation between 2 entity record is created.")]
	public interface IErpPreCreateManyToManyRelationHook
	{
		void OnPreCreate(string relationName, Guid originId, Guid targetId, List<ErrorModel> errors);
	}
}
