using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project_ASP_CORE_API.Model;

namespace Project_ASP_CORE_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestEmployeeController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<TestEmployeeModel> Get()
        {
            return GetTestEmployees();
        }

        // GET: api/TestEmployeeModel/5
        [HttpGet("{id}", Name = "Get")]
        public TestEmployeeModel Get(int id)
        {
            return GetTestEmployees().Find(e => e.Id == id);
        }
        // POST: api/TestEmployeeModel
        [HttpPost]
        [Produces("application/json")]
        public TestEmployeeModel Post([FromBody] TestEmployeeModel employee)
        {
            // Logic to create new TestEmployeeModel
            return new TestEmployeeModel();
        }
        // PUT: api/TestEmployeeModel/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] TestEmployeeModel employee)
        {
            // Logic to update an TestEmployeeModel
        }
        // DELETE: api/TestEmployeeModel/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        private List<TestEmployeeModel> GetTestEmployees()
        {
            return new List<TestEmployeeModel>()
            {
                new TestEmployeeModel()
                {
                    Id = 1,
                    Name = "a",
                    Address = "abc"
                },
                new TestEmployeeModel()
                {
                    Id = 2,
                    Name = "b",
                    Address = "adc"
                }
            };
        }
    }
}
