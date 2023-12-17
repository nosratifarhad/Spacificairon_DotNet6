namespace Specification.Domain.Common.Entities
{
    public interface ISoftDeleteEntity
    {
        public bool IsDeleted { get; set; }
    }
}