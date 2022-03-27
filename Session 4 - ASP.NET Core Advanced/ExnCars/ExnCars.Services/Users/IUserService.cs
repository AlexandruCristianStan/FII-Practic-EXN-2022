using ExnCars.Services.Users.Dto;

namespace ExnCars.Services.Users
{
  public interface IUserService
  {
    UserDto GetUser(int id);
    List<UserDto> GetAllUsers();
    void CreateUser(UserDto userDto);
    void UpdateUser(UserDto userDto);
  }
}
