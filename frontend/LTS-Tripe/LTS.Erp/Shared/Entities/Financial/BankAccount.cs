using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Erp.Shared.Entities.Financial
{
    public class BankAccount
    {
        public long AccountId { get; set; }
        
        public int MaintainedByUserId { get; set; }
        
        public int OfficeId { get; set; }
        
        public string BankName { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        public string BankBranch { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        public string BankContactNumber { get; set; }
        
        public string BankAddress { get; set; }
        
        public string BankAccountNumber { get; set; }
        
        public string BankAccountType { get; set; }
        
        public string RelationshipOfficerName { get; set; }
        
        public int? AuditUserId { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        public DateTime? AuditTs { get; set; }
        
        public bool IsMerchantAccount { get; set; }

    }
}
