using Microsoft.EntityFrameworkCore;
using Project_OOP.Entity;

namespace Project_OOP.ProjectContext
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB; database=DbNewOOPCore; integrated security=true;");
        }

        public DbSet<Product> products { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Category> categories { get; set; }

    }
}
