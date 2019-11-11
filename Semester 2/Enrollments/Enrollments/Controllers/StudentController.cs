using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Enrollments.Models;
using System.Data.SqlClient;

namespace Enrollments.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {        
        // GET: api/Student
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            List<Student> students = new List<Student>();
            List<Subject> subjects = new List<Subject>();
            SqlConnection connection = new SqlConnection("Server=tcp:civapi.database.windows.net,1433;Initial Catalog=civapi;User ID=civ_user;Password=Monday1330;");
            string query = "Select * from Student";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader result = command.ExecuteReader();
            while (result.Read())
            {
                students.Add(new Student(int.Parse(result[0].ToString()), result[1].ToString(), result[2].ToString()));
            }
            connection.Close();

            query = "Select * from Subject";
            command = new SqlCommand(query, connection);
            connection.Open();
            result = command.ExecuteReader();
            while (result.Read())
            {
                subjects.Add(new Subject(int.Parse(result[0].ToString()), result[1].ToString(), result[2].ToString()));
            }
            connection.Close();

            query = "Select * from Enrollment";
            command = new SqlCommand(query, connection);
            connection.Open();
            result = command.ExecuteReader();
            while (result.Read())
            {
                int studentid = int.Parse(result[0].ToString());
                int corseid = int.Parse(result[1].ToString());
                for(int student = 0; student < students.Count; student++)
                {
                    if(students[student].ID == studentid)
                    {
                        for (int subject = 0; subject < subjects.Count; subject++)
                        {
                            if(subjects[subject].Code == corseid)
                            {
                                students[student].Subjects.Add(subjects[subject]);
                            }
                        }
                    }
                }
            }
            connection.Close();

            return students;
        }

        // GET: api/Student/5
        [HttpGet("{id}", Name = "GetStudent")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Student
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Student/5
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
