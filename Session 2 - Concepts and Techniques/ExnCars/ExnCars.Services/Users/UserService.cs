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

    public UserDto? GetUserByEmail(string email)
    {
      if(string.IsNullOrEmpty(email)) throw new ArgumentNullException(nameof(email));

      var user = usersRepository.Query(u => u.Email == email).FirstOrDefault();
      if(user == null)
      {
        return null;
      }

      return new UserDto
      {
        ID = user.ID,
        FirstName = user.FirstName, 
        LastName = user.LastName,
        Email = user.Email
      };

      unitOfWork.SaveChanges();
    }

    public void RegisterNewUser(UserDto user)
    {
      if(user == null) throw new ArgumentNullException(nameof(user));

      if(usersRepository.Query(u => u.Email == user.Email).Any())
      {
        throw new Exception("Cannot create a new User with the same Email address.");
      }

      usersRepository.Add(new User
      {
        FirstName = user.FirstName,
        LastName = user.LastName,
        Email = user.Email
      });
    }

    public void UpdateUser(UserDto user)
    {
      if (user == null) throw new ArgumentNullException(nameof(user));

      var existingUser = usersRepository.GetById(user.ID);
      if (existingUser == null)
      {
        throw new Exception("User was not found!");
      }

      existingUser.FirstName = user.FirstName;
      existingUser.LastName = user.LastName;
      existingUser.Email = user.Email;
      usersRepository.Update(existingUser);
      unitOfWork.SaveChanges();
    }
  }
}
