using LucastecnologiaServices.Modules.Inventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace LucastecnologiaServices.Modules.Inventory.Data
{
    public class InventoryCustomModelBuilder : ICustomModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Warehouse>().HasData(new Warehouse(1) { Name = "Default warehouse", AddressId = 1 });
        }
    }
}
