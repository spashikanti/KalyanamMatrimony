using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KalyanamMatrimony.Models
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        private readonly DbContextOptions<AppDbContext> options;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            this.options = options;
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Profile> Profiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Seed();
        }
    }
}
