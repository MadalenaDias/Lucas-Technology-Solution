using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.Models
{
	public class WebSettings
	{
		[JsonProperty("theme_id")]
		public Guid ThemeId { get; set; } = Guid.Empty;
	}
}
