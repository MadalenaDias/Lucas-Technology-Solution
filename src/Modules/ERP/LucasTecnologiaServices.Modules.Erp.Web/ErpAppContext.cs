using LucasTecnologiaServices.Modules.Erp.Web.Models;
using LucasTecnologiaServices.Modules.Erp.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web
{
	public class ErpAppContext
	{
		public static ErpAppContext Current { get; private set; }

		public IServiceProvider ServiceProvider { get; private set; }

		//public string StyleFrameworkHash { get; private set; } = "";

		//public string StyleFrameworkContent { get; private set; } = "";

		public string StylesHash { get; private set; } = "";

		public string StylesContent { get; private set; } = "";

		public Theme Theme { get; private set; }

		public WebSettings CoreSettings { get; private set; }


		public List<ScriptTagInclude> ScriptIncludes { get; private set; } = new List<ScriptTagInclude>();

		//public List<LinkTagInclude> LinkIncludes { get; private set; } = new List<LinkTagInclude>();

		public Cache Cache { get; private set; } = new Cache();

		//Constructors
		internal static void Init(IServiceProvider serviceProvider)
		{
			Current = new ErpAppContext(serviceProvider);
		}

		private ErpAppContext(IServiceProvider serviceProvider)
		{
			ServiceProvider = serviceProvider;
			InitCoreSettings();
			InitTheme();
		}



		//methods Init
		private void InitCoreSettings()
		{
			CoreSettings = new WebSettingsService().Get();
		}

		private void InitTheme()
		{
			var themeService = new ThemeService();
			Theme = themeService.Get();
			StylesContent = themeService.GenerateStylesContent();
			StylesHash = GetStringHash(StylesContent, new SHA256CryptoServiceProvider());
			//StyleFrameworkContent = themeService.GenerateStyleFrameworkContent();
			//StyleFrameworkHash = GetStringHash(StyleFrameworkContent, new SHA256CryptoServiceProvider());
		}

		public static string GetStringHash(string content, HashAlgorithm algorithm)
		{

			var hashedBytes = algorithm.ComputeHash(Encoding.UTF8.GetBytes(content));

			return Convert.ToBase64String(hashedBytes);
		}

		//public static void UpdateStyleFrameworkContent(string content)
		//{
		//	Current.StyleFrameworkContent = content;
		//	Current.StyleFrameworkHash = GetStringHash(content, new SHA256CryptoServiceProvider());
		//}

		public static void UpdateStylesFileContent(string content)
		{
			Current.StylesContent = content;
			Current.StylesHash = GetStringHash(content, new SHA256CryptoServiceProvider());
		}


	}
}
