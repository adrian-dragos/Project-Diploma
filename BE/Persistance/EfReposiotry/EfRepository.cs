﻿using Application.Interfaces;
using Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace Persistance.EfReposiotry
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
