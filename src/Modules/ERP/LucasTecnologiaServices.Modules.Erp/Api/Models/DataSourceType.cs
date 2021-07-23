using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Api.Models
{
	public enum DataSourceType
	{
		[SelectOption(Label = "database")]
		DATABASE = 0,
		[SelectOption(Label = "code")]
		CODE = 1
	}
}
