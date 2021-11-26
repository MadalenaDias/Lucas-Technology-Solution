using LTSSolution.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Solution.Domain.Models.Core
{
    public class Widget : EntityBaseWithTypedId<string>
    {
        public Widget(string id)
        {
            Id = id;
            CreatedOn = DateTimeOffset.Now;
        }

        public string Code
        {
            get
            {
                return Id;
            }
        }

        public string Name { get; private set; }

        public string ViewComponentName { get; private set; }

        public string CreateUrl { get; private set; }

        public string EditUrl { get; private set; }

        public DateTimeOffset CreatedOn { get; private set; }

        public bool IsPublished { get; private set; }
    }
}
