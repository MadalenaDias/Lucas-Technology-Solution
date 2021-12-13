using LTSSolution.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Module.Core.Models
{
    public class StateOrProvince : EntityBaseWithTypedId<string>
    {
        public StateOrProvince()
        {

        }

        public StateOrProvince(string id)
        {
            Id = id;
        }

        public string CountryId { get; private set; }

        public Country Country { get; private set; }

        public string Code { get; private set; }

        public string Name { get; private set; }

        public string Type { get; private set; }
        
    }
}