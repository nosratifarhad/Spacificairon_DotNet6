using Specification.Domain.Common.Entities;
using Specification.Domain.User.Enums;

namespace Specification.Domain.User.Entities
{
    public class UserBase : BaseEntity, IAuditableEntity, ISoftDeleteEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailId { get; set; }

        public string Password { get; set; }

        public UserStatus Status { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTimeOffset CreatedOn { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public DateTimeOffset? LastModifiedOn { get; set; }

        public bool IsDeleted { get; set; }
    }
}
