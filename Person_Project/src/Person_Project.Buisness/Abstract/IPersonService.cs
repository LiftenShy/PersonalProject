﻿using Person_Project.Models.EntityModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Person_Project.Buisness.Abstract
{
    public interface IPersonService
    {
        Task<List<Person>> GetAll();
        Task<Person> GetById(int id);
        Task<Person> GetByName(string name);
        Task Update(Person newPerson, int id);
        Task Insert(Person person);
        Task Remove(int id);
    }
}
