using Microsoft.EntityFrameworkCore;
using WebApI.Models;

namespace WebApI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Department>? Departments { get; set; }
        public DbSet<Employee>? Employees { get; set; }

    }
}
