namespace EmployeeAdmin.Model.Entities
{
    public class Employe
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public string? Phone { get; set; }
        public Decimal Salary { get; set; }
    }
}
