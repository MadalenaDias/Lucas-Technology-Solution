namespace LucasTechnologyServices.Module.Core.Models
{
    public class AppSetting
    {
        public AppSetting(string id)
        {
            Id = id;
        }

        public string Value { get; private set; }
        public string Module {get; private set; }
        public bool IsVisibleInCommonSettingPage { get; sprivate et; }
        
    }
}