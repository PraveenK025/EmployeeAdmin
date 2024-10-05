using EmployeeAdmin.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdmin.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
                
        }
      public DbSet<EmployeData> Employees { get; set; }
    }
}
