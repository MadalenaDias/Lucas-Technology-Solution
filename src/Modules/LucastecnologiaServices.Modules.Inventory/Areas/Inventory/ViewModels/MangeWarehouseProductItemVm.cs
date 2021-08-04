using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucastecnologiaServices.Modules.Inventory.Areas.Inventory.ViewModels
{
    public class MangeWarehouseProductItemVm
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Sku { get; set; }

        public int? Quantity { get; set; }

        public bool IsExistInWarehouse
        {
            get
            {
                return Quantity.HasValue;
            }
        }
    }
}
