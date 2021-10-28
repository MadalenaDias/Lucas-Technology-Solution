using LucasTechnologyService.Infrastructure.Models;
using LucasTechnologyServices.Module.Core.Models;

namespace LucasTechnologyServices.Module.Audit.Models
{
    public class FailedLogin : EntityBase
    {
        public FailedLogin(long id)
        {
            Id = id;
        }

        public int? UserId { get; set; }

        public User User { get; set; }
        public int? OfficeId { get; set; }
        public string Browser { get; set; }
        public string IpAddress { get; set; }
        public DateTime FailedDateTime { get; set; }
        public string RemoteUser { get; set; }
        public string Details { get; set; }

    }
}
