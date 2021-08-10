using LucasTecnologiaServices.Modules.Erp.Api.Models.FieldType;
using LucasTecnologiaServices.Modules.Erp.Api.Models;
using LucasTecnologiaServices.Modules.Erp.Web.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.TagHelpers.WvFilterSelect
{
	[HtmlTargetElement("wv-filter-select")]
	public class WvFilterSelect : WvFilterBase
	{
		[HtmlAttributeName("value-options")]
		public List<SelectOption> ValueOptions { get; set; } = new List<SelectOption>();

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

			var selectEl = new TagBuilder("select");
			selectEl.AddCssClass("form-control value");
			if (QueryType != FilterType.BETWEEN && QueryType != FilterType.NOTBETWEEN)
			{
				selectEl.AddCssClass("rounded-right");
			}
			selectEl.Attributes.Add("name", UrlQueryOfValue);

			{
				var optionEl = new TagBuilder("option");
				optionEl.Attributes.Add("value", "");
				optionEl.Attributes.Add("selected", null);
				optionEl.InnerHtml.Append("");
selectEl.InnerHtml.AppendHtml(optionEl);
			}
			foreach (var option in ValueOptions)
			{
				var optionEl = new TagBuilder("option");
				optionEl.Attributes.Add("value", option.Value);
				if (option.Value == (Value ?? "").ToString())
				{
					optionEl.Attributes.Add("selected", null);
				}
				optionEl.InnerHtml.Append(option.Label);
				selectEl.InnerHtml.AppendHtml(optionEl);
			}

			inputGroupEl.InnerHtml.AppendHtml(selectEl);

			output.Content.AppendHtml(inputGroupEl);

			return Task.CompletedTask;
			#endregion
		}


	}
}
