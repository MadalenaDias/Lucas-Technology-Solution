using LTS.Solution.Domain.Models.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Solution.Domain.Contracts.Core
{
    public interface ICountryRepository 
    {
        Task<Country> GetById(Guid id);
        Task<Country> GetByCode3(string Code3);
        Task<IEnumerable<Country>> GetAll();

        void Add(Country country);
        void Update(Country country);
        void Remove(Country country);
    }
}
