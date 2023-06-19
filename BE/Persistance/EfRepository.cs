using Application.Interfaces;
using Domain.Entities;
using Domain.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Persistence
{
    internal class EfRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public EfRepository(ApplicationDbContext dbContext, IHttpContextAccessor httpContextAccessor)
        {
            _dbContext = dbContext;
            _httpContextAccessor = httpContextAccessor;
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

        public void Update(T entity)
        {
            _dbContext.Entry(entity).State= EntityState.Modified;
            Audit();
            _dbContext.SaveChanges();
        }

        public IEnumerable<T> UpdateRange(IEnumerable<T> entities)
        {
            _dbContext.Set<T>().UpdateRange(entities);
            Audit();
            _dbContext.SaveChanges();

            return entities;
        }

        private void Audit()
        {
            var now = DateTimeOffset.Now;

            var httpContext = _httpContextAccessor.HttpContext;
            var email = httpContext.User.Claims.FirstOrDefault(x=> x.Type == ClaimTypes.Email)?.Value;

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
                    entity.CreatedBy = email;
              }
                else if (entry.State is EntityState.Modified)
                {
                    entity.LastModifiedAt = now;
                    entity.LastModifiedBy = entity.CreatedBy = email;
                }
            }


        }
    }
}
