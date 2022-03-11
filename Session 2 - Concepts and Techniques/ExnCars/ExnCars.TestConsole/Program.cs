using ExnCars.Data;
using ExnCars.DataAccess;
using ExnCars.Services.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var serviceCollection = new ServiceCollection();
serviceCollection.AddTransient<IUserService, UserService>();
serviceCollection.AddTransient(typeof(IRepository<>), typeof(Repository<>));
serviceCollection.AddTransient<IUnitOfWork, UnitOfWork>();
serviceCollection.AddTransient<DbContext,ExnCarsContext>();
serviceCollection.AddDbContext<ExnCarsContext>(options =>
{
  options.UseSqlServer(@"Data Source=LAPTOP-11\SQLEXPRESS;Initial Catalog=ExnCars;Integrated Security=True");
});

var servceProvider = serviceCollection.BuildServiceProvider();


var userService = servceProvider.GetService<IUserService>();
var user = userService.GetUserByEmail("diana.dobrincu@expertnetwork.ro");

if(user == null)
{
  Console.WriteLine("User not found!");
}
else
{
  Console.WriteLine($"{user.FirstName} {user.LastName} ({user.Email})");
}