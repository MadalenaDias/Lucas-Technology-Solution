using System;

namespace Shared.Entities.Core
{
    public class User
    {
        public User()
        {
            CreatedOn = DateTimeOffset.Now;;
            LatestUpdatedOn = DateTimeOffset.Now;;;
        }

        public string FullName { get; set; }
        public DateTimeOffset CreatedOn { get; set; }

        public DateTimeOffset LatestUpdatedOn { get; set; }
    }
}