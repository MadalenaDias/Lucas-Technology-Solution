using LucastecnologiaServices.Modules.Inventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucastecnologiaServices.Modules.Inventory.Services
{
    public interface IStockService
    {
        Task AddAllProduct(Warehouse warehouse);

        Task UpdateStock(StockUpdateRequest stockUpdateRequest);
    }
}
