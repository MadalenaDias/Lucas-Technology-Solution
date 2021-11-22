
using LTS.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Crm.Domain.Models
{
    public class Menu : EntityBase
    {

        public string Name { get; set; }

        public bool IsPublished { get; set; }

        public bool System { get; set; }

        public IList<MenuItem> MenuItem { get; protected set; } = new List<MenuItem>();
    }
}
