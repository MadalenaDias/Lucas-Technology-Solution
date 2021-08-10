using LucasTecnologiaServices.Modules.Erp.Api.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.Models.Automapper.Profiles
{
	public class PageDataSourceProfile : Profile
	{
		public PageDataSourceProfile()
		{
			CreateMap<DataRow, PageDataSource>().ConvertUsing(source => DataRowToPageDataSourceConvert(source));
		}

		private static PageDataSource DataRowToPageDataSourceConvert(DataRow data)
		{
			if (data == null)
				return null;

			PageDataSource model = new PageDataSource();
			model.Id = new Guid(data["id"].ToString());
			model.Name = (string)data["name"];
			model.PageId = (Guid)data["page_id"];
			model.DataSourceId = (Guid)data["data_source_id"];

			if (!string.IsNullOrWhiteSpace((string)data["parameters"]))
				model.Parameters = JsonConvert.DeserializeObject<List<DataSourceParameter>>((string)data["parameters"]);
			else
				model.Parameters = new List<DataSourceParameter>();

			return model;
		}
	}
}
