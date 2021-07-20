using LucasTecnologiaServices.Infrastructure.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Core.Models
{
    public class User : IdentityUser<long>, IEntityWithTypedId<long>, IExtendableObject
    {
        public string ExtensionData { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}