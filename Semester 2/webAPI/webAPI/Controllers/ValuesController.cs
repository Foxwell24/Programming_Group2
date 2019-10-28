using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webAPI.Models;

namespace webAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        List<Horse> MockDB = new List<Horse> {
            new Horse("PharLap", "Red"),
            new Horse("Potatooo", "Blue"),
            new Horse("Cold", "Oranger"),
            new Horse("Bob", "Peache"),
            new Horse("Joe", "color")
        };

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Horse>> Get()
        {
            return MockDB.ToArray();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Horse> Get(int id)
        {
            return MockDB[id];
        }

        // POST api/values
        [HttpPost]
        public ActionResult<string> Post([FromBody] Horse value)
        {
            MockDB.Add(value);
            return $"{value.name} added";
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
