using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Students.Models
{
    public class StudentDbContext : IdentityDbContext<UserEntity, UserRole, int>
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Student { get; set; } = null!;

    }
}
