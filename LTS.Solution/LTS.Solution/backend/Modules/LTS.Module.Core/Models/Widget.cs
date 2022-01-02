using LTSSolution.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Module.Core.Models
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


        [Required(ErrorMessage = "The {0} field is required.")]
        [StringLength(450)]
        public string Name { get; private set; }


        [StringLength(450)]
        public string ViewComponentName { get; private set; }


        [StringLength(450)]
        public string CreateUrl { get; private set; }


        [StringLength(450)]
        public string EditUrl { get; private set; }

        public DateTimeOffset CreatedOn { get; private set; }

        public bool IsPublished { get; private set; }
        
    }
}