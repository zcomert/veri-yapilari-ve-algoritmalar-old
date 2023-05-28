using EmployeeApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeApp.Repository
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : 
            base(options)
        {
            
        }
    }
}
