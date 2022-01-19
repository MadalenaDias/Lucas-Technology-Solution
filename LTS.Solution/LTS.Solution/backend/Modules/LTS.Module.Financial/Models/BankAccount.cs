using LTSSolution.Infrastructure.Models;

namespace LTS.Module.Financial.Models
{
    public class BankAccount : EntityBase
    {

        public string Branch { get; set; }
        public string BranchDigit { get; set; }
        public string Account { get; set; }
        public string AccountDigit { get; set; }
        
    }
}