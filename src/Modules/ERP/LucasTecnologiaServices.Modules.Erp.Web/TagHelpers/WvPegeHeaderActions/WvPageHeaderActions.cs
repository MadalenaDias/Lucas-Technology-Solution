using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.TagHelpers.WvPegeHeaderActions
{

	[HtmlTargetElement("wv-page-header-actions", ParentTag = "wv-page-header")]
	public class WvPageHeaderActions : TagHelper
	{
		public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
		{
			var content = await output.GetChildContentAsync();
			output.Content.AppendHtml(content);
			//return Task.CompletedTask;
		}

	}
}
