using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Hooks
{
	[Hook("Provide hook for point in code after relation NN record is created.")]
	public interface IErpPostCreateManyToManyRelationHook
	{
		void OnPostCreate(string relationName, Guid originId, Guid targetId);
	}
}
