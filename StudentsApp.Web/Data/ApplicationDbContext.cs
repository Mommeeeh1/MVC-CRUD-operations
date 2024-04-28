using Microsoft.EntityFrameworkCore;
using StudentsApp.Web.Models.Entities;

namespace StudentsApp.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
               
        }

        public DbSet<Student> Students { get; set; }
    }
}
