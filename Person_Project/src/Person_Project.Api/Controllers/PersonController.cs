using System;
using Microsoft.AspNetCore.Mvc;
using Person_Project.Business.Abstract;
using Person_Project.Models.EntityModels;

namespace Person_Project.API.Controllers
{
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        public JsonResult GetAll()
        {
            return new JsonResult(_personService.GetAll());
        }

        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            return new JsonResult(_personService.GetById(id));
        }

        [HttpPost]
        public JsonResult Post([FromBody] Person person)
        {
            try
            {
                if (person != null)
                {
                    _personService.Insert(person);
                    return new JsonResult("Succsess insert");
                }
                return new JsonResult("person is null");
            }
            catch (Exception e)
            {
                return new JsonResult(e.Message);
            }
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Person newPerson)
        {
            _personService.Update(newPerson, id);
        }

        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            try
            {
                if (id != 0)
                {
                    _personService.Remove(id);
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
