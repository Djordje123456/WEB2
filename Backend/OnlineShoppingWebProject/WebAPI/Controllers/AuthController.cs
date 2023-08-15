<<<<<<< HEAD
﻿using Business.Dto.Auth;
=======
﻿using Business.Dto;
>>>>>>> a7aea91e0d5ffcffd71714a402ecc42b8df1b26f
using Business.Result;
using Business.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;

namespace WebAPI.Controllers
{
	[Route("api/auth")]
	[ApiController]
	public class AuthController : ControllerBase
	{
		IUserAuthService _userAuthService;

		public AuthController(IUserAuthService userAuthService)
		{
			_userAuthService = userAuthService;
		}

		[HttpPost("login")]
		public IActionResult LoginUser([FromBody] LoginUserDto loginDto)
		{
			try
			{
				IServiceOperationResult operationResult = _userAuthService.LoginUser(loginDto);

				if (!operationResult.IsSuccessful)
				{
					return StatusCode((int)operationResult.ErrorCode);
				}

				return Ok(operationResult.Dto);
			}
<<<<<<< HEAD
			catch (Exception)
=======
			catch (Exception e)
>>>>>>> a7aea91e0d5ffcffd71714a402ecc42b8df1b26f
			{
				return StatusCode(StatusCodes.Status500InternalServerError);
			}
		}

		[HttpPost("regiser")]
		public IActionResult RegisterUser([FromForm]RegisterUserDto registerDto)
		{
			try
			{
				IServiceOperationResult operationResult = _userAuthService.RegisterUser(registerDto);

				if (!operationResult.IsSuccessful)
				{
					if (operationResult.ErrorCode == ServiceOperationErrorCode.Conflict)
					{
						return StatusCode((int)HttpStatusCode.Conflict, operationResult.ErrorMessage);
					}
					else
					{
						return StatusCode((int)HttpStatusCode.BadRequest);
					}
				}

				return Ok();
			}
<<<<<<< HEAD
			catch (Exception)
=======
			catch (Exception e)
>>>>>>> a7aea91e0d5ffcffd71714a402ecc42b8df1b26f
			{
				return StatusCode(StatusCodes.Status500InternalServerError);
			}
		}
	}
}
