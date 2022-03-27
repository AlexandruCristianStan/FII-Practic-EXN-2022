using ExnCars.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExnCars.DataAccess
{
  public class ExnCarsContext : DbContext
  {
    public DbSet<User> Users { get; set; }
    public DbSet<Vehicle> Vehicles { get; set; }
    public DbSet<UserVehicles> UserVehicles { get; set; }
    public DbSet<Model> Models { get; set; }
    public DbSet<Brand> Brands { get; set; }
    public DbSet<DriverLicense> DriverLicenses { get; set; }

    public ExnCarsContext(DbContextOptions<ExnCarsContext> options)
      : base(options)
    {
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
