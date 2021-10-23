using System;


namespace Shared.Entities.Core
{
    public class UserInfo
    {
        
        public long UserId { get; set; }
        public User User { get; set; }
        public bool IsAuthenticated { get; set; }
        
    }
}