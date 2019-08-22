using Microsoft.EntityFrameworkCore;

namespace school.Models
{
    public class TeacherContext : DbContext
    {
        public TeacherContext(DbContextOptions<TeacherContext> options)
            : base(options)
        {
        }

        public DbSet<Teacher> Teacher { get; set; }
    }
}