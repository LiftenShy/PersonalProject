using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Threading;
using SocialMusic.Authorize.Models;
using System;
using Microsoft.AspNetCore.Identity;
using SocialMusic.Models.EntityModels.AuthModels;
using Microsoft.Extensions.Options;
using SocialMusic.Authorize.Service.Settings;
using SocialMusic.Authorize.Service.Interfaces;
using AutoMapper;

namespace SocialMusic.Authorize.AccountAPI
{
    [Route("api/[controller]")]
    public class AuthorizeAPI : Controller
    {
        private readonly IUserStore<UserProfile> _userStore;
        private readonly IOptions<AppSettings> _appSettings;
        private readonly ITokenService _tokenService;
        private readonly IMapper _mapper;

        public AuthorizeAPI(
            IUserStore<UserProfile> userStore,
            IOptions<AppSettings> appSettings,
            ITokenService tokenService,
            IMapper mapper)
        {
            _userStore = userStore;
            _appSettings = appSettings;
            _tokenService = tokenService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> SignInAsync([FromBody] UserProfileModel account)
        {
            try
            {
                var user = _mapper.Map<UserProfileModel, UserProfile>(account);

                var result = await _userStore.CreateAsync(user, new CancellationToken());

                if (result.Succeeded)
                {
                    _tokenService.Authorize(user);
                    return Ok();
                }

                return BadRequest($"User with this name:{user.LoginName} already have");

            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
