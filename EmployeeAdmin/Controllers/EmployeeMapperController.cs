using AutoMapper;
using EmployeeAdmin.GenericFunction;
using EmployeeAdmin.Model;
using EmployeeAdmin.Model.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAdmin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeMapperController : ControllerBase
    {
        private readonly IMapper _mapper;

        public EmployeeMapperController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<List<EmployeeMapperDTO>> GetEmployeeMapper()
        {
            List<EmployeeMapperDTO> employees = _mapper.Map<List<EmployeeMapperDTO>>(GetData.GetEmployeeData());
            //var EmployeeList = GetData.GetEmployeeData();
            //foreach (var employee in EmployeeList)
            //{
            //    EmployeeMapperDTO emp = new EmployeeMapperDTO()
            //    {
            //        Id = employee.Id,
            //        Name = employee.Name,
            //        Age = employee.Age,
            //        Gender = employee.Gender,
            //        Email = employee.Email,
            //    };
            //    employees.Add(emp);
            //}
            return Ok(employees);

        }

       
    }
}
