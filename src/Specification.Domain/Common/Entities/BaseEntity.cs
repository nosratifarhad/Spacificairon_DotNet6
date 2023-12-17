using System.ComponentModel.DataAnnotations;

namespace Specification.Domain.Common.Entities
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
    }
}