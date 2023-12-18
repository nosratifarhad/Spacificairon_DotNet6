using Specification.Application.DTOs;
using Specification.Application.ViewModels;

namespace Specification.Application.Services.Contracts;

public interface IUserService
{
    Task<int> CreateUser(CreateUserDto req);

    Task<UserViewModel> GetAllUsersAsync();

}