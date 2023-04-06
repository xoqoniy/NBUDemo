using NBU.Domain.Entities;
using NBU.Service.Helpers;
using NBU.Service.Interfaces;
using NBU.Service.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBU.Service.Services
{
	public class UserService : IUserService
	{
		public ValueTask<Response<User>> CreateUserAsync(UserCreationView user)
		{
			throw new NotImplementedException();
		}

		public ValueTask<Response<bool>> DeleteUserAsync(int id)
		{
			throw new NotImplementedException();
		}

		public Response<List<User>> GetAllUsers()
		{
			throw new NotImplementedException();
		}

		public ValueTask<Response<User>> GetbyIdAsync(int id)
		{
			throw new NotImplementedException();
		}

		public ValueTask<Response<User>> UpdateUserAsync(int id, User user)
		{
			throw new NotImplementedException();
		}
	}
}
