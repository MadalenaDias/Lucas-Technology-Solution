using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.TagHelpers.WvFilterCheckbox
{
	[HtmlTargetElement("wv-filter-checkbox")]
	public class WvFilterCheckbox : WvFilterBase
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

			#region << ValueTextControl >>
			{
				var valueSelect = new TagBuilder("select");
				valueSelect.AddCssClass("form-control value");

				var undefinedOption = new TagBuilder("option");
				undefinedOption.InnerHtml.Append("");
				if (Value == null)
				{
					undefinedOption.Attributes.Add("selected", null);
				}
				valueSelect.InnerHtml.AppendHtml(undefinedOption);

				var trueOption = new TagBuilder("option");
				trueOption.InnerHtml.Append("true");
if (Value != null && Value)
{
					trueOption.Attributes.Add("selected", null);
				}
				valueSelect.InnerHtml.AppendHtml(trueOption);

				var falseOption = new TagBuilder("option");
				falseOption.InnerHtml.Append("false");
if (Value != null && !Value)
{
					falseOption.Attributes.Add("selected", null);
				}
				valueSelect.InnerHtml.AppendHtml(falseOption);

				valueSelect.Attributes.Add("name", UrlQueryOfValue);
				inputGroupEl.InnerHtml.AppendHtml(valueSelect);
			}
			#endregion


			output.Content.AppendHtml(inputGroupEl);

			return Task.CompletedTask;
			#endregion
		}


	}
}
