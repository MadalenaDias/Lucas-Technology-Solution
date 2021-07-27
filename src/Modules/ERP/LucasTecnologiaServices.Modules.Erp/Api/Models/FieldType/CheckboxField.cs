using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Api.Models.FieldType
{
	public class InputCheckboxField : InputField
	{
		[JsonProperty(PropertyName = "fieldType")]
		public static FieldType FieldType { get { return FieldType.CheckboxField; } }

		[JsonProperty(PropertyName = "defaultValue")]
		public bool? DefaultValue { get; set; }
	}

	[Serializable]
	public class CheckboxField : Field
	{
		[JsonProperty(PropertyName = "fieldType")]
		public static FieldType FieldType { get { return FieldType.CheckboxField; } }

		[JsonProperty(PropertyName = "defaultValue")]
		public bool? DefaultValue { get; set; }
	}
}
