﻿using Newtonsoft.Json;

namespace WebVella.Erp.Database
{
    public class DbMultiLineTextField : DbBaseField
    {
		[JsonProperty(PropertyName = "default_value")]
		public string DefaultValue { get; set; }

		[JsonProperty(PropertyName = "max_length")]
		public int? MaxLength { get; set; }

		[JsonProperty(PropertyName = "visible_line_number")]
		public int? VisibleLineNumber { get; set; }
    }
}