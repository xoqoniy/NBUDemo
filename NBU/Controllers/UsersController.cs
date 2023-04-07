using Microsoft.AspNetCore.Mvc;
using NBU.Data.Configurations;
using NBU.Domain.Entities;
using NBU.Service.Services;

namespace NBU.Controllers
{
	public class UsersController : Controller
	{
		private readonly UserService userService;

		public UsersController(UserService userService)
		{
			this.userService = userService;
		}
		public async Task<IActionResult> Edit(Predicate<User> predicate, User user)
		{
			var result = await this.userService.UpdateUserAsync(predicate, user);
			return Ok(result);
		}
	}
}
