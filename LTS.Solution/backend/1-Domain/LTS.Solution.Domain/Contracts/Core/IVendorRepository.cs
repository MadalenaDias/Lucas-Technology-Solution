using LTS.Solution.Domain.Models.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Solution.Domain.Contracts.Core
{
    public interface IVendorRepository
    {
        Task<Vendor> GetById(Guid id);

        Task<Vendor> GetName(string name);

        Task<Vendor> GetByCreatedOn(DateTimeOffset createdOn);

        Task<Vendor> GetByLatestUpdatedO(DateTimeOffset latestUpdatedO);

        void Add(Vendor vendor);

        void Update(Vendor vendor);

        void Remove(Vendor vendor);
    }
}
