using Microsoft.AspNetCore.Http;
using System;

<<<<<<< HEAD
namespace Business.Dto.Auth
=======
namespace Business.Dto
>>>>>>> a7aea91e0d5ffcffd71714a402ecc42b8df1b26f
{
	public class RegisterUserDto : IDto
	{
		public string Firstname { get; set; }

		public string Lastname { get; set; }

		public string Username { get; set; }

		public string Email { get; set; }

		public string Password { get; set; }

		public string Address { get; set; }

		public string Type { get; set; }

		public IFormFile ProfileImage { get; set; }

		public DateTime Birthdate { get; set; }
	}
}
