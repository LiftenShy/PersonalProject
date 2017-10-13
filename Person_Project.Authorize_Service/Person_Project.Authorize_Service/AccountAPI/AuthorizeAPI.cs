using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;
using Person_Project.Authorize_Service.Models;
using Person_Project.Models.EntityModels.AuthModels;
using System.Text;
using System;
using System.Threading;
using Person_Project.Authorize_Service.Service.Implements;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Person_Project.Authorize_Service.AccountAPI
{
    [Route("api/[controller]")]
    public class AuthorizeAPI : Controller
    {
        private readonly CustomUserStore<UserProfile> _customUserStore;

        public AuthorizeAPI()
        {
            _customUserStore = new CustomUserStore<UserProfile>();
        }
        // POST api/LogIn
        [HttpPost]
        public async Task<string> Register([FromBody] UserProfileModel account)
        {
            using (SHA256 sha256 = new SHA256CryptoServiceProvider())
            {
                var result = await _customUserStore.CreateAsync(new UserProfile
                {
                    LoginName = account.LoginName,
                    PasswordHash = sha256.ComputeHash(Encoding.ASCII.GetBytes(account.PasswordHash))
                }, new CancellationToken());


                return JsonConvert.SerializeObject(result.Succeeded ? "Succes" : "Failed");
            }
        }
    }
}
