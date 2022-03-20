using ExnCars.Data;
using ExnCars.Data.Entities;
using ExnCars.Services.Users.Dto;

namespace ExnCars.Services.Users
{
  public class UserService : IUserService
  {
    private readonly IRepository<User> usersRepository;
    private readonly IUnitOfWork unitOfWork;

    public UserService(
      IRepository<User> usersRepository,
      IUnitOfWork unitOfWork)
    {
      this.usersRepository = usersRepository;
      this.unitOfWork = unitOfWork;
    }

  }
}
