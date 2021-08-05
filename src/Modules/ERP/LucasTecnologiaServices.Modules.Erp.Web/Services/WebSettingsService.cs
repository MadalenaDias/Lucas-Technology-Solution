using LucasTecnologiaServices.Modules.Erp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.Services
{
	public class WebSettingsService : BaseService
	{
		WebSettings coresettings = new WebSettings();

		public WebSettings Get()
		{
			return coresettings;
		}
	}
}
