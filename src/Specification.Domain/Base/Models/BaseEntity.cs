using System.ComponentModel.DataAnnotations;

namespace Specification.Domain.Base.Models
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
    }
}