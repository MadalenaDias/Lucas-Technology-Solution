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
    public class LTSRoleErp : RoleStore<Role, LTS1DbCbContext, long, UserRole, IdentityRoleClaim<long>>
    {
        public LTSRoleErp(LTS1DbCbContext context) : base(context)
        {
        }
    }
}
