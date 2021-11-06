using System.Collections.Generic;
using System.Linq;
using LucasTechnologyService.Infrastructure.Models;

namespace LucasTechnologyServices.Module.ServiceDesk.Models
{
    public class Sla : EntityBase
    {
        public CategoryCall CategoryCall { get; set; }

        public string MaxSla { get; set; }

        public string MinSla { get; set; }
          
        public string MetaTitle { get; set; }
        
        public string KeyWords { get; set; }
        
        public string MetaDescription { get; set; }
        
        public string Description { get; set; }
        
        public int DisplayCall { get; set; }
        
        public bool IsPublished { get; set; }
        
        public bool IsDeleted { get; set; }
        
        public bool IncludeinMenu { get; set; }
        
        
        
    }
}