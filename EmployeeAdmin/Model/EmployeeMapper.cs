using System.Net;

namespace EmployeeAdmin.Model
{
    public class EmployeeMapper
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Address? Address { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
    } 
}
