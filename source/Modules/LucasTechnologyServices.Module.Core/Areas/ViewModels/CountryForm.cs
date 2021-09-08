using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTechnologyServices.Module.Core.Areas.ViewModels
{
    public class CountryForm
    {
        [Required(ErrorMessage = "The {0} field is required.")]
        public string Id { get; set; }

        public string Name { get; set; }

        public string Code3 { get; set; }

        public bool IsBillingEnabled { get; set; }

        public bool IsShippingEnabled { get; set; }

        public bool IsCityEnabled { get; set; }

        public bool IsZipCodeEnabled { get; set; }

        public bool IsDistrictEnabled { get; set; }
    }
}
