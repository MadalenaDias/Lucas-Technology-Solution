using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Catalog.Areas.Catalog.ViewModels
{
    public class SimpleProductWidgetSetting
    {
        public IList<ProductLinkVm> Products { get; set; } = new List<ProductLinkVm>();
    }
}
