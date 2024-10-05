using Microsoft.AspNetCore.Mvc;

namespace EmployeeAdmin.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IEnumerable<string> GetAll()
        {
            return new[] { "data1", "data2" };
        }

        [HttpGet]
        public string GetItem(int id)
        {
            return "data3";
        }

    }
}
