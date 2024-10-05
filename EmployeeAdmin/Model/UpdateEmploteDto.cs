namespace EmployeeAdmin.Model
{
    public class UpdateEmployeDto
    {
        public required string Name { get; set; }
        public string? Phone { get; set; }
        public Decimal Salary { get; set; }
    }
}
