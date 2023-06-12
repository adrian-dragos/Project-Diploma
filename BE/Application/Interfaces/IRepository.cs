using Domain.Entities;

namespace Application.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        IQueryable<T> Read();
        Task<T> AddAsync(T entity);
        Task<T> TryGetByIdAsync(int id, CancellationToken cancellationToken);
        void Update(T student);
        IEnumerable<T> UpdateRange(IEnumerable<T> entities);
    }
}
