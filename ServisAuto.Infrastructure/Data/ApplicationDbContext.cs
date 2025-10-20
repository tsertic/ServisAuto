using Microsoft.EntityFrameworkCore;
using ServisAuto.domain.Entities;

namespace ServisAuto.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Vehicle> Vehicles { get; set; }= null!;
        public DbSet<Reservation> Reservations { get; set; }= null!;
        public DbSet<Service> Services { get; set; }=null!;
    }
}
