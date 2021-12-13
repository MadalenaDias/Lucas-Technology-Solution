using LTSSolution.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Module.Cms.Models
{
    public class MenuItem : EntityBase
    {
        public long? ParentId {get; private set; }

        public MenuItem Parent {get; private set;}

        public IList<MenuItem> Children {get; protected set;} = new List<MenuItem>();

        public long MenuId {get; private set; }

        public Menu Menu {get; private set; }

        public long EntityId {get; private set;}

        public Entity Entity {get; private set;}

        public string CustomLink {get; private set; }

        public string Name  {get;  private set;}



        

        
    }
}