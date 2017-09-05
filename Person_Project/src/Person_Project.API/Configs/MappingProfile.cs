using System;
using System.Text;
using AutoMapper;
using Person_Project.Api.Models;
using Person_Project.API.Models;
using Person_Project.Models.EntityModels;
using Person_Project.Models.EntityModels.AuthModels;

namespace Person_Project.API.Configs
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Person, PersonModel>();
            CreateMap<PersonModel, Person>();

            CreateMap<UserProfile, UserProfileModel>()
            .ForMember(model => model.Password, upm => upm.MapFrom(up => Encoding.ASCII.GetString(up.PasswordHash)));

            CreateMap<UserProfileModel, UserProfile>();
        }
    }
}
