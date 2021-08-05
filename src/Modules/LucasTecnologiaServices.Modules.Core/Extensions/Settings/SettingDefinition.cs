using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Core.Extensions.Settings
{
    public class SettingDefinition
    {
        public string Name { get; private set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public string DefaultValue { get; set; }
        public bool IsVisibleToClients { get; set; }
        public Dictionary<string, object> ExtraProperties { get; set; }
        public SettingDefinition(
            string name,
            string defaultvalue,
            string displayName = null,
            string description = null,
            bool isVisibleToClients = false)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
            DefaultValue = defaultvalue;
            DisplayName = displayName;
            Description = description;
            IsVisibleToClients = isVisibleToClients;
            ExtraProperties = new Dictionary<string, object>();
        }

        public virtual void SetExtraProperties(Dictionary<string, object> extraProperties)
        {
            if (extraProperties != null)
            {
                ExtraProperties = extraProperties;
            }
        }






    }
}
