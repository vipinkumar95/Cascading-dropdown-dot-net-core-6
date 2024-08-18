using Microsoft.EntityFrameworkCore;


namespace Cascading_dropdown.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base (options)
        
        { }
        
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; } 
        public DbSet<State> States { get; set; }
        public DbSet<Customer> Customers { get; set; }
       
    }
}
