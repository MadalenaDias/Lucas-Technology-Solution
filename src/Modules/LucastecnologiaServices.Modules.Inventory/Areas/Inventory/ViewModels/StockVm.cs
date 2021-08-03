using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucastecnologiaServices.Modules.Inventory.Areas.Inventory.ViewModels
{
    public class StockVm
    {
        public long ProductId { get; set; }

        public int AdjustedQuantity { get; set; }

        public string Note { get; set; }
    }
}
