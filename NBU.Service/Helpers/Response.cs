using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBU.Service.Helpers
{
	public class Response<TResult>
	{
		//Header
		public int StatusCode { get; set; }
		public string Message { get; set; }

		//Body
		public TResult Value { get; set; }
	}
}
