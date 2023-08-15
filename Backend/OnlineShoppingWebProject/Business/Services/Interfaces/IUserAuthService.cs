<<<<<<< HEAD
﻿using Business.Dto.Auth;
=======
﻿using Business.Dto;
>>>>>>> a7aea91e0d5ffcffd71714a402ecc42b8df1b26f
using Business.Result;

namespace Business.Services
{
	public interface IUserAuthService
	{
		IServiceOperationResult LoginUser(LoginUserDto loginDto);

		IServiceOperationResult RegisterUser(RegisterUserDto registerDto);
	}
}
