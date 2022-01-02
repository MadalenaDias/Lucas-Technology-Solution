using System;
using LTS.Module.Core.ValueObjects;

namespace LTS.Module.HR.Models
{
    public class RelativeDegreeModel
    {
        public RelativeDegreeModel(long id)
        {
            Id = id;
        }

        public string Description { get; set; }
    }
}