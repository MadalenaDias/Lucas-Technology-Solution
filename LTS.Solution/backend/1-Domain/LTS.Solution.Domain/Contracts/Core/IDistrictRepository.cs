using LTS.Solution.Domain.Models.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Solution.Domain.Contracts.Core
{
    public interface IDistrictRepository
    {
        Task<District> GetById(Guid id);
        Task<District> GetByName(string name);
        Task<IEnumerable<District>> GetAll();

        void Add(District district);
        void Update(District district);
        void Remove(District district);
    }
}
