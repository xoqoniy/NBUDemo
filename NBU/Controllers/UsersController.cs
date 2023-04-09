using Microsoft.AspNetCore.Mvc;
using NBU.Data.Configurations;
using NBU.Domain.Entities;
using NBU.Service.Interfaces;
using NBU.Service.Services;

namespace NBU.Controllers
{
	public class UsersController : Controller
	{
		private readonly IUserService userService;

		public UsersController(IUserService userService)
		{
			this.userService = userService;
		}

		public IActionResult Index()
		{
			var users = userService.GetAllUsers();
			return View();
		}
		public async Task<IActionResult> Edit([Bind("FirstName, LastName, Email, PhoneNumber, Password, UserName")]User user)
		{
			var result = await this.userService.UpdateUserAsync(user);
			return View(result);
		}

	}
}
