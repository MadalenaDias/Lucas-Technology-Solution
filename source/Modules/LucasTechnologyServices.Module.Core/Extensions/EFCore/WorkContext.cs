using LucasTechnologyService.Infrastructure.Data;
using LucasTechnologyServices.Module.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTechnologyServices.Module.Core.Extensions.EFCore
{
    public class WorkContext : IWorkContext
    {
        
        public WorkContext(UserManager<User> UserManager,
            IHttpContextAccessor contextAccessor,
            IRepository<User> UserRepository,
            IConfiguration configuration)           
        {

        }
        
        
        public Task<User> GetCurrentuser()
        {
            throw new NotImplementedException();
        }
    }
}
