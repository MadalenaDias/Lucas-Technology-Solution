using LTS.Solution.Domain.Models.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Solution.Domain.Contracts.Core
{
    public interface IStateOrProvinceRepository
    {
        Task<StateOrProvince> GetById(Guid id);
        Task<StateOrProvince> GetByName(string name);
        Task<StateOrProvince> GetByCode(string code);

        void Add(StateOrProvince state);
        void Update(StateOrProvince state);
        void Remove(StateOrProvince state);
    }
}
