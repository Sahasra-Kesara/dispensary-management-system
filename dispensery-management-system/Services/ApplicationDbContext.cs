using dispensery_management_system.Models;
using Microsoft.EntityFrameworkCore;

namespace dispensery_management_system.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointment { get; set; }
    }
}
