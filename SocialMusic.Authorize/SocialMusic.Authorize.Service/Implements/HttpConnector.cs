
using Microsoft.Extensions.Options;
using SocialMusic.Authorize.Service.Interfaces;
using SocialMusic.Authorize.Service.Settings;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace SocialMusic.Authorize.Service.Implements
{
    public class HttpConnector<T> : IConnector<T>
        where T : class
    {
        private static AppSettings _appSettings;

        public HttpConnector(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        public async Task<bool> PostAsJson(T model)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.PostAsJsonAsync(new Uri(_appSettings.API.UserProfileURLs.Post), model);
                    response.EnsureSuccessStatusCode();
                    return true;
                }
            }
            catch(HttpRequestException)
            {
                return false;
            }
        }
    }
}
