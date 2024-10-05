using EmployeeAdmin.Data;
using EmployeeAdmin.Model;
using EmployeeAdmin.Model.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EmployeeAdmin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly AppDbContext dbContext;

        public EmployeeController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]       
        public IActionResult GetEmplyeeData()
        {
          var employeData =  dbContext.Employees.ToList();
            if(employeData.Count > 0 )
            { 
                return Ok(employeData); 
            }
            else
            {
                return NotFound();
            }          
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetSingleEmployees(Guid id)
        {

            var dataResult = dbContext.Employees.Find(id);
            if(dataResult is null)
            {
                return NotFound();
            }
            else
            {
               return Ok(dataResult);
            }
        }

        [HttpPost]
        public IActionResult InsertEmployee(EmployeeDto employeeDto)
        {
            try
            {
                var data = new EmployeData()
                {
                    Name = employeeDto.Name,
                    Phone = employeeDto.Phone,
                    Salary = employeeDto.Salary
                };
                
                dbContext.Employees.Add(data);
                dbContext.SaveChanges();
                return Ok(data);
            }
            catch (Exception ex)
            { 
                return StatusCode(500, ex.Message);
            }

            
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult PutEmployee(Guid id, UpdateEmployeDto employeDto)
        {
            var employee = dbContext.Employees.Find(id);
            if (employee is null)
            {
                return NotFound();
            }

            employee.Name = employeDto.Name;
            employee.Phone = employeDto.Phone;
            employee.Salary = employeDto.Salary;

            dbContext.SaveChanges();
            return Ok(employee);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteEmployee(Guid id)
        {
            var employee = dbContext.Employees.Find(id);
            if (employee is null)
            {
                return NotFound();
            }

            dbContext.Employees.Remove(employee);
            dbContext.SaveChanges();
            return Ok(employee);
        }
       
    }
}
