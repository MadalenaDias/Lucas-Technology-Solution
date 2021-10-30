using System.Collections.Generic;

namespace LucasTechnologyServices.Module.Core.Models
{
    public class Role
    {
        public IList<UserRole> Users { get; set; }
        
        public string Name {get; set; }
        
        public string Description { get; set; }

    }
}
