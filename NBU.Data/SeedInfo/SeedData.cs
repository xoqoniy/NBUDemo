using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NBU.Data.Configurations;
using NBU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBU.Data.SeedInfo
{
	public class SeedData
	{
		public static void Initialize(IServiceProvider serviceProvider)
		{
			using (var context = new NBUContext(
				serviceProvider.GetRequiredService<
					DbContextOptions<NBUContext>>()))
			{
				//Look for any products.

				if (context.Users.Any())
				{
					return;   // DB has been seeded
				}
				context.Users.AddRange(
					new User
					{
						FirstName = "Safarmurod",
						LastName = "Ashurov",
						PhoneNumber = "+9989024393232",
						Email = "sm.ashurov7@gmail.com",
						UserName = "Safarmurod7",
						Password = "Safarmurod7"
					},
					new User
					{
						FirstName = "Abdurahmon",
						LastName = "Shohruxov",
						PhoneNumber = "+99899554554",
						Email = "abdurahmon@gmail.com",
						UserName = "Abdurahmon",
						Password = "Abdurahmon"
					},
					new User
					{
						FirstName = "Shohrux",
						LastName = "Anvarov",
						PhoneNumber = "+998978941545",
						Email = "Shohrux@gmail.com",
						UserName = "Shohrux",
						Password = "Shohrux"
					},
					new User
					{
						FirstName = "Azamat",
						LastName = "Xazratov",
						PhoneNumber = "+998955448533",
						Email = "Azamat@gmail.com",
						UserName = "Azamat",
						Password = "Azamat"
					}
				);
				context.SaveChanges();
			}
		}
	}
}
