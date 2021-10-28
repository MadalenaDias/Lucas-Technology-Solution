using LucasTechnologyService.Infrastructure.Models;
using System.ComponentModel.DataAnnotations;


namespace LucasTechnologyServices.Module.Tax.Models
{
    public class TaxClass : EntityBase
    {

        public TaxClass(long id)
        {
            Id = id;
        }

        [Required(ErrorMessage = "The {0} field is required.")]
        [StringLength(450)]
        public string Name { get; set; }
    }

}
