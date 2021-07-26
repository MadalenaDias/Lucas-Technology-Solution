using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Api.Models.AutoMapper.Profiles
{
	public class DatabaseNNRelationRecordProfile : Profile
	{
		public DatabaseNNRelationRecordProfile()
		{
			CreateMap<DataRow, DatabaseNNRelationRecord>().ConvertUsing(source => DataRowToModelConvert(source));
		}

		private static DatabaseNNRelationRecord DataRowToModelConvert(DataRow inputObj)
		{

			if (inputObj == null)
				return null;

			var outputObj = new DatabaseNNRelationRecord();
			outputObj.OriginId = (Guid)inputObj["origin_id"];
			outputObj.TargetId = (Guid)inputObj["target_id"];


			return outputObj;
		}

	}
}
