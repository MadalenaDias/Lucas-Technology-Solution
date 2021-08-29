namespace LucasTechnologyService.Infrastructure.Models
{
    public abstract class EntityBaseWithTypedId<TId>: ValidatableObject, IEntityWithTypdId<TId>
    {
        public virtual TId Id { get; protected set; }
        
    }
}