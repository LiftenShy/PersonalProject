using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Person_Project.Data.Model;

namespace Person_Project.Business.Abstract
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
