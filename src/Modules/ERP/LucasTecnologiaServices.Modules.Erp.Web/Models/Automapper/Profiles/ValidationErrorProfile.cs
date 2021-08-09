using LucasTecnologiaServices.Modules.Erp.Api.Models;
using LucasTecnologiaServices.Modules.Erp.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.Models.Automapper.Profiles
{
	public class ValidationErrorProfile : Profile
	{
		public ValidationErrorProfile()
		{
			CreateMap<ErrorModel, ValidationError>().ConvertUsing(source => JTokenToAppConvert(source));
		}

		private static ValidationError JTokenToAppConvert(ErrorModel data)
		{
			if (data == null)
				return null;

			return new ValidationError(data.Key, data.Message);
		}
	}
}
