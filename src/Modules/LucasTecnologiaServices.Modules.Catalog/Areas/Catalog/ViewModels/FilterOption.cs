﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Catalog.Areas.Catalog.ViewModels
{
    public class FilterOption
    {
        public IList<FilterBrand> Brands { get; set; } = new List<FilterBrand>();

        public IList<FilterCategory> Categories { get; set; } = new List<FilterCategory>();

        public FilterPrice Price { get; set; } = new FilterPrice();
    }
}