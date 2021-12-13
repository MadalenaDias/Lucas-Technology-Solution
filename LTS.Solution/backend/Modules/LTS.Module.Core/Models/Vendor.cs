using System;
using System.Collections.Generic;
using LTSSolution.Infrastructure.Models;

namespace LTS.Module.Core.Models
{
    public class Vendor : EntityBase
    {
        public Vendor()
        {
            CreatedOn = DateTimeOffset.Now;
        }

        public string Name { get; set; }

        public string Slug { get; private set; }

        public string Description { get; private set; }

        public Email Email { get; private set; }

        public DateTimeOffset CreatedOn { get; private set; }

        public DateTimeOffset LatestUpdatedOn { get; private set; }

        public bool IsActive { get; private set; }

        public bool IsDeleted { get; private set; }

        public IList<User> Users { get; private set; } = new List<User>();
        
    }
}