using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NBU.Data.Configurations;
using NBU.Domain.Entities;

namespace NBU.Data
{
    public class SeedInfo
    {
        public static void Initialize(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<NBUContext>();
                //Look for any products.

                if (context.Users.Any())
                {
                    return;   // DB has been seeded
                }
                context.Users.AddRange(
                    new User
                    {
                        Url = @"NBU/Views/Images/homelander.jpg",
                        FirstName = "Homelander",
                        LastName = "Supe",
                        Email = "homelander@gmail.com",
                        PhoneNumber = "1234567890",
                        UserName = "Home",
                        Password = "1234567890",
                    },
                   new User
                   {
                       Url = @"NBU/Views/Images/homelander.jpg",
                       FirstName = "Homelander1",
                       LastName = "Supe",
                       Email = "homelander@gmail.com",
                       PhoneNumber = "1234567890",
                       UserName = "Home1",
                       Password = "1234567890",
                   },
                    new User
                    {
                        Url = @"NBU/Views/Images/homelander.jpg",
                        FirstName = "Homelander2",
                        LastName = "Supe",
                        Email = "homelander@gmail.com",
                        PhoneNumber = "1234567890",
                        UserName = "Home2",
                        Password = "1234567890",
                    },
                   new User
                   {
                       Url = @"NBU/Views/Images/homelander.jpg",
                       FirstName = "Homelander3",
                       LastName = "Supe",
                       Email = "homelander@gmai3l.com",
                       PhoneNumber = "1234567890",
                       UserName = "Home3",
                       Password = "1234567890",
                   }
                );
                context.SaveChanges();
            }
        }

    }
}
