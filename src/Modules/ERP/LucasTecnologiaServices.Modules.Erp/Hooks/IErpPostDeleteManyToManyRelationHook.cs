using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Hooks
{
	[Hook("Provide hook for point in code after NN relation record is removed.")]
	public interface IErpPostDeleteManyToManyRelationHook
	{
		void OnPostDelete(string relationName, Guid? originId, Guid? targetId);
	}
}
