using System;
using System.Collections.Generic;
using System.Linq;
using LucasTechnologyService.Infrastructure.Models;

namespace LucasTechnologyServices.Module.ServiceDesk.Models
{
    public class Call : EntityBase
    {
        public string CallNumber { get; set; }
        
        public CategoryCall CategoryCall { get; set; }
        
        public Customer Customer { get; set; }
        
        public DateTimeOffset OrigDate { get; set; }
        
        public DateTimeOffset EndDate { get; set; }

        public string AttendName { get; set; }

        public string EmailCustomer { get; set; }

        public string EmailDirect { get; set; }

        public string EmailForward { get; set; }
        
        
        
        
        
        
        
        
            
        
        
        
        
    }
}