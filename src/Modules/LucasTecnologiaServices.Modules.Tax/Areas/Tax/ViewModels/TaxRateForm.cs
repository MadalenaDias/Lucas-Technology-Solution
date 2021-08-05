using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Tax.Areas.Tax.ViewModels
{
    public class TaxRateForm
    {
        public long Id { get; set; }

        [Range(1, long.MaxValue, ErrorMessage = "Tax Class is required")]
        public long TaxClassId { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        public string CountryId { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        public decimal Rate { get; set; }

        public long? StateOrProvinceId { get; set; }

        public string ZipCode { get; set; }
    }
}
