using LucasTecnologiaServices.Modules.Erp.Api.Models.FieldType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Api.Models.AutoMapper.Profiles
{
	internal class FieldPermissionsProfile : Profile
	{
		public FieldPermissionsProfile()
		{
			CreateMap<FieldPermissions, DbFieldPermissions>();
			CreateMap<DbFieldPermissions, FieldPermissions>();
		}
	}
}
