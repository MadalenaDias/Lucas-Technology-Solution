using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Erp.Shared.Entities.Financial
{
    public sealed class BankAccountScrudView
    {

        [Required(ErrorMessage = "The {0} field is required.")]
        public string MaintainedByUserId { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        public string Office { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        public string BankName { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        public string BankBranch { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        public string BankContactNumber { get; set; }
        public string BankAddress { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        public string BankAccountNumber { get; set; }

        
        [Required(ErrorMessage = "The {0} field is required.")]
        public string BankAccountType { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        public string RelationshipOfficerName { get; set; }
        public bool? IsMerchantAccount { get; set; }

    }
}
