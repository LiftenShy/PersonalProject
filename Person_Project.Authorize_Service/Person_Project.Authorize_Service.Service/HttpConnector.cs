
using Person_Project.Models.EntityModels.AuthModels;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Person_Project.Authorize_Service.Service
{
    internal class HttpConnector
    {
        private readonly AppSettings appSettings;

        public static async Task<bool> HttpPostAsJson(UserProfile model)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.PostAsJsonAsync(new Uri(), model);
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
