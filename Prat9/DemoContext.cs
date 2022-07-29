using Microsoft.EntityFrameworkCore;

namespace Prat9
{
    public class DemoContext:DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           string connectionString="Server=.;Database=CSDEMO;Trusted_Connection=True";
            optionsBuilder.UseSqlServer(connectionString);
        }
        public DbSet<Student> Students { get; set; }
    }
}
