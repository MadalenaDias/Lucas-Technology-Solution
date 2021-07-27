using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Api.Models.AutoMapper.Profiles
{
	public class ErrorModelProfile : Profile
	{
		public ErrorModelProfile()
		{
			CreateMap<ErrorModel, ValidationError>().ConvertUsing(source => Convert(source));
		}

		private static ValidationError Convert(ErrorModel err)
		{
			if (err == null)
				return null;

			return new ValidationError(err.Key ?? "id", err.Message);
		}

	}
}
