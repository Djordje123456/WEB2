using AutoMapper;
<<<<<<< HEAD
using Business.Dto.Auth;
using Business.Dto.User;
using Business.Result;
=======
using Business.Dto;
using Business.Dto.User;
using Business.Result;
using Business.Services.Interfaces;
>>>>>>> a7aea91e0d5ffcffd71714a402ecc42b8df1b26f
using Business.TokenHelper;
using Business.Util;
using Data.Models;
using Data.Repository.Util;
using Data.UnitOfWork;
using System.IO;

namespace Business.Services
{
	public class UserService : IUserService
	{
		readonly IUserTokenIssuer _tokenIssuer;

		readonly IMapper _mapper;

		readonly IUnitOfWork _unitOfWork;

		readonly IUserHelper userHelper;

		readonly IUserRepositoryManager userRepositoryManager;

		public UserService(IUserTokenIssuer tokenIssuer, IMapper mapper, IUnitOfWork unitOfWork)
		{
			_tokenIssuer = tokenIssuer;
			_mapper = mapper;
			_unitOfWork = unitOfWork;
			userHelper = new UserHelper(unitOfWork);
			userRepositoryManager = new UserRepositoryManager(unitOfWork);
		}

		public IServiceOperationResult GetUser(JwtDto jwtDto)
		{
			IServiceOperationResult operationResult;

<<<<<<< HEAD
			IUser user = userHelper.FindUserByJwt(jwtDto.Token, _tokenIssuer);
			if (user == null)
			{
				operationResult = new ServiceOperationResult(false, ServiceOperationErrorCode.NotFound);

=======
			long id = int.Parse(_tokenIssuer.GetClaimValueFromToken(jwtDto.Token, "id"));
			IUser user = userHelper.FindById(id);
			if(user == null)
			{
				operationResult = new ServiceOperationResult(false, ServiceOperationErrorCode.NotFound);
				
>>>>>>> a7aea91e0d5ffcffd71714a402ecc42b8df1b26f
				return operationResult;
			}

			UserInfoDto userDto = _mapper.Map<UserInfoDto>(user);
			operationResult = new ServiceOperationResult(true, userDto);

			return operationResult;
		}

<<<<<<< HEAD
		public IServiceOperationResult GetProfileImage(JwtDto jwtDto)
		{
			IServiceOperationResult operationResult;

			IUser user = userHelper.FindUserByJwt(jwtDto.Token, _tokenIssuer);
			if (user == null)
			{
				operationResult = new ServiceOperationResult(false, ServiceOperationErrorCode.NotFound);

				return operationResult;
			}

			byte[] image = userHelper.GetProfileImage(user.ProfileImage);
			if (image == null)
			{
				operationResult = new ServiceOperationResult(false, ServiceOperationErrorCode.NotFound, "Users profile image has not been found!");
				return operationResult;
			}

			ProfileImageByteArrDto imageDto = new ProfileImageByteArrDto() { ProfileImage = image };
			operationResult = new ServiceOperationResult(true, imageDto);

			return operationResult;
		}

=======
>>>>>>> a7aea91e0d5ffcffd71714a402ecc42b8df1b26f
		public IServiceOperationResult UpdateUser(BasicUserInfoDto newUserDto, JwtDto jwtDto)
		{
			IServiceOperationResult operationResult;

			IUser newUser = _mapper.Map<User>(newUserDto);
<<<<<<< HEAD

			IUser currentUser = userHelper.FindUserByJwt(jwtDto.Token, _tokenIssuer);
			if (currentUser == null)
			{
				operationResult = new ServiceOperationResult(false, ServiceOperationErrorCode.NotFound);

				return operationResult;
			}
=======
			long id = int.Parse(_tokenIssuer.GetClaimValueFromToken(jwtDto.Token, "id"));
			IUser currentUser = userHelper.FindById(id);
>>>>>>> a7aea91e0d5ffcffd71714a402ecc42b8df1b26f

			if (currentUser == null || newUser == null)
			{
				operationResult = new ServiceOperationResult(false, ServiceOperationErrorCode.NotFound);
				
				return operationResult;
			}

			if (newUser.Username != currentUser.Username && userHelper.FindUserByUsername(newUser.Username) != null)
			{
				operationResult = new ServiceOperationResult(false, ServiceOperationErrorCode.Conflict, "A user with a given username already exists!");
				
				return operationResult;
			}

<<<<<<< HEAD
			userHelper.UpdateProfileImagePath(currentUser, newUser.Username);
=======
			UpdateProfileImagePath(currentUser, newUser.Username);
>>>>>>> a7aea91e0d5ffcffd71714a402ecc42b8df1b26f
			userHelper.UpdateBasicUserData(currentUser, newUser);

			if(!userRepositoryManager.UpdateUser(currentUser))
			{
				operationResult = new ServiceOperationResult(false, ServiceOperationErrorCode.NotFound);
				
				return operationResult;
			}

			_unitOfWork.Commit();

			operationResult = new ServiceOperationResult(true);
			
			return operationResult;
		}

		public IServiceOperationResult ChangePassword(PasswordChangeDto passwordDto, JwtDto jwtDto)
		{
			IServiceOperationResult operationResult;
<<<<<<< HEAD

			IUser user = userHelper.FindUserByJwt(jwtDto.Token, _tokenIssuer);
			if (user == null)
			{
				operationResult = new ServiceOperationResult(false, ServiceOperationErrorCode.NotFound);

				return operationResult;
			}
=======
			long id = int.Parse(_tokenIssuer.GetClaimValueFromToken(jwtDto.Token, "id"));
			IUser user = userHelper.FindById(id);
>>>>>>> a7aea91e0d5ffcffd71714a402ecc42b8df1b26f

			IAuthHelper authHelper = new AuthHelper();
			if(!authHelper.IsPasswordValid(passwordDto.OldPassword, user.Password))
			{
				operationResult = new ServiceOperationResult(false, ServiceOperationErrorCode.Unauthorized);

				return operationResult;
			}

			if (authHelper.IsPasswordWeak(passwordDto.NewPassword))
			{
				operationResult = new ServiceOperationResult(false, ServiceOperationErrorCode.BadRequest);

				return operationResult;
			}

			string newHashedPass = authHelper.HashPassword(passwordDto.NewPassword);
			user.Password = newHashedPass;

			if (!userRepositoryManager.UpdateUser(user))
			{
				operationResult = new ServiceOperationResult(false, ServiceOperationErrorCode.BadRequest);

				return operationResult;
			}

			_unitOfWork.Commit();

			operationResult = new ServiceOperationResult(true);
			
			return operationResult;
		}

		public IServiceOperationResult UploadProfileImage(ProfileImageDto profileDto, JwtDto jwtDto)
		{
			IServiceOperationResult operationResult;
<<<<<<< HEAD

			IUser user = userHelper.FindUserByJwt(jwtDto.Token, _tokenIssuer);
			if (user == null)
			{
				operationResult = new ServiceOperationResult(false, ServiceOperationErrorCode.NotFound);

				return operationResult;
			}
=======
			long id = int.Parse(_tokenIssuer.GetClaimValueFromToken(jwtDto.Token, "id"));
			IUser user = userHelper.FindById(id);
>>>>>>> a7aea91e0d5ffcffd71714a402ecc42b8df1b26f

			if (!userHelper.UploadProfileImage(user, profileDto.ProfileImage))
			{
				operationResult = new ServiceOperationResult(false, ServiceOperationErrorCode.BadRequest);

				return operationResult;
			}

			if (!userRepositoryManager.UpdateUser(user))
			{
				operationResult = new ServiceOperationResult(false, ServiceOperationErrorCode.BadRequest);

				return operationResult;
			}

			_unitOfWork.Commit();

			operationResult = new ServiceOperationResult(true);

			return operationResult;
		}
<<<<<<< HEAD
=======

		/// <summary>
		/// In case that the username has changed, the profile image file name has to be updated which is what this method does.
		/// </summary>
		private void UpdateProfileImagePath(IUser currentUser, string newUsername)
		{
			if (currentUser.Username == newUsername)
			{
				return;
			}

			string oldProfileImagePath = Path.Combine(Directory.GetCurrentDirectory(), userHelper.ProfileImagesRelativePath, currentUser.ProfileImage);

			if (!File.Exists(oldProfileImagePath))
			{
				return;
			}

			string fileExtension = Path.GetExtension(currentUser.ProfileImage);
			string profileImage = newUsername + fileExtension;

			string newProfileImagePath = Path.Combine(Directory.GetCurrentDirectory(), userHelper.ProfileImagesRelativePath, profileImage);
			File.Move(oldProfileImagePath, newProfileImagePath);

			currentUser.ProfileImage = profileImage;
		}
>>>>>>> a7aea91e0d5ffcffd71714a402ecc42b8df1b26f
	}
}
