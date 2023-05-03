using Domain.Entities.Common;

namespace Application.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        IQueryable<T> Read();
        Task<T> AddAsync(T entity);
    }
}
