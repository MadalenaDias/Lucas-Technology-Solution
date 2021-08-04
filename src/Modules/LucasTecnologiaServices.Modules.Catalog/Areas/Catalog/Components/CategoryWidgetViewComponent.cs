using LucasTecnologiaServices.Infrastructure.Data;
using LucasTecnologiaServices.Infrastructure.Web;
using LucasTecnologiaServices.Modules.Catalog.Areas.Catalog.ViewModels;
using LucasTecnologiaServices.Modules.Catalog.Models;
using LucasTecnologiaServices.Modules.Core.Areas.ViewModels;
using LucasTecnologiaServices.Modules.Core.Models;
using LucasTecnologiaServices.Modules.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Catalog.Areas.Catalog.Components
{
    public class CategoryWidgetViewComponent : ViewComponent
    {
        private readonly IRepository<Category> _categoriesRepository;
        private readonly IMediaService _mediaService;
        private readonly IContentLocalizationService _contentLocalizationService;

        public CategoryWidgetViewComponent(IRepository<Category> categoriesRepository, IMediaService mediaService, IContentLocalizationService contentLocalizationService)
        {
            _categoriesRepository = categoriesRepository;
            _mediaService = mediaService;
            _contentLocalizationService = contentLocalizationService;
        }

        public IViewComponentResult Invoke(WidgetInstanceViewModel widgetInstance)
        {
            var model = new CategoryWidgetComponentVm()
            {
                Id = widgetInstance.Id,
                WidgetName = _contentLocalizationService.GetLocalizedProperty(nameof(WidgetInstance), widgetInstance.Id, nameof(widgetInstance.Name), widgetInstance.Name),
            };
            var settings = JsonConvert.DeserializeObject<CategoryWidgetSettings>(widgetInstance.Data);
            if (settings != null)
            {
                var category = _categoriesRepository.Query()
                    .Include(c => c.ThumbnailImage)
                    .FirstOrDefault(c => c.Id == settings.CategoryId);
                model.Category = new CategoryThumbnail()
                {
                    Id = category.Id,
                    Description = category.Description,
                    Name = category.Name,
                    Slug = category.Slug,
                    ThumbnailImage = category.ThumbnailImage,
                    ThumbnailUrl = _mediaService.GetThumbnailUrl(category.ThumbnailImage)
                };
            }

            return View(this.GetViewPath(), model);
        }
    }
}
