using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Person_Project.Models.EntityModels.AuthModels;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System;
using Newtonsoft.Json;

namespace Person_Project.Authorize_Service.Service.Implements
{
    public class CustomUserStore<TUser> : IUserStore<TUser> where TUser : UserProfile
    {
        List<TUser> users = new List<TUser>();

        public Task<IdentityResult> CreateAsync(TUser user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentException(nameof(user));
            using (var client = new HttpClient())
            {
                try
                {
                    if (client == null) { throw new ArgumentException(nameof(client)); }
                    client.PostAsync(@"http://localhost:52350/api/UserProfile", new StringContent(JsonConvert.SerializeObject(user)));
                    return Task.Factory.StartNew(() => IdentityResult.Success);
                }
                catch (HttpRequestException htpre)
                {
                    return Task.Factory.StartNew(() => IdentityResult.Failed(
                        new IdentityError
                        {
                            Description = $"Exception: {htpre.Message} Date: {htpre.Data}."
                        }));
                }
            }
        }

        public Task<IdentityResult> DeleteAsync(TUser user, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public Task<TUser> FindByIdAsync(string userId, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<TUser> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
        {
            return Task.Factory.StartNew(() => users.FirstOrDefault(u => u.LoginName.ToUpper().Contains(normalizedUserName)));
        }

        public Task<string> GetNormalizedUserNameAsync(TUser user, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<string> GetUserIdAsync(TUser user, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<string> GetUserNameAsync(TUser user, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task SetNormalizedUserNameAsync(TUser user, string normalizedName, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task SetUserNameAsync(TUser user, string userName, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<IdentityResult> UpdateAsync(TUser user, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
