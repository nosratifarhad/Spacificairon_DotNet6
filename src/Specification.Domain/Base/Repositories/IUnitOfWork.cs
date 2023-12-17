using Specification.Domain.Base.Models;

namespace Specification.Domain.Base.Repositories
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync();

        Task RollBackChangesAsync();

        IBaseRepositoryAsync<T> Repository<T>() where T : BaseEntity;

    }
}