using LTSSolution.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Module.Core.Models
{
    public class StateOrProvince : EntityBase
    {
        public StateOrProvince()
        {

        }

        public StateOrProvince(long id)
        {
            Id = id;
        }

        [StringLength(450)]
        public string CountryId { get; set; }

        public Country Country { get; set; }

        [StringLength(450)]
        public string Code { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        [StringLength(450)]
        public string Name { get; set; }

        [StringLength(450)]
        public string Type { get; set; }
        
    }
}