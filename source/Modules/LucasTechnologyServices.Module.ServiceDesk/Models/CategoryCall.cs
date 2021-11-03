using System;
using System.Collections.Generic;
using System.Linq;
using LucasTechnologyService.Infrastructure.Models;

namespace LucasTechnologyServices.Module.ServiceDesk.Models
{
    public class CategoryCall : EntityBase
    {
        public string Name { get; set; }
        
        public string MetaTitle { get; set; }
        
        public string KeyWords { get; set; }
        
        public string MetaDescription { get; set; }
        
        public string Description { get; set; }
        
        public int DisplayCall { get; set; }
        
        public bool IsPublished { get; set; }
        
        public bool IsDeleted { get; set; }
        
        public bool IncludeinMenu { get; set; }
        
        public long? ParentId { get; set; }

        public Category Parent { get; set; }
        
        public IList<Category> Children { get; protected set; } = new List<Category>();

        public Media ThumbnailImage { get; set; }

        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    }
}