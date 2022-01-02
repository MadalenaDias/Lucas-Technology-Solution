using LTSSolution.Infrastructure.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Module.Core.Models
{
    public class CustomerUser : IdentityUser<long>, IEntityWithTypedId<long>, IExtendableObject
    {
        public CustomerUser()
        {
            CreatedOn = DateTimeOffset.Now;
            LatestUpdatedOn = DateTimeOffset.Now;
        }

        public const string SettingsDataKey = "Settings";

        public Guid CustomerUserGuid { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        [StringLength(450)]
        public string FullName { get; set; }

        public bool IsDeleted { get; set; }

        public DateTimeOffset CreatedOn { get; set; }

        public DateTimeOffset LatestUpdatedOn { get; set; }

        public IList<CustomerAddress> CustomerAddresses { get; set; } = new List<CustomerAddress>();

        public CustomerAddress DefaultShippingAddress { get; set; }

        public long? DefaultShippingAddressId { get; set; }

        public CustomerAddress DefaultBillingAddress { get; set; }

        public long? DefaultBillingAddressId { get; set; }

        [StringLength(450)]
        public string RefreshTokenHash { get; set; }

        public IList<CustomerUser> CustomerUsers { get; set; } = new List<CustomerUser>();

        [StringLength(450)]
        public string Culture { get; set; }

        /// <inheritdoc />

        public string ExtensionData { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
