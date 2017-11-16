using Microsoft.AspNetCore.Mvc;
using Person_Project.Models.EntityModels.AuthModels;
using System.Threading.Tasks;
using System.Threading;
using Person_Project.Authorize_Service.Models;
using Newtonsoft.Json;
using System;
using Person_Project.Authorize_Service.Helper;
using Microsoft.AspNetCore.Identity;

namespace Person_Project.Authorize_Service.AccountAPI
{
    [Route("api/[controller]")]
    public class AuthorizeAPI : Controller
    {
        private readonly IUserStore<UserProfile> _userStore;

        public AuthorizeAPI(IUserStore<UserProfile> userStore)
        {
            _userStore = userStore;
        }

        [HttpPost]
        public async Task<string> Register([FromBody] UserProfileModel account)
        {
            try
            {
                var result = await _userStore.CreateAsync(new UserProfile
                {
                    LoginName = account.LoginName,
                    PasswordHash = CryptoService.Crypto(account.Password)
                }, new CancellationToken());


                return JsonConvert.SerializeObject(result.Succeeded ? "Succes" : "Failed");
            }
            catch(Exception e)
            {
                return JsonConvert.SerializeObject(e.Message);
            }
        }
    }
}
