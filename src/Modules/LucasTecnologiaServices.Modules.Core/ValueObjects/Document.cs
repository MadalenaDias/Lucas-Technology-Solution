using LucasTecnologiaServices.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Core.ValueObjects
{
    public class Document : EntityBase
    {
        public Document(string number)
        {
            Number = number;
            CreatedOn = DateTimeOffset.Now;
            LatestUpdatedOn = DateTimeOffset.Now;
        }

        public string Number { get; set; }
        public DateTimeOffset CreatedOn { get; set; }

        public DateTimeOffset LatestUpdatedOn { get; set; }
        public override string ToString()
        {
            return Number;
                
        }

        
    }
}
