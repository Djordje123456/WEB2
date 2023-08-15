<<<<<<< HEAD
﻿using Business.Dto.Auth;
using Business.Dto.User;
using Business.Result;

namespace Business.Services
=======
﻿using Business.Dto;
using Business.Dto.User;
using Business.Result;

namespace Business.Services.Interfaces
>>>>>>> a7aea91e0d5ffcffd71714a402ecc42b8df1b26f
{
	public interface IUserService
	{
		IServiceOperationResult GetUser(JwtDto jwtDto);

<<<<<<< HEAD
		IServiceOperationResult GetProfileImage(JwtDto jwtDto);

=======
>>>>>>> a7aea91e0d5ffcffd71714a402ecc42b8df1b26f
		IServiceOperationResult UpdateUser(BasicUserInfoDto newUserDto, JwtDto jwtDto);

		IServiceOperationResult ChangePassword(PasswordChangeDto passwordDto, JwtDto jwtDto);

		IServiceOperationResult UploadProfileImage(ProfileImageDto profileDto, JwtDto jwtDto);
	}
}
