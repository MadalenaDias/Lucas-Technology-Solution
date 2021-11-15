using System.Threading.Tasks;

namespace LucasTechnologyServices.AppService.Core.Interfaces
{
    public interface IMediaAppService
    {
        string GetMediaUrl(Media media);

        string GetMediaUrl(string fileName);

        string GetThumbnailUrl(Media media);

        Task SaveMediaAsync(Stream mediaBinaryStream, string fileName, string mimeType = null);

        Task DeleteMediaAsync(Media media);

        Task DeleteMediaAsync(string fileName);
         
    }
}