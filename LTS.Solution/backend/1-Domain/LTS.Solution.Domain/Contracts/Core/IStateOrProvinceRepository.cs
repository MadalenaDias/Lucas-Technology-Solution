using System.Threading.Tasks;
using LTS.Solution.Domain.Models.Core;

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