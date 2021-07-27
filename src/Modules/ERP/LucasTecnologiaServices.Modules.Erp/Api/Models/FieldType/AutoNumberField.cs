using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Api.Models.FieldType
{
	public class InputAutoNumberField : InputField
	{
		[JsonProperty(PropertyName = "fieldType")]
		public static FieldType FieldType { get { return FieldType.AutoNumberField; } }

		[JsonProperty(PropertyName = "defaultValue")]
		public decimal? DefaultValue { get; set; }

		[JsonProperty(PropertyName = "displayFormat")]
		public string DisplayFormat { get; set; }

		[JsonProperty(PropertyName = "startingNumber")]
		public decimal? StartingNumber { get; set; }
	}

	[Serializable]
	public class AutoNumberField : Field
	{
		[JsonProperty(PropertyName = "fieldType")]
		public static FieldType FieldType { get { return FieldType.AutoNumberField; } }

		[JsonProperty(PropertyName = "defaultValue")]
		public decimal? DefaultValue { get; set; }

		[JsonProperty(PropertyName = "displayFormat")]
		public string DisplayFormat { get; set; }

		[JsonProperty(PropertyName = "startingNumber")]
		public decimal? StartingNumber { get; set; }
	}
}
