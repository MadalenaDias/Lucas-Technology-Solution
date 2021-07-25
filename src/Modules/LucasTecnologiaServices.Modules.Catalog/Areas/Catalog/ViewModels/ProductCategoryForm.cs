using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Catalog.Areas.Catalog.ViewModels
{
    public class ProductCategoryForm
    {
        public long Id { get; set; }

        public bool IsFeaturedProduct { get; set; }

        public int DisplayOrder { get; set; }
    }
}
