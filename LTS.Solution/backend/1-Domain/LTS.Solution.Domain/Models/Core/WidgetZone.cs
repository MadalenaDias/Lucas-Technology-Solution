using LTSSolution.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Solution.Domain.Models.Core
{
    public class WidgetZone : EntityBase
    {
        
        public WidgetZone(long id)
        {
            Id = id;
        }
        
        public string Name { get; private set; }

        public string Description { get; private set; }
    }
}
