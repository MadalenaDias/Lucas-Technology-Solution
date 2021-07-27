using LucasTecnologiaServices.Infrastructure.Data;
using LucasTecnologiaServices.Infrastructure.Web;
using LucasTecnologiaServices.Modules.Core.Areas.Core.ViewModels;
using LucasTecnologiaServices.Modules.Core.Areas.ViewModels.Manage;
using LucasTecnologiaServices.Modules.Core.Extensions;
using LucasTecnologiaServices.Modules.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Core.Areas.Core.Componets
{
    public class DefaultShippingAddressViewComponent : ViewComponent
    {

        private readonly IRepository<UserAddress> _userAddressRepository;
        private readonly IWorkContext _workContext;

        public DefaultShippingAddressViewComponent(IRepository<UserAddress> userAddressRepository, IWorkContext workContext)
        {
            _userAddressRepository = userAddressRepository;
            _workContext = workContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var curentUser = await _workContext.GetCurrentUser();

            var model = new DefaultAddressViewComponentVm();

            if (curentUser.DefaultShippingAddressId.HasValue)
            {
                model.Address = await _userAddressRepository.Query()
                    .Where(x => x.Id == curentUser.DefaultShippingAddressId.Value)
                    .Select(x => new UserAddressListItem
                    {
                        UserAddressId = x.Id,
                        ContactName = x.Address.ContactName,
                        Phone = x.Address.Phone,
                        AddressLine1 = x.Address.AddressLine1,
                        AddressLine2 = x.Address.AddressLine2,
                        DistrictName = x.Address.District.Name,
                        StateOrProvinceName = x.Address.StateOrProvince.Name,
                        CountryName = x.Address.Country.Name
                    })
                    .FirstOrDefaultAsync();
            }

            return View(this.GetViewPath(), model);
        }
    }
}
