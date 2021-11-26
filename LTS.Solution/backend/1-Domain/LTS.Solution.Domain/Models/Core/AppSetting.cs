using LTSSolution.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Solution.Domain.Models.Core
{
    public class AppSetting : EntityBaseWithTypedId<string>
    {
        public AppSetting(string id)
        {
            Id = id;
        }

        public string Value { get; private set; }

        public string Module { get; private set; }

        public bool IsVisibleInCommonSettingPage { get; private set; }
    }
}
