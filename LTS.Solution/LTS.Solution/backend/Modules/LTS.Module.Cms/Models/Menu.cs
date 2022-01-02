using LTSSolution.Infrastructure;
using LTSSolution.Infrastructure.Models;
using System.Collections.Generic;

namespace LTS.Module.Cms.Models
{
    public class Menu : EntityBase
    {
        public Menu()
        {

        }

        public Menu(long id)
        {
            Id = id;
        }
        

        public string Name {get; private set; }

        public bool IsPublished {get; set; }

        public bool IsSystem {get; private set; }

        public IList<MenuItem> MenuItems {get; protected set;} = new List<MenuItem>();
        
    }
}