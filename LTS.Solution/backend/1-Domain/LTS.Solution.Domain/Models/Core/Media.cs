using LTSSolution.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Solution.Domain.Models.Core
{
    public class Media : EntityBase
    {
        public Media(DateTimeOffset createdOn, DateTimeOffset uploadeddOn)
        {
            CreatedOn = DateTime.Now;;
            UploadeddOn = DateTime.Now;
        }

        public string Caption { get; private set; }

        public int FileSize { get; private set; }

        public string FileName { get; private set; }

        public MediaType MediaType { get; private set; }

        public DateTimeOffset CreatedOn {get; private set; }

        public DateTimeOffset UploadeddOn {get; private set; } 
    }
}
