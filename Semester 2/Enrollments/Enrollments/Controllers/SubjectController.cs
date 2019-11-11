using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Enrollments.Models;

namespace Enrollments.Controllers
{    
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        List<Subject> subjects = new List<Subject>
        {
            new Subject(1111, "Maths", "Yes"),
            new Subject(2222, "latin", "Yes")
        };
        // GET: api/Subject
        [HttpGet]
        public IEnumerable<Subject> Get()
        {
            return subjects;
        }

        // GET: api/Subject/5
        [HttpGet("{id}", Name = "GetSubject")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Subject
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Subject/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
