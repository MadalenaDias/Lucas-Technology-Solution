using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Api.Models.AutoMapper.Profiles
{
	internal class EntityRelationProfile : Profile
	{
		public EntityRelationProfile()
		{
			CreateMap<EntityRelation, DbEntityRelation>();
			CreateMap<DbEntityRelation, EntityRelation>();
		}
	}
}
