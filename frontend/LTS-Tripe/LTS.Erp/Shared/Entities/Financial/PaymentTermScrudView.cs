using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Erp.Shared.Entities.Financial
{
    public class PaymentTermScrudView
    {
        public int? PaymentTermId { get; set; }

        public string PaymentTermCode { get; set; }

        public string PaymentTermName { get; set; }

        public bool? DueOnDate { get; set; }

        public int? DueDays { get; set; }
        
        public string DueFrequency { get; set; }
                
        public int? GracePeriod { get; set; }
                
        public string LateFee { get; set; }
                
        public string LateFeePostingFrequency { get; set; }
    }
}
