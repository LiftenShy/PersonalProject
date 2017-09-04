using Person_Project.Models.EntityModels.AuthModels;
using System.Collections.Generic;

namespace Person_Project.Buisness.Abstract
{
    public interface IUserProfileService
    {
        List<UserProfile> GetAll();
        UserProfile GetById(int id);
        void Update(UserProfile userProfile, int id);
        void Insert(UserProfile userProfile);
        void Remove(int id);
    }
}
