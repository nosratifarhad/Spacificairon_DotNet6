using Specification.Application.DTOs;
using Specification.Application.Services.Contracts;
using Specification.Application.ViewModels;
using Specification.Domain.Common.Repositories;
using Specification.Domain.Exceptions;
using Specification.Domain.User.Entities;
using Specification.Domain.User.Enums;
using Specification.Domain.User.Specifications;

namespace Specification.Application.Services;

public class UserService : IUserService
{

    #region [ Fields ]

    private readonly IUnitOfWork _unitOfWork;

    #endregion [ Fields ]

    #region [ Ctor ]

    public UserService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    #endregion [ Ctor ]

    public async Task<int> CreateUser(CreateUserDto createUserDto)
    {
        ValidateCreateUserDto(createUserDto);

        await ValidateUser(createUserDto);

        var userBase = CreateUserBase(createUserDto);

        var user =
            await _unitOfWork.Repository<UserBase>().AddAsync(userBase);

        await _unitOfWork.SaveChangesAsync();

        return user.Id;
    }

    public async Task<UserViewModel> GetAllUsersAsync()
    {
        var activeUsersSpec = UserSpecifications.GetAllActiveUsersSpec();

        var users = await _unitOfWork.Repository<UserBase>().ListAsync(activeUsersSpec);

        return new UserViewModel()
        {
            UserDtos = users.Select(x => new UserDto(x)).ToList()
        };
    }

    #region [ Private ]

    private void ValidateCreateUserDto(CreateUserDto createUserDto)
    {
        if (createUserDto == null)
            throw new InValidateObjectException(nameof(CreateUserDto));

        if (string.IsNullOrEmpty(createUserDto.FirstName))
            throw new ValidateFirstNameException();

        if (string.IsNullOrEmpty(createUserDto.LastName))
            throw new ValidateLastNameException();

        if (string.IsNullOrEmpty(createUserDto.Email))
            throw new ValidateEmailException();

        if (string.IsNullOrEmpty(createUserDto.Password))
            throw new ValidatePasswordException();
    }

    public async Task ValidateUser(CreateUserDto createUserDto)
    {
        var validateUserSpec = UserSpecifications.GetUserByUserNameSpec(createUserDto.UserName);

        var user = await _unitOfWork.Repository<UserBase>().FirstOrDefaultAsync(validateUserSpec);

        if (user != null)
            throw new AlreadyExistsUserNameException(createUserDto.UserName);
    }

    private UserBase CreateUserBase(CreateUserDto createUserDto)
    {
        var userBase = new UserBase
        {
            FirstName = createUserDto.FirstName,
            LastName = createUserDto.LastName,
            Email = createUserDto.Email,
            Password = createUserDto.Password,
            Status = createUserDto.Status
        };

        return userBase;
    }

    #endregion [ Private ]
}