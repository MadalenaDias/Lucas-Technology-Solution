using LucasTecnologiaServices.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.ServiceDesk.Models
{
    public class UserServDsk : EntityBase
    {
        public UserServDsk() { }
        
        public UserServDsk(long id)
        {
            Id = id;
        }
    }
}
