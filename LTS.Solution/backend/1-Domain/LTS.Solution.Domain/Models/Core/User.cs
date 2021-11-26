

using LTS.Solution.Domain.ValueObjects;
using LTSSolution.Infrastructure.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

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

        public Guid UserGuid { get; private set; }

        
        public Name Name { get; private set; }

        public long? VendorId { get; private set; }

        public bool IsDeleted { get; private set; }

        public DateTimeOffset CreatedOn { get; private set; }

        public DateTimeOffset LatestUpdatedOn { get; private set; }


        public string RefreshTokenHash { get; set; }

        public IList<UserRole> Roles { get; private set; } = new List<UserRole>();

        public string Culture { get; private set; }

        /// <inheritdoc />
        public string ExtensionData { get; set; }
    }
}
