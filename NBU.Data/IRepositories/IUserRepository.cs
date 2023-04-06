using NBU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBU.Data.IRepositories
{
	public interface IUserRepository
	{
		public ValueTask<User>InsertUserAsync(User user);
		public ValueTask<User>UpdateUserAsync(int id, User user);
		public ValueTask<bool> DeleteUserAsync(int id);
		public ValueTask<User> GetUserByIdAsync(int id);
		public IQueryable<User> GetAllUsers();
	}
}
