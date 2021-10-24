using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Erp.Shared.Entities.Financial
{
    public class PaymentsSchedule
    {
        public PaymentTerm PaymentTerm { get; set; }
        
        [Required(ErrorMessage = "The {0} field is required.")]
        public DateTimeOffset PaymentDate { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        public decimal PaymentValue { get; set; }
    }
}
