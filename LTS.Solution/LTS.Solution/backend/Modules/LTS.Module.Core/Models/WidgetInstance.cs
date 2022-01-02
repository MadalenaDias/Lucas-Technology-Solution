using LTSSolution.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Module.Core.Models
{
    public class WidgetInstance : EntityBase
    {

        public WidgetInstance()
        {
            CreatedOn = DateTimeOffset.Now;
            LatestUpdatedOn = DateTimeOffset.Now;
        }

        public string Name { get; private set; }

        public DateTimeOffset CreatedOn { get; private set; }

        public DateTimeOffset LatestUpdatedOn { get; private set; }

        public DateTimeOffset? PublishStart { get; private set; }

        public DateTimeOffset? PublishEnd { get; private set; }

        public string WidgetId { get; private set; }

        public Widget Widget { get; private set; }

        public long WidgetZoneId { get; private set; }

        public WidgetZone WidgetZone { get; private set; }

        public int DisplayOrder { get; private set; }

        public string Data { get; private set; }

        public string HtmlData { get; private set; }

        /// <summary>
        /// This property cannot be used to filter again DB because it don't exist in database
        /// </summary>
        public bool IsPublished
        {
            get
            {
                return PublishStart.HasValue && PublishStart.Value < DateTimeOffset.Now && (!PublishEnd.HasValue || PublishEnd.Value > DateTimeOffset.Now);
            }
        }
        
    }
}