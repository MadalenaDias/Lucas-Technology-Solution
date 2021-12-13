using LTSSolution.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Module.Core.Models
{
    public class District : EntityBase
    {
        public District() { }

        public District(long id)
        {
            Id = id;
        }

        public long StateOrProvinceId { get; private set; }

        public StateOrProvince StateOrProvince { get; private set; }

        public string Name { get; private set; }

        public string Type { get; private set; }

        public string Location { get; private set; }
        
    }
}