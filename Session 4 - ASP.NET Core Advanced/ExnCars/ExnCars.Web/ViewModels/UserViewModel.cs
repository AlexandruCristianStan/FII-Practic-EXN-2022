using System.ComponentModel.DataAnnotations;

namespace ExnCars.Web.ViewModels
{
  public class UserViewModel
  {
    public int ID { get; set; }
    [MaxLength(20, ErrorMessage = "Firstname length invalid")]
    public string FirstName { get; set; }
    [MaxLength(20, ErrorMessage = "Lastname length invalid")]
    public string LastName { get; set; }
    [EmailAddress(ErrorMessage = "Invalid email")]
    public string Email { get; set; }
  }
}
