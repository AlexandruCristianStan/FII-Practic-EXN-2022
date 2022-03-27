using ExnCars.Services.Users;
using ExnCars.Services.Users.Dto;
using ExnCars.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ExnCars.Web.Controllers
{
  public class UsersController : Controller
  {
    private readonly IUserService userService;

    public UsersController(IUserService userService)
    {
      this.userService = userService;
    }

    [HttpGet]
    public IActionResult Index()
    {
      throw new NotImplementedException();
      var userDtos = userService.GetAllUsers() ?? new List<UserDto>();

      var userViewModels = userDtos.Select(x => new UserViewModel
      {
        ID = x.ID,
        Email = x.Email,
        FirstName = x.FirstName,
        LastName = x.LastName
      }).ToList();

      return View(userViewModels);
    }

    [HttpGet]
    public IActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Create([FromForm] UserViewModel userViewModel)
    {
      if (userViewModel == null)
      {
        return RedirectToAction("SomethingWentWrong", "Helpers", new { message = "UserViewModel is null" });
      }

      if (!ModelState.IsValid)
      {
        return View(userViewModel);
      }

      var userDto = new UserDto
      {
        FirstName = userViewModel.FirstName,
        LastName = userViewModel.LastName,
        Email = userViewModel.Email
      };

      userService.CreateUser(userDto);

      return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
      if (id < 1)
      {
        return RedirectToAction("SomethingWentWrong", "Helpers", new { message = "User's ID is negative!" });
      }

      var userDto = userService.GetUser(id);
      if (userDto == null)
      {
        return RedirectToAction("NotFound", "Helpers", new { message = "User could not be retrieved!" });
      }

      var userViewModel = new UserViewModel
      {
        ID = id,
        FirstName = userDto.FirstName,
        LastName = userDto.LastName,
        Email = userDto.Email
      };

      return View(userViewModel);
    }

    [HttpPost]
    public IActionResult Edit([FromForm] UserViewModel userViewModel)
    {
      if (userViewModel == null)
      {
        return RedirectToAction("SomethingWentWrong", "Helpers", new { message = "UserViewModel is null" });
      }

      var userDto = userService.GetUser(userViewModel.ID);
      if (userDto == null)
      {
        return RedirectToAction("NotFound", "Helpers", new { message = "User could not be retrieved!" });
      }

      userDto.FirstName = userViewModel.FirstName;
      userDto.LastName = userViewModel.LastName;
      userDto.Email = userViewModel.Email;

      userService.UpdateUser(userDto);

      return RedirectToAction("Index");
    }
  }
}
