using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace school.Models
{
    public class AuthenticationContext : IdentityDbContext
    { 
        public AuthenticationContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<User> User { get; set; }
    }

}