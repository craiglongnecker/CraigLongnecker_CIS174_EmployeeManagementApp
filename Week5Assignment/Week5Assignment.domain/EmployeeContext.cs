using System.Data.Entity;
using Week5Assignment.domain.Entities;

namespace Week5Assignment.domain
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<ErrorLog> ErrorLogs { get; set; }
    }
}
