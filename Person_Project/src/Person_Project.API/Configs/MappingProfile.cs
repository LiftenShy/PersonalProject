using System;
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
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<UserProfile, UserProfileModel>();
            });
            CreateMap<Person, PersonModel>();
            CreateMap<PersonModel, Person>();
            CreateMap<UserProfileModel, UserProfile>();
        }
    }
}
