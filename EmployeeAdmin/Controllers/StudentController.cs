using EmployeeAdmin.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace EmployeeAdmin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        [Route("All")]
        public string Getdata()
        {
            return "data";
        }

        [HttpGet]
        [Route("Getdetails")]
        public Student Getdetails()
        {
            return new Student
            {
                Id = 1,
                Name = "Test"
            };
        }

        [HttpGet]
        [Route("GetListdetails")]
        public List<Student> GetListdetails()
        {
            return new List<Student>()
            {
                new Student{Id = 1, Name = "Test"},
                new Student{Id=2, Name = "Test2"}
            };
        }

        [HttpGet]
        [Route("GetListdata")]
        public IEnumerable<Student> GetListdata()
        {
            return new List<Student>()
            {
                new Student{Id = 1, Name = "Test"},
                new Student{Id=2, Name = "Test2"}
            };
        }

        [HttpGet]
        [Route("GetAll")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Student>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetAll()
        {
            try
            {
                var listdata = new List<Student>()
            {
                new Student{Id = 1, Name = "Test"},
                new Student{Id=2, Name = "Test2"}
            };
                if (listdata.Count > 0)
                {
                    
                    return Ok(listdata);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(Convert.ToInt32(HttpStatusCode.InternalServerError), ex.Message);
            }

        }

        //2xx  200,204,201,202
        //4xx  404,400,401,403
        //5xx  500,502,504,503


        [HttpGet]
        [Route("GetAlldata")]
        public async Task<ActionResult<List<Student>>> GetAlldata()
        {
            try
            {
                var listdata = new List<Student>()
            {
                new Student{Id = 1, Name = "Test"},
                new Student{Id=2, Name = "Test2"}
            };
                if (listdata.Count > 0)
                {  
                    await Task.Delay(TimeSpan.FromSeconds(1));
                    return NoContent();
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
               return StatusCode(500, ex.Message);
            }
            
        }


        

        



    }
}
