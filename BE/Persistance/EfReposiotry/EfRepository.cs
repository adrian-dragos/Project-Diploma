using Application.Interfaces;
using Domain.Entities.Common;
using Domain.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace Persistence.EfReposiotry
{
    public class EfRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _dbContext;

        public EfRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _dbContext.AddAsync(entity);
            Audit();
            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public IQueryable<T> Read()
        {
            return _dbContext.Set<T>();
        }

        public async Task<T> TryGetByIdAsync(int id, CancellationToken cancellationToken)
        {
            var entity = await _dbContext
                .Set<T>()
                .FirstOrDefaultAsync(e => e.Id == id, cancellationToken);

            if (entity is null)
            {
                throw EntityNotFoundException.OfType<T>(id);
            }

            return entity;
        }

        private void Audit()
        {
            var now = DateTimeOffset.Now;

            var entries = _dbContext
                .ChangeTracker
                .Entries()
                .Where(x => x.State == EntityState.Added || x.State == EntityState.Modified);

            foreach (var entry in entries)
            {
                var entity = (BaseEntity)entry.Entity;

                if (entry.State is EntityState.Added)
                {
                    entity.CreatedAt = now;
                    entity.CreatedBy = "";
                }
                else if (entry.State is EntityState.Modified)
                {
                    entity.LastModifiedAt = now;
                    entity.LastModifiedBy = "";
                }
            }
        }
    }
}
