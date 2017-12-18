using SocialMusic.Authorize.Service.Implements.Helper;
using SocialMusic.Authorize.Service.Interfaces;
using SocialMusic.Models.EntityModels.BaseModels;
using System.Net.Http;
using System.Threading.Tasks;

namespace SocialMusic.Authorize.Service.Implements
{
    public class HttpRequestFactory<T> : IConnector<T>
        where T : BaseEntity
    {
        public async Task<HttpResponseMessage> Get(string requestUri)
        {
            var builder = new HttpRequestBuilder()
                                .AddMethod(HttpMethod.Get)
                                .AddRequestUri(requestUri);

            return await builder.SendAsync();
        }

        public async Task<HttpResponseMessage> Post(string requestUri, T value)
        {
            var builder = new HttpRequestBuilder()
                                .AddMethod(HttpMethod.Post)
                                .AddRequestUri(requestUri)
                                .AddContent(new JsonContent(value));

            return await builder.SendAsync();
        }

        public async Task<HttpResponseMessage> Put(string requestUri, T value)
        {
            var builder = new HttpRequestBuilder()
                                .AddMethod(HttpMethod.Put)
                                .AddRequestUri(requestUri)
                                .AddContent(new JsonContent(value));

            return await builder.SendAsync();
        }

        public async Task<HttpResponseMessage> Patch(string requestUri, T value)
        {
            var builder = new HttpRequestBuilder()
                                .AddMethod(new HttpMethod("PATCH"))
                                .AddRequestUri(requestUri)
                                .AddContent(new PatchContent(value));

            return await builder.SendAsync();
        }

        public async Task<HttpResponseMessage> Delete(string requestUri)
        {
            var builder = new HttpRequestBuilder()
                                .AddMethod(HttpMethod.Delete)
                                .AddRequestUri(requestUri);

            return await builder.SendAsync();
        }
    }
}
