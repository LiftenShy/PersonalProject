

using System;
using Microsoft.AspNetCore.Mvc;
using Person_Project.Business.Abstract;
using Person_Project.Data.Model;

namespace Person_Project.Api.Controllers
{
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        // GET api/Persons
        [HttpGet]
        public JsonResult GetAll()
        {
            return new JsonResult(_personService.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            return new JsonResult(_personService.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public JsonResult Post([FromBody] Person person)
        {
            try
            {
                if(person!=null)
                {
                    _personService.Insert(person);
                    return new JsonResult("Succsess insert");
                }
                return new JsonResult("person is null");
            }
            catch(Exception e)
            {
                return new JsonResult(e.Message);
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Person newPerson)
        {
            _personService.Update(newPerson,id);
        }

        // DELETE api/values/5
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
