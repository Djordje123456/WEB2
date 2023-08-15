<<<<<<< HEAD
﻿using Business.Dto.Auth;
using Business.Dto.User;
using Business.Result;
using Business.Services;
=======
﻿using Business.Dto;
using Business.Dto.User;
using Business.Result;
using Business.Services.Interfaces;
>>>>>>> a7aea91e0d5ffcffd71714a402ecc42b8df1b26f
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace WebAPI.Controllers
{
	[Route("api/user")]
	[ApiController]
	public class UserController : ControllerBase
	{
		IUserService _userService;

		public UserController(IUserService userService)
		{
			_userService = userService;
		}

<<<<<<< HEAD
		[HttpGet("user")]
		[Authorize]
		public IActionResult GetUser()
		{
			try
			{
				string token = Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").LastOrDefault();
				JwtDto jwtDto = new JwtDto(token);

				IServiceOperationResult operationResult = _userService.GetUser(jwtDto);

				if (!operationResult.IsSuccessful)
				{
					return StatusCode((int)operationResult.ErrorCode, operationResult.ErrorMessage);
				}

				return Ok(operationResult.Dto);
			}
			catch (Exception)
			{
				return StatusCode(StatusCodes.Status500InternalServerError);
			}
		}

		[HttpGet("profile-image")]
		[Authorize]
		public IActionResult GetProfileImage()
		{
			try
			{
				string token = Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").LastOrDefault();
				JwtDto jwtDto = new JwtDto(token);

				IServiceOperationResult operationResult = _userService.GetProfileImage(jwtDto);

				if (!operationResult.IsSuccessful)
				{
					return StatusCode((int)operationResult.ErrorCode, operationResult.ErrorMessage);
				}

				return Ok(operationResult.Dto);
			}
			catch (Exception)
			{
				return StatusCode(StatusCodes.Status500InternalServerError);
			}
		}

		[HttpPut("user")]
=======
		[HttpPut("update-user")]
>>>>>>> a7aea91e0d5ffcffd71714a402ecc42b8df1b26f
		[Authorize]
		public IActionResult UpdateUser([FromBody] BasicUserInfoDto userDto)
		{
			try
			{
				string token = Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").LastOrDefault();
				JwtDto jwtDto = new JwtDto(token);

				IServiceOperationResult operationResult = _userService.UpdateUser(userDto, jwtDto);

				if (!operationResult.IsSuccessful)
				{
					return StatusCode((int)operationResult.ErrorCode, operationResult.ErrorMessage);
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

<<<<<<< HEAD
		[HttpPut("password")]
=======
		[HttpPut("change-password")]
>>>>>>> a7aea91e0d5ffcffd71714a402ecc42b8df1b26f
		[Authorize]
		public IActionResult ChangePassword([FromBody] PasswordChangeDto passwordDto)
		{
			try
			{
				string token = Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").LastOrDefault();
				JwtDto jwtDto = new JwtDto(token);

				IServiceOperationResult operationResult = _userService.ChangePassword(passwordDto, jwtDto);

				if (!operationResult.IsSuccessful)
				{
					return StatusCode((int)operationResult.ErrorCode, operationResult.ErrorMessage);
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

<<<<<<< HEAD
		[HttpPut("profile-image")]
=======
		[HttpPut("get-user")]
		[Authorize]
		public IActionResult GetUser()
		{
			try
			{
				string token = Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").LastOrDefault();
				JwtDto jwtDto = new JwtDto(token);

				IServiceOperationResult operationResult = _userService.GetUser(jwtDto);

				if (!operationResult.IsSuccessful)
				{
					return StatusCode((int)operationResult.ErrorCode, operationResult.ErrorMessage);
				}

				return Ok(operationResult.Dto);
			}
			catch (Exception e)
			{
				return StatusCode(StatusCodes.Status500InternalServerError);
			}
		}

		[HttpPut("change-profile-image")]
>>>>>>> a7aea91e0d5ffcffd71714a402ecc42b8df1b26f
		[Authorize]
		public IActionResult ChangeProfileImage([FromForm] ProfileImageDto profileImageDto)
		{
			try
			{
				string token = Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").LastOrDefault();
				JwtDto jwtDto = new JwtDto(token);

				IServiceOperationResult operationResult = _userService.UploadProfileImage(profileImageDto, jwtDto);

				if (!operationResult.IsSuccessful)
				{
					return StatusCode((int)operationResult.ErrorCode, operationResult.ErrorMessage);
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
