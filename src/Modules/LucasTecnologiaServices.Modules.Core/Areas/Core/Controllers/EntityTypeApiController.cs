using LucasTecnologiaServices.Infrastructure.Data;
using LucasTecnologiaServices.Modules.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LucasTecnologiaServices.Modules.Core.Areas.Core.Controllers
{
    [Area("Core")]
    [Authorize(Roles = "admin")]
    [Route("api/entity-types")]
    public class EntityTypeApiController : Controller
    {
        private readonly IRepositoryWithTypedId<EntityType, string> _entityTypeRepository;

        public EntityTypeApiController(IRepositoryWithTypedId<EntityType, string> entityTypeRepository)
        {
            _entityTypeRepository = entityTypeRepository;
        }

        [HttpGet("menuable")]
        public IActionResult GetMenuable()
        {
            var entityTypes = _entityTypeRepository.Query()
                .Where(x => x.IsMenuable)
                .Select(x => new
                {
                    x.Id,
                    x.Name
                });

            return Ok(entityTypes);
        }
    }
}
