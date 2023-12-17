using Specification.Application.ViewModels;

namespace Specification.Application.Services.Contracts
{
    public interface IUserService
    {

        Task<UserViewModel> GetAllUsersAsync();

    }
}