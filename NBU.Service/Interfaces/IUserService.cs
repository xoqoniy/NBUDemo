using NBU.Domain.Entities;
using NBU.Service.Helpers;
using NBU.Service.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBU.Service.Interfaces
{
	public interface IUserService
	{
		public ValueTask<Response<User>> CreateUserAsync(UserCreationView user);
		public ValueTask<Response<User>> UpdateUserAsync(Predicate<User> predicate, User user);
		public ValueTask<Response<bool>> DeleteUserAsync(Predicate<User> predicate);
		public ValueTask<Response<User>> GetbyIdAsync(Predicate<User> predicate);
		public Response<List<User>> GetAllUsers(Predicate<User> predicate = null);
	}
}
