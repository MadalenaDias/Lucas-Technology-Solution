using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Tax.Areas.Tax.ViewModels
{
    public class TaxRateImportForm
    {
        public bool IncludeHeader { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        public string CsvDelimiter { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        public IFormFile CsvFile { get; set; }
    }
}
