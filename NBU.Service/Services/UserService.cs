using NBU.Data.Repositories;
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

		private readonly UserRepository userRepository;

		public UserService(UserRepository userRepository)
		{
			this.userRepository = userRepository;
		}

		public ValueTask<Response<User>> CreateUserAsync(UserCreationView user)
		{
			throw new NotImplementedException();
		}

		public ValueTask<Response<bool>> DeleteUserAsync(Predicate<User> predicate)
		{
			throw new NotImplementedException();
		}

		public Response<List<User>> GetAllUsers(Predicate<User> predicate = null)
		{
			throw new NotImplementedException();
		}

		public ValueTask<Response<User>> GetbyIdAsync(Predicate<User> predicate)
		{
			throw new NotImplementedException();
		}

		public ValueTask<Response<User>> UpdateUserAsync(Predicate<User> predicate, User user)
		{
			throw new NotImplementedException();
		}
	}
}
