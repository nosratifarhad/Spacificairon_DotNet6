using Specification.Domain.Base.Specifications;
using Specification.Domain.Entities;
using Specification.Domain.Enums;

namespace Specification.Domain.Specifications
{
    public static class UserSpecifications
    {
        public static BaseSpecification<User> GetUserByEmailAndPasswordSpec(string emailId, string password)
        {
            return new BaseSpecification<User>(x => x.EmailId == emailId && x.Password == password && x.IsDeleted == false);
        }

        public static BaseSpecification<User> GetAllActiveUsersSpec()
        {
            return new BaseSpecification<User>(x => x.Status == UserStatus.Active && x.IsDeleted == false);
        }
    }
}
