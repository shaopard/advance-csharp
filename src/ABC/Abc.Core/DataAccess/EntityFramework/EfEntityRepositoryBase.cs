using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;

using Abc.Core.Entities;

namespace Abc.Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity> where TEntity : class, IEntity, new() where TContext : DbContext, new()
    {
        public TEntity Add(TEntity entity)
        {
            using (var context = new TContext())
            {
                DbEntityEntry<TEntity> addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();

                return entity;
            }
        }

        public void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                DbEntityEntry<TEntity> deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var context = new TContext())
            {
                TEntity result = context.Set<TEntity>().SingleOrDefault(filter);

                return result;
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                List<TEntity> result = (filter == null) ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();

                return result;
            }
        }

        public TEntity Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                DbEntityEntry<TEntity> modifiedEntity = context.Entry(entity);
                modifiedEntity.State = EntityState.Modified;
                context.SaveChanges();

                return entity;
            }
        }
    }
}