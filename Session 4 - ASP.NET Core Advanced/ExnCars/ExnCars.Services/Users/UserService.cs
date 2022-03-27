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

    public UserDto GetUser(int id)
    {
      if (id < 1) throw new ArgumentException(nameof(id));

      var user = usersRepository.GetById(id);
      if (user == null) return null;

      return new UserDto
      {
        ID = user.ID,
        Email = user.Email,
        FirstName = user.FirstName,
        LastName = user.LastName,
        Avatar = user.Avatar,
        BirthDate = user.BirthDate,
      };
    }
    public List<UserDto> GetAllUsers() => usersRepository.GetAll().Select(x => new UserDto
    {
      ID = x.ID,
      Email = x.Email,
      FirstName = x.FirstName,
      LastName = x.LastName,
      Avatar = x.Avatar,
      BirthDate = x.BirthDate
    }).ToList();

    public void CreateUser(UserDto userDto)
    {
      if (userDto == null) throw new ArgumentNullException(nameof(userDto));

      var user = new User
      {
        FirstName = userDto.FirstName,
        LastName = userDto.LastName,
        Email = userDto.Email,
        Avatar = userDto.Avatar,
        BirthDate = userDto.BirthDate
      };

      usersRepository.Add(user);

      unitOfWork.SaveChanges();
    }

    public void UpdateUser(UserDto userDto)
    {
      if (userDto == null) throw new ArgumentNullException(nameof(userDto));

      var user = usersRepository.GetById(userDto.ID);
      if (user == null)
      {
        throw new Exception();
      }

      user.FirstName = userDto.FirstName;
      user.LastName = userDto.LastName;
      user.Email = userDto.Email;
      user.Avatar = userDto.Avatar;
      user.BirthDate = userDto.BirthDate;

      unitOfWork.SaveChanges();
    }
  }
}
