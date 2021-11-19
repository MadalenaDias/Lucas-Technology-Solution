using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD:LTS.Solution/Adapters/Driven/Core/LTS.Infra.Core.Data/Models/EntityBaseWithTypedId.cs
namespace LTS.Infra.Core.Data.Models
=======
namespace LucasTechnologyService.Infrastructure.Models
>>>>>>> origin/dev:source/Infrastructure/LucasTechnologyService.Infrastructure/Models/EntityBaseWithTypedId.cs
{
    public abstract class EntityBaseWithTypedId<TId> : ValidatableObject, IEntityWithTypedId<TId>
    {
        public virtual TId Id { get; protected set; }
    }
}
