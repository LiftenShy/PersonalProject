using Person_Project.Models.EntityModels;
using System.Collections.Generic;

namespace Person_Project.Buisness.Abstract
{
    public interface IPersonService
    {
        List<Person> GetAll();
        Person GetById(int id);
        void Update(Person person,int id);
        void Insert(Person person);
        void Remove(int id);
    }
}
