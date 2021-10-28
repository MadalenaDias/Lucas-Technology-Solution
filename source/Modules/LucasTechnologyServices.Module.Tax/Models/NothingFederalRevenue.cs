using LucasTechnologyService.Infrastructure.Models;
using System;

namespace LucasTechnologyServices.Module.Tax.Models
{
    public class NothingFederalRevenue : EntityBase
    {

        public NothingFederalRevenue(long id)
        {
            Id = id;
            IssueDate = DateTime.Now;
        }


        public string Certified { get; set; }
        public string NothingNumber { get; set; }
        public DateTime IssueDate { get; set; }
        public bool NothingContained { get; set; }
        public bool Contained { get; set; }



    }
}