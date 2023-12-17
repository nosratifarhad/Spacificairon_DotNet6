using Specification.Domain.Common.Entities;

namespace Specification.Domain.Common.Repositories
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync();

        Task RollBackChangesAsync();

        IBaseRepositoryAsync<T> Repository<T>() where T : BaseEntity;

    }
}