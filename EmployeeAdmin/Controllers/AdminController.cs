using Microsoft.AspNetCore.Mvc;

namespace EmployeeAdmin.Controllers
{
    public class AdminController : Controller
    {

        [HttpGet]
        public IEnumerable<string> GetAdmin()
        {
            return new[] { "admindata1", "admindata2" };
        }

        [HttpGet]
        public string GetAdminItem(int id)
        {
            return "admindata3";
        }
    }
}
