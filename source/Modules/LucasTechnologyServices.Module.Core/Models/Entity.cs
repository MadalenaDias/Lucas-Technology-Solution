using System;
namespace LucasTechnologyServices.Module.Core.Models
{
    public abstract class Entity
    {


        public Entity(Parameters)
        {
            Id = Guid.NewGuid();
            
        }
        
        
        public Guid Id { get; private set; }
        
    }
}