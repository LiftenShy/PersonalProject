﻿using Person_Project.Models.EntityModels.AuthModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Person_Project.Buisness.Abstract
{
    public interface IUserProfileService
    {
        Task<List<UserProfile>> GetAll();
        Task<UserProfile> GetById(int id);
        Task<UserProfile> GetByName(string name);
        Task Update(UserProfile newPerson, int id);
        Task Insert(UserProfile person);
        Task Remove(int id);
    }
}
