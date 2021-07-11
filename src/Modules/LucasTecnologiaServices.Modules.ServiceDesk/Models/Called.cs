using LucasTecnologiaServices.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.ServiceDesk.Models
{
    public class Called : EntityBase
    {
        
        public Called() { }

        public Called(long id)
        {
            Id = id;
        }
        
        
        public string OS { get; set; }

        public DateTime OrigDate { get; set; }

        public DateTime ClosedDate { get; set; }

        public Category Category { get; set; }
        public string CategoryId { get; set; }

        public List<Category> Categories { get; set; }
    }
}
