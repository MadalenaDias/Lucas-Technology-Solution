using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Catalog.Areas.Catalog.ViewModels
{
    public class SimpleProductWidgetComponentVm
    {
        public long Id { get; set; }

        public string WidgetName { get; set; }

        public SimpleProductWidgetSetting Setting { get; set; }

        public IList<ProductThumbnail> Products { get; set; } = new List<ProductThumbnail>();
    }
}
