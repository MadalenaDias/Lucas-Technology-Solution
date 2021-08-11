using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.TagHelpers.WvFilterMultSelect
{
	[HtmlTargetElement("wv-filter-multiselect")]
	public class WvFilterMultiSelect : WvFilterBase
	{
		public override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
		{
			if (!isVisible)
			{
				output.SuppressOutput();
				return Task.CompletedTask;
			}
			#region << Init >>
			var initSuccess = InitFilter(context, output);

			if (!initSuccess)
			{
				return Task.CompletedTask;
			}

			var inputGroupEl = new TagBuilder("div");
			inputGroupEl.AddCssClass("input-group");

			inputGroupEl.InnerHtml.AppendHtml(FilterTypeSelect);
			inputGroupEl.InnerHtml.AppendHtml(ValueTextControl);


			output.Content.AppendHtml(inputGroupEl);

			return Task.CompletedTask;
			#endregion
		}


	}
}
