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
		public ValueTask<User>UpdateUserAsync(User user);
		public ValueTask<bool> DeleteUserAsync(Predicate<User>predicate);
		public ValueTask<User> GetUserByIdAsync(Predicate<User> predicate);
		public IQueryable<User> GetAllUsers();
	}
}
