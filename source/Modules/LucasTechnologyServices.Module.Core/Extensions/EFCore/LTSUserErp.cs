using LucasTechnologyServices.Module.Core.Data.EFCore;
using LucasTechnologyServices.Module.Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTechnologyServices.Module.Core.Extensions.EFCore
{
    public class LTSUserErp : UserStore<User, Role, LTS1DbCbContext, long, IdentityUserClaim<long>, UserRole,
        IdentityUserLogin<long>, IdentityUserToken<long>, IdentityRoleClaim<long>>
    {
        public LTSUserErp(LTS1DbCbContext context, IdentityErrorDescriber describer) : base(context, describer)
        {
        }
    }
}
