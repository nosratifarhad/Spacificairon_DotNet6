using Specification.Application.DTOs;
using Specification.Application.Services.Contracts;
using Specification.Application.ViewModels;
using Specification.Domain.Common.Repositories;
using Specification.Domain.User.Entities;
using Specification.Domain.User.Specifications;

namespace Specification.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<UserViewModel> GetAllUsersAsync()
        {
            var activeUsersSpec = UserSpecifications.GetAllActiveUsersSpec();

            var users = await _unitOfWork.Repository<UserBase>().ListAsync(activeUsersSpec);

            return new UserViewModel()
            {
                UserDTOs = users.Select(x => new UserDTO(x)).ToList()
            };
        }
    }
}