<<<<<<< HEAD
﻿namespace Business.Dto.Auth
=======
﻿namespace Business.Dto
>>>>>>> a7aea91e0d5ffcffd71714a402ecc42b8df1b26f
{
	public class JwtDto : IDto
	{
		public JwtDto(string token)
		{
			Token = token;
		}

		public string Token { get; set; }
	}
}
