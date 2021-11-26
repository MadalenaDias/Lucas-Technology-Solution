using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LTSSolution.Infrastructure.Models;
using Microsoft.AspNetCore.Identity;

namespace LTS.Solution.Domain.Models.Core
{
    public class Role  : IdentityRole<long>, IEntityWithTypedId<long>
    {
        public IList<UserRole> Users { get; set; } = new List<UserRole>();
    }
}
