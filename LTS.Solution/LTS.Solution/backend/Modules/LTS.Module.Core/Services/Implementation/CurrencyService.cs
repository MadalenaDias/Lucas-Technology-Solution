﻿using LTS.Module.Core.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Module.Core.Services.Implementation
{
    public class CurrencyService : ICurrencyService
    {
        private readonly IConfiguration _config;

        public CurrencyService(IConfiguration config)
        {
            _config = config;
            var currencyCulture = _config.GetValue<string>("Global.CurrencyCulture");
            CurrencyCulture = new CultureInfo(currencyCulture);
        }

        public CultureInfo CurrencyCulture { get; }

        public string FormatCurrency(decimal value)
        {
            var decimalPlace = _config.GetValue<int>("Global.CurrencyDecimalPlace");
            return value.ToString($"C{decimalPlace}", CurrencyCulture);
        }
    }
}
