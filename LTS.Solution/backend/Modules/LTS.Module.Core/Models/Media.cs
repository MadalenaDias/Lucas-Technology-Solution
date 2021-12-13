using LTSSolution.Infrastructure.Models;
using System;
using System.Collections.Generic;
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

        public string Caption { get; private set; }

        public int FileSize { get; private set; }

        public string FileName { get; private set; }

        public EMediaType MediaType { get; private set; }

        public DateTimeOffset CreatedOn { get; private set; }

        public DateTimeOffset UploadeddOn { get; private set; }
        
    }
}