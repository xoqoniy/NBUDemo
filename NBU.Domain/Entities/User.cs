using NBU.Domain.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBU.Domain.Entities
{
	public class User : Auditable
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		[EmailAddress, Required]
		public string Email { get; set; }
		[Phone, Required]
		public string PhoneNumber { get; set; }
		[MinLength(4)]
		public string Password { get; set; }
		[MaxLength(3)]
		public string UserName { get; set; }

	}
}
