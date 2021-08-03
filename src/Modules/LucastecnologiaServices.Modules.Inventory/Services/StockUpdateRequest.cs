using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucastecnologiaServices.Modules.Inventory.Services
{
    public class StockUpdateRequest
    {
        public long UserId { get; set; }

        public long ProductId { get; set; }

        public long WarehouseId { get; set; }

        public int AdjustedQuantity { get; set; }

        public string Note { get; set; }
    }
}
