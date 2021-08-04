﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.Models
{
    public class ErpTranslationDictionary
    {
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; } = "";

        [JsonProperty(PropertyName = "lang")]
        public ErpTranslationLanguage Lang { get; set; }
    }

    public class ErpTranslationLanguage
    {
        [JsonProperty(PropertyName = "default")]
        public string Default { get; set; } = "";

        [JsonProperty(PropertyName = "bg")]
        public string Bg { get; set; } = "";
    }
}
