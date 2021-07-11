using LucasTecnologiaServices.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Core.Models
{
    public class StateSymbol : EntityBase
    {

        public StateSymbol() { }

        public StateSymbol(long id)
        {
            Id = id;
        }
        
        [StringLength(4)]
        public string StateSymb { get; set; }
    }
}
