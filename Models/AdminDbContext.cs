using Microsoft.EntityFrameworkCore;

namespace SMS.Admin.Models
{
    public class AdmicnDbContext : DbContext
    {
        public AdmicnDbContext(DbContextOptions<AdmicnDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Designation> Designation { get; set; }
        public DbSet<Parents> Parents { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<State> State { get; set; }        
    }
}
