using Microsoft.AspNetCore.Mvc;
using Person_Project.Authorize_Service.Data.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Person_Project.Authorize_Service.ViewModels;

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
        public async Task Register([FromBody]UserProfileModel account)
        {
            UserProfile up = new UserProfile { LoginName = account.LoginName };

            var result = await _userManager.CreateAsync(up, account.PasswordHash);
        }

        // PUT api/LogOff
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
    }
}
