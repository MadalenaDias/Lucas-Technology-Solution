using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LTSSolution.Infrastructure.Models;

namespace LTS.Module.Core.Models
{
    public class AppSetting : EntityBase
    {
        public AppSetting(long id)
        {
            Id = id;
        }

        public string Value { get; private set; }

        public string Module { get; private set; }

        public bool IsVisibleInCommonSettingPage { get; private set; }
        
    }
}