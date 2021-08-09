using LucasTecnologiaServices.Modules.Erp.Api.Models;
using LucasTecnologiaServices.Modules.Erp.Api;
using LucasTecnologiaServices.Modules.Erp.Database;
using LucasTecnologiaServices.Modules.Erp.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.Middleware
{
	public class ErpMiddleware
	{
		RequestDelegate next;

		public ErpMiddleware(RequestDelegate next)
		{
			this.next = next;
		}

		public async Task Invoke(HttpContext context)
		{
			var syncIOFeature = context.Features.Get<IHttpBodyControlFeature>();
			if (syncIOFeature != null)
				syncIOFeature.AllowSynchronousIO = true;

			IDisposable dbCtx = DbContext.CreateContext(ErpSettings.ConnectionString);
			IDisposable secCtx = null;

			ErpUser user = AuthService.GetUser(context.User);
			if (user != null)
			{
				secCtx = SecurityContext.OpenScope(user);
			}
			else
			{
				if (context.User.Identity.IsAuthenticated)
				{
					await context.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
				}
			}

			await next(context);
			await Task.Run(() =>
			{
				if (dbCtx != null)
					dbCtx.Dispose();
				if (secCtx != null)
					secCtx.Dispose();
			});
		}
	}
}
