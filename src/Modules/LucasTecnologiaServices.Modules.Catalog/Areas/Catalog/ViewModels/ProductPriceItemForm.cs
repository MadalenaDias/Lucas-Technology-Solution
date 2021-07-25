using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Catalog.Areas.Catalog.ViewModels
{
    public class ProductPriceItemForm
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public decimal? NewPrice { get; set; }

        public decimal? NewOldPrice { get; set; }
    }
}
