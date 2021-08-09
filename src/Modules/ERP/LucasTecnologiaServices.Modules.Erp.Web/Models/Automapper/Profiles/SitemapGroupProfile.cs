using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.Models.Automapper.Profiles
{
	public class SitemapGroupProfile : Profile
	{
		public SitemapGroupProfile()
		{
			CreateMap<JToken, SitemapGroup>().ConvertUsing(source => JTokenToSitemapGroupConvert(source));
		}

		private static SitemapGroup JTokenToSitemapGroupConvert(JToken data)
		{
			if (data == null)
				return null;

			SitemapGroup model = new SitemapGroup();
			model.Id = new Guid(data["id"].ToString());
			model.Name = (string)data["name"];
			model.Label = (string)data["label"];
			model.Weight = (int)data["weight"];

			if (!string.IsNullOrWhiteSpace((string)data["label_translations"]))
				model.LabelTranslations = JsonConvert.DeserializeObject<List<TranslationResource>>((string)data["label_translations"]);
			else
				model.LabelTranslations = new List<TranslationResource>();

			model.RenderRoles = new List<Guid>();
			if (data["render_roles"] != null)
			{
				foreach (var rId in data["render_roles"].AsJEnumerable())
					model.RenderRoles.Add(new Guid(rId.ToString()));
			}

			return model;
		}
	}
}
