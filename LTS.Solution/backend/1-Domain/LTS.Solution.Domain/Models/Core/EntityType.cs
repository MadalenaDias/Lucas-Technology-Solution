using LTSSolution.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Solution.Domain.Models.Core
{
    public class EntityType : EntityBaseWithTypedId<string>
    {
        public EntityType()
        {

        }

        public EntityType(string id)
        {
            Id = id;
        }

        public string Name { get { return Id; } }

        public bool IsMenuable { get; private set; }

        public string AreaName { get; private set; }

        public string RoutingController { get; private set; }

        public string RoutingAction { get; private set; }
    }
}
