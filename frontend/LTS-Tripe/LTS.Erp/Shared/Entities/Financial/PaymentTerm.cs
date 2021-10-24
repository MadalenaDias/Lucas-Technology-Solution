using LTS.Erp.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Erp.Shared.Entities.Financial
{
    public sealed class PaymentTerm : EntityBase
    {
        
        [Required(ErrorMessage = "The {0} field is required.")]
        public string PaymentTermCode { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        [StringLength(100)]
        public string PaymentTermName { get; set; }

        public bool DueOnDate { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        public int DueDays { get; set; }

        public int? DueFrequencyId { get; set; }

        public int GracePeriod { get; set; }

        public int? LateFeeId { get; set; }

        public int? LateFeePostingFrequencyId { get; set; }

        public int? AuditUserId { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        public DateTime? AuditTs { get; set; }
    }
}
