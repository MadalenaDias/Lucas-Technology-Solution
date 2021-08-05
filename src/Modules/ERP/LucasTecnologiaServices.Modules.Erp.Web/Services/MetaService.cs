using LucasTecnologiaServices.Modules.Erp.Api.Models.FieldType;
using LucasTecnologiaServices.Modules.Erp.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.Services
{
	public class MetaService
	{
		public List<SelectOption> GetEntitiesAsSelectOptions()
		{
			var entities = new EntityManager().ReadEntities().Object;
			var result = new List<SelectOption>();
			foreach (var entity in entities)
			{
				result.Add(new SelectOption(entity.Id.ToString(), entity.Name));
			}

			return result.OrderBy(x => x.Value).ToList();
		}
	}
}
