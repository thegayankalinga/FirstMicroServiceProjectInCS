using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentAdmissionManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAdmissionController : ControllerBase
    {
        // GET: api/<StudentAdmissionController>
        [HttpGet]
        public IEnumerable<StudentAdmissionModel> Get()
        {
            StudentAdmissionModel modelOne = new StudentAdmissionModel();
            StudentAdmissionModel modelTwo = new StudentAdmissionModel();

            modelOne.StudentID = 1;
            modelOne.StudentName = "Gayan";
            modelOne.StudentClass = "X";
            modelOne.DateOfJoining = DateTime.Now;


            modelTwo.StudentID = 2;
            modelOne.StudentName = "Dulashi";
            modelOne.StudentClass = "IX";
            modelOne.DateOfJoining = DateTime.Now;

            List<StudentAdmissionModel> listOfAdmission = new List<StudentAdmissionModel>
            {
                modelOne, modelTwo
            };

            return listOfAdmission;

        }

        // GET api/<StudentAdmissionController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StudentAdmissionController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StudentAdmissionController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentAdmissionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
