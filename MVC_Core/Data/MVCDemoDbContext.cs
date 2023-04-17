using Microsoft.EntityFrameworkCore;
using MVC_Core.Models.Domain;

namespace MVC_Core.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
