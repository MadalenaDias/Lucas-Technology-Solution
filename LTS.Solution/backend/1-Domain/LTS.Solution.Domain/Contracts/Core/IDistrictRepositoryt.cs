using System.Collections.Generic;
using System.Threading.Tasks;
using LTS.Solution.Domain.Models.Core;




namespace LTS.Solution.Domain.Contracts.Core
{
    public interface IDistrictRepositoryt
    {
         Task<District> GetById(Guid id);
         Task<District> GetByName(string name);
         Task<IEnumerable<District>> GetAll();

         void Add(District district);
         void Update(District district);
         void Remove(District district);
    }

    public class Guid
    {
    }
}