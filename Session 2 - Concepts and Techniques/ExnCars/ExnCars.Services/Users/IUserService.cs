using ExnCars.Services.Users.Dto;

namespace ExnCars.Services.Users
{
  public interface IUserService
  {
    UserDto GetUserByEmail(string email);
    void RegisterNewUser(UserDto user);
    void UpdateUser(UserDto user);
  }
}
