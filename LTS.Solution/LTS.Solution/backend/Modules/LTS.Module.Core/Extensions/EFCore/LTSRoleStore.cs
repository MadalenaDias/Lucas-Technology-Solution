using LTS.Module.Core.Data.EFCore;
using LTS.Module.Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Module.Core.Extensions.EFCore
{
    public class LTSRoleStore : RoleStore<Role, CoreDbContext, long, UserRole, IdentityRoleClaim<long>>
    {
        public LTSRoleStore(CoreDbContext context, IdentityErrorDescriber describer = null) : base(context, describer)
        {
        }
    }
}
