using Application.Interfaces;
using Domain.Entities.Common;

namespace Persistance.EfReposiotry
{
    public class EfRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _dbContext;

        public EfRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<T> Read()
        {
            return _dbContext.Set<T>();
        }
    }
}
