using System;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Person_Project.Authorize_Service.Models;
using Person_Project.Models.EntityModels.AuthModels;

namespace Person_Project.Authorize_Service.AccountAPI
{
    [Route("api/[controller]")]
    public class AuthorizeAPI : Controller
    {
        private readonly UserManager<UserProfile> _userManager;
        private readonly SignInManager<UserProfile> _signInManager;

        public AuthorizeAPI(UserManager<UserProfile> userManager, SignInManager<UserProfile> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        // POST api/LogIn
        [HttpPost]
        public JsonResult Register([FromBody]UserProfileModel account)
        {
            using (SHA256 sha256 = new SHA256CryptoServiceProvider())
            {
                return new JsonResult(new UserProfile
                {
                    LoginName = "sergey",
                    PasswordHash = sha256.ComputeHash(Convert.FromBase64String(account.PasswordHash))
                });
            }
        }
    }
}
