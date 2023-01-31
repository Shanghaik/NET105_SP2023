using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestAPI : ControllerBase
    {
        // GET: api/<TestAPI>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return new List<Student>()
            {
                new Student{Id=Guid.NewGuid(),Name="Khoa"},
                new Student{Id=Guid.NewGuid(),Name="Mạnh"},
                new Student{Id=Guid.NewGuid(),Name="Tiến"},
                new Student{Id=Guid.NewGuid(),Name="Tuấn Anh"},
                new Student{Id=Guid.NewGuid(),Name="Phong"}
            };
        }

        // GET api/<TestAPI>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TestAPI>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TestAPI>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TestAPI>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Student()
        {

        }
    }
}
