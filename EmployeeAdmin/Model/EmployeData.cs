namespace EmployeeAdmin.Model.Entities
{
    public class EmployeData
    {
        public required string Name { get; set; }
        public string? Phone { get; set; }
        public Decimal Salary { get; set; }
    }
}
