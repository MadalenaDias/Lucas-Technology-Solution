using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web
{
	internal class WebConfigurationOptions : IPostConfigureOptions<StaticFileOptions>
	{
		private readonly IWebHostEnvironment env;

		public WebConfigurationOptions(IWebHostEnvironment environment)
		{
			env = environment;
		}

		public void PostConfigure(string name, StaticFileOptions options)
		{
			options.ContentTypeProvider = options.ContentTypeProvider ?? new FileExtensionContentTypeProvider();

			if (options.FileProvider == null && env.WebRootFileProvider == null)
				throw new InvalidOperationException("Missing FileProvider.");

			options.FileProvider = options.FileProvider ?? env.WebRootFileProvider;

			var filesProvider = new ManifestEmbeddedFileProvider(GetType().Assembly, "wwwroot");
			options.FileProvider = new CompositeFileProvider(options.FileProvider, filesProvider);
		}
	}
}
