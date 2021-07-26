using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Api.Models.AutoMapper.Profiles
{
	internal class EntityRelationOptionsProfile : Profile
	{
		public EntityRelationOptionsProfile()
		{
			CreateMap<EntityRelationOptionsItem, DbEntityRelationOptions>();
			CreateMap<DbEntityRelationOptions, EntityRelationOptionsItem>();
		}
	}
}
