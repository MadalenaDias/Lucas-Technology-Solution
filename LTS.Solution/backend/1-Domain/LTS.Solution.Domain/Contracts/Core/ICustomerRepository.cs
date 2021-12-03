using LTS.Solution.Domain.Models.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Solution.Domain.Contracts.Core
{
    public interface ICustomerRepository
    {
        Task<Customer> GetById(Guid id);
        Task<Customer> GetByName(string name);
        Task<Customer> GetByEmail(string email);

        void Add(Customer customer);
        void Update(Customer customer);
        void Remove(Customer customer);
    }
}
