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
    public class LTSUserStore : UserStore<User, Role, CoreDbContext, long, IdentityUserClaim<long>, UserRole,
        IdentityUserLogin<long>, IdentityUserToken<long>, IdentityRoleClaim<long>>
    {
        public LTSUserStore(CoreDbContext context, IdentityErrorDescriber describer = null) : base(context, describer)
        {
        }
    }
}
