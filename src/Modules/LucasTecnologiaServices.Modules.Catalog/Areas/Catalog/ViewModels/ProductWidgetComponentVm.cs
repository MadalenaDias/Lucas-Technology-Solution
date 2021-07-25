using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Catalog.Areas.Catalog.ViewModels
{
    public class ProductWidgetComponentVm
    {
        public long Id { get; set; }

        public string WidgetName { get; set; }

        public ProductWidgetSetting Setting { get; set; }

        public IList<ProductThumbnail> Products { get; set; }
    }
}
