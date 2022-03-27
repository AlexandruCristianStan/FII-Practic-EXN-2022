namespace ExnCars.Services.Users.Dto
{
  public class UserDto
  {
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public DateTime? BirthDate { get; set; }
    public string? Avatar { get; set; }
  }
}
