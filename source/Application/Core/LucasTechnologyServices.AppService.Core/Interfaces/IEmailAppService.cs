using System.Threading.Tasks;

namespace LucasTechnologyServices.AppService.Core.Interfaces
{
    public interface IEmailAppService
    {
        Task SendEmailAsync(string email, string subject, string message, bool isHtml = false);
         
    }
}