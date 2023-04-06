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

		
	}
}
