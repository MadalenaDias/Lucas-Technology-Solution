using System.Collections.Generic;
using LTSSolution.Infrastructure.Models;

namespace LTS.Module.HR.Models
{
    public class Marital : EntityBase
    {
        public Marital(long id)
        {
            Id = id;
        }

        public bool married { get; set; }

        public bool Single {get; set; }
        
    }
}