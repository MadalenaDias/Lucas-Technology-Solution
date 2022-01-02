using System;
using LTS.Module.Core.ValueObjects;

namespace LTS.Module.HR.Models
{
    public class PIS : EntityBase
    {
        public PIS(long id)
        { 
            Id = id;
        }

        public string Number { get; set; }
        
    }
}