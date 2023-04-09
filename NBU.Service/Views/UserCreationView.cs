using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBU.Service.Views
{
	public class UserCreationView
	{
		[Required, MaxLength(40)]
		[DisplayName("First Name")]
		public string FirstName { get; set; }
		[Required, MaxLength(40)]
		[DisplayName("Last Name")]
		public string LastName { get; set; }
		[EmailAddress]
		public string Email { get; set; }
		[MinLength(4)]
		public string Password { get; set; }
		[Phone]
		[DisplayName("Phone Number")]
		public string PhoneNumber { get; set; }
		
		[DisplayName("Username")]
		public string UserName { get; set; }


	}
}
