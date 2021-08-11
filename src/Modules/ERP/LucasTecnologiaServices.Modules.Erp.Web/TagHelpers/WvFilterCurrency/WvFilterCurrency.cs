using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.TagHelpers.WvFilterCurrency
{
	[HtmlTargetElement("wv-filter-currency")]
	public class WvFilterCurrency : WvFilterBase
	{
		public override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
		{
			#region << Init >>
			var initSuccess = InitFilter(context, output);

			if (!initSuccess)
			{
				return Task.CompletedTask;
			}

			var inputGroupEl = new TagBuilder("div");
			inputGroupEl.AddCssClass("input-group");

			inputGroupEl.InnerHtml.AppendHtml(FilterTypeSelect);
			inputGroupEl.InnerHtml.AppendHtml(ValueNumberControl);
			inputGroupEl.InnerHtml.AppendHtml(AndDivider);
			inputGroupEl.InnerHtml.AppendHtml(Value2NumberControl);

			output.Content.AppendHtml(inputGroupEl);

			return Task.CompletedTask;
			#endregion

		}


	}
}
