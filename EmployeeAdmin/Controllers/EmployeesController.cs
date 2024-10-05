using EmployeeAdmin.Model.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAdmin.Controllers
{
    public class EmployeesController : Controller
    {
        [HttpGet]
        [Route("Employees/{id:int}")]
        public string GetEmployeById(int id)
        {

            return $"Employe id is :{id}";

        }

        [HttpGet]
        [Route("Employees/Gender/{gender}/City/{cityid}")]
        public string GetEmployeByGenderAndCity(string gender, int cityid)
        {

            return $"Employe gender is :{gender} , city : {cityid}";

        }


        [HttpGet]
        [Route("Employees/Search")]
        public string GetEmployeSearch(string department, string gender)
        {

            return $"Employe department is :{department} gender {gender}";

        }


        [HttpGet]
        [Route("Employees/All")]
        public string GetEmployeData()
        {

            return $"Employe data";

        }     


    }
}
