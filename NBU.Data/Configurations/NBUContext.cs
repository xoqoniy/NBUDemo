using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using NBU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBU.Data.Configurations
{
	public class NBUContext : DbContext
	{
		public NBUContext(DbContextOptions<NBUContext>options):base (options){ }
		public DbSet<User> Users { get; set; }
	}
}
