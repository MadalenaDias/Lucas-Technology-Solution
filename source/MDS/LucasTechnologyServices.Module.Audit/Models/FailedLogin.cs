using LucasTechnologyServices.Module.Core.Models;
using LucasTechnologyServices.Module.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTechnologyServices.Module.Audit.Models
{
    public class FailedLogin : EntityBase
    {
        public User User { get; set; }
    }
}
