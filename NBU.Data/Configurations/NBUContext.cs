using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using NBU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace NBU.Data.Configurations
{
	public class NBUContext : DbContext
	{
		//public NBUContext(DbContextOptions<NBUContext>options):base (options){ }
		private readonly string connection = "Server=(localdb)\\mssqllocaldb; Database=NBUDb; Trusted_Connection=True; MultipleActiveResultSets=true";

		public NBUContext(DbContextOptions options) : base(options)
		{
		}

		//protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		//{
		//	optionsBuilder.UseSqlServer(connection); // b => b.MigrationsAssembly("NBU")
		//}
		public DbSet<User> Users { get; set; }
	}
}
