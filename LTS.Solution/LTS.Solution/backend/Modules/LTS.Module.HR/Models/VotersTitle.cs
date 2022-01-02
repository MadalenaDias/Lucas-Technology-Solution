using System;
using LTS.Module.Core.ValueObjects;

namespace LTS.Module.HR.Models
{
    public class VotersTitle : EntityBase
    {
        
        public VotersTitle(long id)
        {
            Id = id;
        }
        
        public string Number { get; set; }
        
        public string Zone { get; set; }
        
        public string Section { get; set; }
        
    }
}