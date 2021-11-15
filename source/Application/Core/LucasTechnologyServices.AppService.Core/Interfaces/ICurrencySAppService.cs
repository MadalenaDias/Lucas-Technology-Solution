using System.Globalization;

namespace LucasTechnologyServices.AppService.Core.Interfaces
{
    public interface ICurrencySAppService
    {
        CultureInfo CurrencyCulture { get; }
        string FormatCurrency(decimal value);
         
    }
}