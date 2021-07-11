using LucasTecnologiaServices.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.ServiceDesk.Models
{
    public class RoleServDesk : EntityBase
    {
        public RoleServDesk() { }

        public RoleServDesk(long id)
        {
            Id = id;
        }
    }
}
