using Microsoft.EntityFrameworkCore;
using UniversityService.Models;

namespace UniversityService.Data
{
    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext(DbContextOptions<UniversityDbContext> options) : base(options)
        {
        }

        public DbSet<University> Universities { get; set; }
    }
}
