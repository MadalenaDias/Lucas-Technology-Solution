using LTS.Module.Core.Models;
using LTSSolution.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Solution.Module.NF.Models
{
    public class NFModel : EntityBase
    {
        public NFModel(long id)
        {
            Id = id;
        }

        public DateTimeOffset OrigDate {get; set; }

        public IList<CpfCnpj> CpfCnpjs {get; set; } = new List<CpfCnpj>();

        public IList<Customer> Customers {get; set; } = new List<Customer>();

        public string value {get; set; }

        
        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(100)]
        public string Description {get; set; }


    }
}
