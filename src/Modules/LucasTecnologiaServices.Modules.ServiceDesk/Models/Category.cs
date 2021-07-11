using LucasTecnologiaServices.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.ServiceDesk.Models
{
    public class Category : EntityBase
    {
        public Category() { }

        public Category(long id)
        {
            Id = id;
        }

        public string CategoryCalled { get; set; }

    }
}
