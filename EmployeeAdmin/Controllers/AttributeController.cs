using Microsoft.AspNetCore.Mvc;

namespace EmployeeAdmin.Controllers
{
    [ApiController]
    public class AttributeController : Controller
    {
        [HttpGet]
        [Route("api/Getdata")]
        public IEnumerable<string> GetAll()
        {
            return new[] { "data1", "data2" };
        }

        [HttpGet]
        [Route("api/Getitem/{id}")]
        public string GetItem(int id)
        {
            return "data3";
        }
    }
}
