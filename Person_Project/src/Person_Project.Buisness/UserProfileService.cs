
using System.Collections.Generic;
using Person_Project.Models.EntityModels.AuthModels;
using Person_Project.Buisness.Abstract;
using Person_Project.Data.Abstract;
using System;
using System.Linq;
using System.Text;

namespace Person_Project.Buisness
{
    public class UserProfileService : IUserProfileService
    {
        private readonly IRepository<UserProfile> _userProfileRepository;

        public UserProfileService(IRepository<UserProfile> userProfileRepository)
        {
            _userProfileRepository = userProfileRepository;
        }

        public List<UserProfile> GetAll()
        {
            return _userProfileRepository.Table.ToList();
        }

        public UserProfile GetById(int id)
        {
            return _userProfileRepository.GetById(id);
        }

        public void Update(UserProfile newPerson, int id)
        {
            var updatePerson = _userProfileRepository.GetById(id);
            updatePerson = newPerson;
            _userProfileRepository.Update(updatePerson);
        }

        public void Insert(UserProfile person)
        {
            if (!_userProfileRepository.Table.Any(p => p.LoginName == person.LoginName))
            {
                _userProfileRepository.Insert(person);
            }
            else
            {
                throw new Exception("Name already have");
            }
        }

        public void Remove(int id)
        {
            if (_userProfileRepository.Table.Any(p => p.Id == id))
            {
                _userProfileRepository.Delete(_userProfileRepository.Table.FirstOrDefault(p => p.Id == id));
            }
            else
            {
                throw new Exception("Don't have user");
            }
        }
    }
}
