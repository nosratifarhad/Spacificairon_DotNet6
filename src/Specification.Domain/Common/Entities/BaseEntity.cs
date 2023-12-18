using System.ComponentModel.DataAnnotations;

namespace Specification.Domain.Common.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}