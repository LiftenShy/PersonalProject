﻿using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Person_Project.Models.EntityModels.AuthModels;

namespace Person_Project.Authorize_Service.Service.Implements
{
    public class CustomUserStore<TType> : IUserStore<UserProfile>
    {
        public async Task<IdentityResult> CreateAsync(UserProfile user, CancellationToken cancellationToken)
        {
            bool result = await HttpConnector.HttpPostAsJson(user);
            return result ? IdentityResult.Success : IdentityResult.Failed(new IdentityError { Description = $"Can't connect to api service." });
        }

        public Task<IdentityResult> DeleteAsync(UserProfile user, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public Task<UserProfile> FindByIdAsync(string userId, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<UserProfile> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<string> GetNormalizedUserNameAsync(UserProfile user, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<string> GetUserIdAsync(UserProfile user, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<string> GetUserNameAsync(UserProfile user, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task SetNormalizedUserNameAsync(UserProfile user, string normalizedName, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task SetUserNameAsync(UserProfile user, string userName, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<IdentityResult> UpdateAsync(UserProfile user, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
