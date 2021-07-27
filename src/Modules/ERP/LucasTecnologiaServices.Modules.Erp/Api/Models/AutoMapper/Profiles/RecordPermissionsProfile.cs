using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Api.Models.AutoMapper.Profiles
{
	internal class RecordPermissionsProfile : Profile
	{
		public RecordPermissionsProfile()
		{
			CreateMap<RecordPermissions, DbRecordPermissions>();
			CreateMap<DbRecordPermissions, RecordPermissions>();
		}
	}
}
