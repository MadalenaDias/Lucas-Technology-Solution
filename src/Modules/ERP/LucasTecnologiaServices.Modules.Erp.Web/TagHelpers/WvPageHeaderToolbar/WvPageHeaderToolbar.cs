using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.TagHelpers.WvPageHeaderToolbar
{
	[HtmlTargetElement("wv-page-header-toolbar", ParentTag = "wv-page-header")]
	public class WvPageHeaderToolbar : TagHelper
	{
		public override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
		{
			return Task.CompletedTask;
		}

	}
}
