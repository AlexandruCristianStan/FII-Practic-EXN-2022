using ExnCars.DataAccess;
using Microsoft.EntityFrameworkCore;

var dbContext = new ExnCarsContext();
AllVehicles(dbContext);
AllUsersAndTheirVehicles(dbContext);
AllVehicleDetails(dbContext);
AllUsersAndTheirLicenses(dbContext);
QuerySyntaxDemo(dbContext);


static void AllVehicles(ExnCarsContext dbContext)
{
    foreach (var vehicle in dbContext.Vehicles)
    {
        Console.WriteLine($"{vehicle.VIN} {vehicle.RegistrationNumber}");
    }
}

static void AllUsersAndTheirVehicles(ExnCarsContext exnCarsContext)
{
    var usersWithCars = exnCarsContext.Users.Include(u => u.Vehicles).ToList();
    foreach (var user in usersWithCars)
    {
        Console.WriteLine($"{user.FirstName} {user.LastName} ({user.Email})");
        foreach(var vehicle in user.Vehicles)
        {
            Console.WriteLine($"\t{vehicle.VIN} {vehicle.RegistrationNumber}");
        }
    }
}

static void AllVehicleDetails(ExnCarsContext exnCarsContext)
{
    var vehicles = exnCarsContext.Vehicles
        .Include(v => v.Model)
        .ThenInclude(m => m.Brand);

    foreach(var vehicle in vehicles)
    {
        Console.WriteLine($"{vehicle.RegistrationNumber} | {vehicle.VIN} | {vehicle.Model.Brand.Name} {vehicle.Model.Name} ({vehicle.Model.FuelType})");
    }
}

static void AllUsersAndTheirLicenses(ExnCarsContext exnCarsContext)
{
    var users = exnCarsContext.Users
            .Include(u => u.DriverLicense);

    foreach(var user in users)
    {
        Console.WriteLine($"{user.FirstName} {user.LastName} | {user.DriverLicense.Categories} {user.DriverLicense.ExpirationDate:yyyy-MM-dd}");
    }
}

static void QuerySyntaxDemo(ExnCarsContext exnCarsContext)
{
    var users = from user in exnCarsContext.Users
                where user.Email.EndsWith("expertnetwork.ro")
                select user;

    users.ToList().ForEach(u => Console.WriteLine($"{u.FirstName} {u.LastName} - {u.Email}"));
}