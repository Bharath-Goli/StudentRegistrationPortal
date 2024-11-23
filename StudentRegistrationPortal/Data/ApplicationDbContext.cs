using Microsoft.EntityFrameworkCore;
using StudentRegistrationPortal.Models.Entities;

namespace StudentRegistrationPortal.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options)
        {
            
        }

        public required DbSet<Student>Students{ get; set; }
    }

}
