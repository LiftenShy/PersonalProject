using System.Net.Http;
using System.Threading.Tasks;
using SocialMusic.Models.EntityModels.BaseModels;

namespace SocialMusic.Authorize.Service.Interfaces
{
    public interface IConnector<T>
        where T : BaseEntity
    {
        Task<HttpResponseMessage> Get(string requestUri);

        Task<HttpResponseMessage> Post(string requestUri, T value);

        Task<HttpResponseMessage> Put(string requestUri, T value);

        Task<HttpResponseMessage> Patch(string requestUri, T value);

        Task<HttpResponseMessage> Delete(string requestUri);
    }
}
