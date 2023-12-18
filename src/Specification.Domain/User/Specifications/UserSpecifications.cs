using Specification.Domain.Common.Specifications;
using Specification.Domain.User.Entities;
using Specification.Domain.User.Enums;

namespace Specification.Domain.User.Specifications
{
    public static class UserSpecifications
    {
        public static BaseSpecification<UserBase> GetUserByEmailAndPasswordSpec(string emailId, string password)
        {
            return new BaseSpecification<UserBase>(x => x.Email == emailId && x.Password == password && x.IsDeleted == false);
        }

        public static BaseSpecification<UserBase> GetAllActiveUsersSpec()
        {
            return new BaseSpecification<UserBase>(x => x.Status == UserStatus.Active && x.IsDeleted == false);
        }
    }
}
