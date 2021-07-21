using LucasTecnologiaServices.Infrastructure.Models;
using LucasTecnologiaServices.Modules.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Tax.Models
{
    public class TaxRate : EntityBase
    {
        public long TaxClassId { get; set; }

        public TaxClass TaxClass { get; set; }

        [StringLength(450)]
        public string CountryId { get; set; }

        public Country Country { get; set; }

        public long? StateOrProvinceId { get; set; }

        public StateOrProvince StateOrProvince { get; set; }

        public decimal Rate { get; set; }

        [StringLength(450)]
        public string ZipCode { get; set; }
    }
}
