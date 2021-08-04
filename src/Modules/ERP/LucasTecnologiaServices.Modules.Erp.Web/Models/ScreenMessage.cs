using LucasTecnologiaServices.Modules.Erp.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.Models
{
	public class ScreenMessage
	{
		[JsonProperty(PropertyName = "type")]
		public ScreenMessageType Type { get; set; } = ScreenMessageType.Success;

		[JsonProperty(PropertyName = "title")]
		public string Title { get; set; } = "";

		[JsonProperty(PropertyName = "message")]
		public string Message { get; set; } = "";
	}

	[Serializable]
	public enum ScreenMessageType
	{
		[SelectOption(Label = "success")]
		Success = 0,
		[SelectOption(Label = "info")]
		Info = 1,
		[SelectOption(Label = "warning")]
		Warning = 2,
		[SelectOption(Label = "error")]
		Error = 3
	}
}
