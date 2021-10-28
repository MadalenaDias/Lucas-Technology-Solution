using LucasTechnologyService.Infrastructure.Models;
using LucasTechnologyServices.Module.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Document = LucasTechnologyServices.Module.Core.Models.Document;

namespace LucasTechnologyServices.Module.Commercial.Entities
{
    public class Contract : EntityBase
    {
        private readonly IList<Customer> _customers;

        public Contract(long id, string contractNumber,
            Document document)
        {
            Id = id;
            _customers = new List<Customer>();
            ContractNumber = contractNumber;
            Document = document;
        }

        public string ContractNumber { get; set; }
        public Customer Customer { get; set; }
        public Document Document { get; set;}
        public IReadOnlyCollection<Customer> Customers => _customers.ToArray();

        public void AddCustomer(Customer customer)
        {
            _customers.Add(customer);
        }

        
    }
}
