using LTS.Module.Core.Enums;
using LTSSolution.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LTS.Module.Core.Models
{
    public class Media : EntityBase
    {
        public Media(DateTimeOffset createdOn, DateTimeOffset uploadeddOn)
        {
            CreatedOn = DateTime.Now; ;
            UploadeddOn = DateTime.Now;
        }

        [StringLength(450)]
        public string Caption { get; set; }

        public int FileSize { get; set; }

        [StringLength(450)]
        public string FileName { get; set; }

        public EMediaType MediaType { get; set; }

        public DateTimeOffset CreatedOn { get; set; }

        public DateTimeOffset UploadeddOn { get; set; }
        
    }
}