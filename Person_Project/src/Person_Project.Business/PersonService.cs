
using System;
using System.Collections.Generic;
using Person_Project.Business.Abstract;
using Person_Project.Data.Model;
using Person_Project.Data.Abstract;
using System.Linq;

namespace Person_Project.Business
{
    public class PersonService : IPersonService
    {
        private readonly IRepository<Person> _personRepository;

        public PersonService(IRepository<Person> persoRepository)
        {
            _personRepository = persoRepository;
        }

        public List<Person> GetAll()
        {
            return _personRepository.Table.ToList();
        }

        public Person GetById(int id)
        {
            return _personRepository.GetById(id);
        }

        public void Update(Person newPerson, int id)
        {
            var updatePerson = _personRepository.GetById(id);
            updatePerson = newPerson;
            _personRepository.Update(updatePerson);
        }

        public void Insert(Person person)
        {
            if (!_personRepository.Table.Any(p => p.Name == person.Name))
            {
                _personRepository.Insert(person);
            }
            else
            {
               throw new Exception("Name already have");
            }
        }

        public void Remove(int id)
        {
            if (_personRepository.Table.Any(p => p.Id == id))
            {
                _personRepository.Delete(_personRepository.Table.FirstOrDefault(p => p.Id == id));
            }
            else
            {
                throw new Exception("Don't have user");
            }
        }
    }
}
