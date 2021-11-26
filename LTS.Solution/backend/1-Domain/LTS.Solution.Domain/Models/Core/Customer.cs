using LTS.Solution.Domain.ValueObjects;
using LTSSolution.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Solution.Domain.Models.Core
{
    public class Customer : EntityBase
    {
        public Name Name { get; private set; }
        public Email Email { get; private set; }
        public CpfCnpj Cpf { get; private set; }
    }
}
