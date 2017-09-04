using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;
using Person_Project.Authorize_Service.Models;
using Person_Project.Models.EntityModels.AuthModels;
using System.Text;
using System;

namespace Person_Project.Authorize_Service.AccountAPI
{
    [Route("api/[controller]")]
    public class AuthorizeAPI : Controller
    {
        // POST api/LogIn
        [HttpPost]
        public JsonResult Register([FromBody]UserProfileModel account)
        {
            using (SHA256 sha256 = new SHA256CryptoServiceProvider())
            {
                return new JsonResult(new UserProfileModel
                {
                    LoginName = account.LoginName,
                    PasswordHash = Convert.ToBase64String(sha256.ComputeHash(Encoding.ASCII.GetBytes(account.PasswordHash)))
                });
            }
        }
    }
}
