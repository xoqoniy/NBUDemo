using NBU.Data.IRepositories;
using NBU.Data.Repositories;
using NBU.Domain.Entities;
using NBU.Service.Helpers;
using NBU.Service.Interfaces;
using NBU.Service.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace NBU.Service.Services
{
		
	public class UserService : IUserService
	{

		private readonly IUserRepository userRepository;

		public UserService(IUserRepository userRepository)
		{
			this.userRepository = userRepository;
		}

		public async ValueTask<Response<User>> CreateUserAsync(UserCreationView user)
		{
			var person = await this.userRepository.GetUserByIdAsync(u => u.UserName.Equals(user.UserName));
			if (person is not null)
			{
				return new Response<User>
				{
					StatusCode = 404,
					Message = "Come on, User already exists",
					Value = new User
					{
						FirstName = user.FirstName,
						LastName = user.LastName,
						PhoneNumber = user.PhoneNumber,
						Email = user.Email,
						UserName = user.UserName
					}
				};
			}
			var addedUser = await this.userRepository.InsertUserAsync(person);
			var resultDto = new User
			{
				FirstName = user.FirstName,
				LastName = user.LastName,
				PhoneNumber = user.PhoneNumber,
				Email = user.Email,
				UserName = user.UserName,
			};
			return new Response<User>
			{
				StatusCode = 200,
				Message = "Succesfully added to the database",
				Value = resultDto
			};
		}

		public async ValueTask<Response<bool>> DeleteUserAsync(Predicate<User> predicate)
		{
			User user = await this.userRepository.GetUserByIdAsync(user => predicate(user));

			if (user is null)
			{
				return new Response<bool>
				{
					StatusCode = 404,
					Message = "Could not find for given username",
					Value = false
				};
			}
			await this.userRepository.DeleteUserAsync(u => predicate(user));
			return new Response<bool>
			{
				StatusCode = 200,
				Message = "Successfully deleted",
				Value = true
			};

		}
		public Response<IEnumerable<User>> GetAllUsers()
		{
			var users = this.userRepository.GetAllUsers();
			if (users.Any())
			{
				return new Response<IEnumerable<User>>
				{
					StatusCode = 200,
					Message = "Success",
					Value = users.ToList()

				};
			}
			return new Response<IEnumerable<User>>
			{
				StatusCode = 404,
				Message = "No date can be found",
				Value = null
			};

		}
		public async ValueTask<Response<User>> GetbyIdAsync(Predicate<User> predicate)
		{
			User user = await this.userRepository.GetUserByIdAsync(user => predicate(user));

			if (user is null)
			{
				return new Response<User>
				{
					StatusCode = 404,
					Message = "User is not found",
					Value = null
				};
			}
			return new Response<User>
			{
				StatusCode = 200,
				Message = "Here he/she is",
				Value = user
			};

		}

		public async ValueTask<Response<User>> UpdateUserAsync(User user)
		{
			User person = await this.userRepository.GetUserByIdAsync(t => t.Email == user.Email);
			if (person is null)
			{
				return new Response<User>
				{
					StatusCode = 201,
					Message = "User couldn't be found for given Id",
					Value = null
				};
			}
			var updatedUser = await this.userRepository.UpdateUserAsync(user);

			return new Response<User>
			{
				StatusCode = 200,
				Message = "Success",
				Value = updatedUser
			};

		}
	}
}
