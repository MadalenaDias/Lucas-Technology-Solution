namespace LucasTechnologyServices.AppService.Core.Interfaces
{
    public interface IPdfConvertAppService
    {
        byte[] Convert(string htmlContent);
         
    }
}