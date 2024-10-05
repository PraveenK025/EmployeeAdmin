namespace EmployeeAdmin.Model
{
    public class EmployeeDto
    {
        public required string Name { get; set; }
        public string? Phone { get; set; }
        public Decimal Salary { get; set; }
    }
}
