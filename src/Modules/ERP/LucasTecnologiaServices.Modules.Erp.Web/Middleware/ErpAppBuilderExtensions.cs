using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.Middleware
{
	public static class AppBuilderExtensions
	{
		public static void UseErpMiddleware(this IApplicationBuilder app)
		{
			app.UseMiddleware<ErpMiddleware>();
		}
		public static void UseDebugLogMiddleware(this IApplicationBuilder app)
		{
			app.UseMiddleware<ErpDebugLogMiddleware>();
		}

		public static void UseErrorHandlingMiddleware(this IApplicationBuilder app)
		{
			app.UseMiddleware<ErpErrorHandlingMiddleware>();
		}
	}
}
