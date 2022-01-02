using LTS.Module.Core.ValueObjects;
using LTSSolution.Infrastructure.Models;
using System.ComponentModel.DataAnnotations;

namespace LTS.Module.Core.Models
{
    public class Customer : EntityBase
    {
        [Required(ErrorMessage = "The {0} field is required.")]
        [StringLength(450)]
        public Name Name { get; set; }
        
        public Email Email { get; set; }
        
        public CpfCnpj Cpf { get; set; }

        public string AddressId { get; set; }

        public Address Address { get; set; }

    }
}