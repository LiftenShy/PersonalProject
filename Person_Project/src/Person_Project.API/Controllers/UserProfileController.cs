using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Person_Project.API.Models;
using Person_Project.Buisness.Abstract;
using Person_Project.Models.EntityModels.AuthModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Person_Project.API.Controllers
{
    [Route("api/UserProfile")]
    public class UserProfileController : Controller
    {
        private readonly IUserProfileService _userProfileService;

        private IMapper _mapper { get; set; }

        public UserProfileController(IUserProfileService userProfileService, IMapper mapper)
        {
            _userProfileService = userProfileService;
            _mapper = mapper;
        }

        [HttpGet]
        public JsonResult GetAll()
        {
            return new JsonResult(_mapper.Map<List<UserProfile>, List<UserProfileModel>>(_userProfileService.GetAll()));
        }

        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            return new JsonResult(_userProfileService.GetById(id));
        }

        [HttpPost]
        public JsonResult Post([FromBody] UserProfileModel newUserProfile)
        {
            try
            {
                if (newUserProfile != null)
                {
                    var userProfile = new UserProfile { LoginName = newUserProfile.LoginName, PasswordHash = Encoding.ASCII.GetBytes(newUserProfile.Password) };
                    _userProfileService.Insert(userProfile);
                    return new JsonResult("Succsess insert");
                }
                return new JsonResult("user profile is null");
            }
            catch (Exception e)
            {
                return new JsonResult($"{e.Message} : {e.InnerException}");
            }
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]UserProfile newUserProfile)
        {
            _userProfileService.Update(newUserProfile, id);
        }

        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            try
            {
                if (id != 0)
                {
                    _userProfileService.Remove(id);
                    return new JsonResult("Succsess delete");
                }
                return new JsonResult("id is zero");
            }
            catch (Exception e)
            {
                return new JsonResult(e.Message);
            }
        }
    }
}