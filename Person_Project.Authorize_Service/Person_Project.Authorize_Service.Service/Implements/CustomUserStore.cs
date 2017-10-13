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
        public Task<IdentityResult> CreateAsync(TUser user, CancellationToken cancellationToken)
        {
            
        }

        public Task<IdentityResult> DeleteAsync(TUser user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<TUser> FindByIdAsync(string userId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<TUser> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
        {
            return Task.Factory.StartNew(() => users.FirstOrDefault(u => u.LoginName.ToUpper().Contains(normalizedUserName)));
        }

        public Task<string> GetNormalizedUserNameAsync(TUser user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetUserIdAsync(TUser user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetUserNameAsync(TUser user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task SetNormalizedUserNameAsync(TUser user, string normalizedName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task SetUserNameAsync(TUser user, string userName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> UpdateAsync(TUser user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
