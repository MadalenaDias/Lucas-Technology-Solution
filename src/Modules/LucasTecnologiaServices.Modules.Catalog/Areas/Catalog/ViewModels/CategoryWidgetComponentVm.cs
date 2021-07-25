using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Catalog.Areas.Catalog.ViewModels
{
    public class CategoryWidgetComponentVm
    {
        public long Id { get; set; }

        public string WidgetName { get; set; }

        public CategoryThumbnail Category { get; set; }
    }
}
