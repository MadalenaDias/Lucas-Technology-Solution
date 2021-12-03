using LTS.Solution.Domain.ValueObjects; 
using LTSSolution.Infrastructure.Models;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Solution.Domain.Models.Core
{
    public class User : IdentityUser<long>, IEntityWithTypedId<long>, IExtendableObject
    {
        public User()
        {
            CreatedOn = DateTimeOffset.Now;
            LatestUpdatedOn = DateTimeOffset.Now;
        }

        public const string SettingsDataKey = "Settings";

        public Guid UserGuid { get; set; }

        
        public string FullName { get; set; }

        public long? VendorId { get; set; }

        public bool IsDeleted { get; set; }

        public DateTimeOffset CreatedOn { get; set; }

        public DateTimeOffset LatestUpdatedOn { get; set; }

                
        public string RefreshTokenHash { get; set; }

        public IList<UserRole> Roles { get; set; } = new List<UserRole>();
        
        public string Culture { get; set; }

        /// <inheritdoc />
        public string ExtensionData { get; set; }

        public T GetData<T>(string name, JsonSerializer jsonSerializer)
        {
            throw new NotImplementedException();
        }

        public void SetData<T>(string name, T value, JsonSerializer jsonSerializer)
        {
            throw new NotImplementedException();
        }
    }
}
