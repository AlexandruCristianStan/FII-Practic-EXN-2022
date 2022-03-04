using ExnCars.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExnCars.DataAccess
{
    internal class ExnCarsContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<UserVehicles> UserVehicles { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<DriverLicense> DriverLicenses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-11\SQLEXPRESS;Initial Catalog=ExnCars;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserVehicles>()
                .HasKey(uv => new { uv.UserID, uv.VehicleID });

            modelBuilder.Entity<User>()
                .HasMany(u => u.Vehicles)
                .WithMany(v => v.Users)
                .UsingEntity<UserVehicles>();

            modelBuilder.Entity<User>()
                .HasOne(u => u.DriverLicense)
                .WithOne(dl => dl.User)
                .HasForeignKey<DriverLicense>(dl => dl.UserID);

        }
    }
}
