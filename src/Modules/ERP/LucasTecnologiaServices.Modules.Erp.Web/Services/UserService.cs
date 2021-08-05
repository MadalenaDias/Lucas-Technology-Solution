using LucasTecnologiaServices.Modules.Erp.Api.Models;
using LucasTecnologiaServices.Modules.Erp.Eql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.Services
{
	public class UserService : BaseService
	{

		public EntityRecordList GetAll()
		{
			var projectRecord = new EntityRecord();
			var eqlCommand = "SELECT * from user";
			var eqlResult = new EqlCommand(eqlCommand).Execute();

			return eqlResult;
		}

		public EntityRecord Get(Guid userId)
		{
			var projectRecord = new EntityRecord();
			var eqlCommand = "SELECT * from user WHERE id = @userId";
			var eqlParams = new List<EqlParameter>() { new EqlParameter("userId", userId) };
			var eqlResult = new EqlCommand(eqlCommand, eqlParams).Execute();
			if (!eqlResult.Any())
			{
				return null;
			}
			return eqlResult[0];
		}

	}
}
