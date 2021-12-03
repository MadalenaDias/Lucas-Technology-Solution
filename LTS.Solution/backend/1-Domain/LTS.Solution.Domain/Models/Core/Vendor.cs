using LTS.Solution.Domain.ValueObjects;
using LTSSolution.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Solution.Domain.Models.Core
{
    public class Vendor : EntityBase
    {
        private IList<CpfCnpj> _cpfCnpj;

        public Vendor()
        {
            CreatedOn = DateTimeOffset.Now;
            
        }

        public string Name { get; private set; }

        public string Slug { get; private set; }

        public string Description { get; private set; }

        public Email Email { get; private set; }

        public IReadOnlyCollection<CpfCnpj> CpfCnpjs { get { return _cpfCnpj.ToArray(); } }

        public DateTimeOffset CreatedOn { get; private set; }

        public DateTimeOffset LatestUpdatedOn { get; private set; }

        public bool IsActive { get; private set; }

        public bool IsDeleted { get; private set; }

        public IList<User> Users { get; private set; } = new List<User>();
    }
}
