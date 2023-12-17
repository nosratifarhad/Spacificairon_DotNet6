using Specification.Domain.Base.Models;
using Specification.Domain.Base.Specifications;

namespace Specification.Domain.Base.Repositories
{
    public interface IBaseRepositoryAsync<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(Guid id);

        Task<IList<T>> ListAllAsync();

        Task<IList<T>> ListAsync(ISpecification<T> spec);

        Task<T?> FirstOrDefaultAsync(ISpecification<T?> spec);

        Task<T> AddAsync(T entity);

        void Update(T entity);

        void Delete(T entity);

        Task<int> CountAsync(ISpecification<T> spec);

    }
}
