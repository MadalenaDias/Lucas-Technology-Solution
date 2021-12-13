using LTSSolution.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LTS.Module.Core.Models
{
    public class Entity : EntityBase
    {
        public string Slug { get; private set; }

        public string Name { get; private set; }

        public long EntityId { get; private set; }

        public string EntityTypeId { get; private set; }

        public EntityType EntityType { get; private set; }
        
    }
}