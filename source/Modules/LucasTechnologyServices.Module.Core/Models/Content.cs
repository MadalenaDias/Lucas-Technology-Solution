namespace LucasTechnologyServices.Module.Core.Models
{
    public abstract class Content : Entity
    {
        
        protected Content()
        {
            CreatedOn = DateTimeOffset.Now;
            LatestUpdatedOn = DateTimeOffset.Now;
        }
        
        public string Name { get; private set; }
        public string Slug { get; private set; }
        public string MetaTitle { get; private set; }
        public string keywords { get; private set; }
        public string Metadescription { get; private set; }
        public MarketingUser CreatedBy { get; private set; } 
        public DateTimeoffset CreatedOn { get; private set; }
        public DateTimeOffset LatestUpdatedOn { get; private set; }
        public MarketingUser LatestUpdatedBy { get; private set; }
        


        public bool IsPublished { get; private set; }
        public DateTimeOffset? PublishedOn { get; private set; }

        public bool IsDeleted 
        { 
            get
            {
                return isDeleted;
            }

            private set
            {
                isDeleted = value;
                if(value)
                { 
                    IsPublished = false;
                }
            }

            
        }
        
        
        
    }
}