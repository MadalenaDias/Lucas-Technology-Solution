using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.Utils
{
	public static class WvTaghelperExtension
	{
		public static IHtmlContent WvJsonRaw(this IHtmlHelper helper, string input)
		{

			return new HtmlString(helper.Raw(input).ToString().Replace("</script>", "</s\\cript>"));
		}
	}
}
