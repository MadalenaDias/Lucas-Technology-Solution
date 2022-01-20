namespace LTS.Module.Core.Models
{
    public class CustomerGroupUser
    {

                
        public long CustomerUserId {get; set;}

        public CustomerUser CustomerUser {get; set;}

        public long CustomerGroupId {get; set;}

        public CustomerGroup CustomerGroup {get; set;}
        
    }
}