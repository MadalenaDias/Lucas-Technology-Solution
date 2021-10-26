using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LucasTechnologyServices.Infrastructure.Models.;

namespace LucasTechnologyServices.Module.Tax.Models
{
    public class TaxClass : EntityBase
    {

        public TaxClass()
        {
            Id = id;
        }
        
        [Required(ErrorMessage = "The {0} field is required.")]
        [StringLength(450)]
        public string Name { get; set; }
    }

}
