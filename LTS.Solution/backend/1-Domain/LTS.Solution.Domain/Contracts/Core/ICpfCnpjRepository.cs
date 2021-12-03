using LTS.Solution.Domain.Models.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Solution.Domain.Contracts.Core
{
    public interface ICpfCnpjRepository
    {
        Task<CpfCnpj> GetById(Guid id);
        Task<CpfCnpj> GetByCpf(string cpf);
        Task<CpfCnpj> GetByCnpj(string cnpj);
        Task<IEnumerable<CpfCnpj>> GetAll();

        void Add(CpfCnpj cpfCnpj);
        void Update(CpfCnpj cpfCnpj);
        void Remove(CpfCnpj cpfCnpj);
    }
}
