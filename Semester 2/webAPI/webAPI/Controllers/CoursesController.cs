using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace webAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        // GET: api/Courses
        [HttpGet]
        public ActionResult<string> Get()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString =
                "Data Source=db.swinswd.com; Initial Catalog=anguyen; User id=anguyen; Password=&hKqe508";
            connection.Open();

            return connection.State.ToString();
        }

        // GET: api/Courses/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Courses
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Courses/5
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
