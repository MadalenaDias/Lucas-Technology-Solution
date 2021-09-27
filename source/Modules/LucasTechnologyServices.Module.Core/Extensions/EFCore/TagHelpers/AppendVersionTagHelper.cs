using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTechnologyServices.Module.Core.Extensions.EFCore.TagHelpers
{
    public class AppendVersionTagHelper : TagHelper
    {
        private readonly IConfiguration _config;
        private const string AppendVersionAttributeName = "simpl-append-version";

        public AppendVersionTagHelper(IConfiguration config)
        {
            _config = config;
        }

        [HtmlAttributeName(AppendVersionAttributeName)]
        public bool AppendVersion { get; set; }

        public override int Order => int.MinValue;

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.RemoveAll(AppendVersionAttributeName);
            if (!AppendVersion)
            {
                return;
            }
        }
    }
}
