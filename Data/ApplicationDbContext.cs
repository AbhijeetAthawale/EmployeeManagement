using Employee_Management.Models;
using Employee_Management.Models.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Employee_Management.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext( DbContextOptions<ApplicationDbContext> options ) : base( options )
        {
            
        }

        /*public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }*/

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Users> Users { get; set; }
    }

    /*public class AppDbContext : IdentityDbContext<Users>
    {
        public AppDbContext(DbContextOptions options): base( options ) 
        {
                
        }
    }*/
}
