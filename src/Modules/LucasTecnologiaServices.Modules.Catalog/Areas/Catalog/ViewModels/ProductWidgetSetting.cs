using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Catalog.Areas.Catalog.ViewModels
{
    public class ProductWidgetSetting
    {
        public int NumberOfProducts { get; set; }

        public long? CategoryId { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public ProductWidgetOrderBy OrderBy { get; set; }

        public bool FeaturedOnly { get; set; }
    }
}
