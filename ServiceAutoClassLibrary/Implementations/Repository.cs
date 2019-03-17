using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace ServiceAutoClassLibrary.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbSet<T> Set;

        public Repository(DbContext context)
        {
            Set = context.Set<T>();
        }

        public T GetById(int id) {
            return Set.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return Set.ToList();
        }

        public IEnumerable<T> GetFiltered(Expression<Func<T, bool>> predicate)
        {
            return Set.Where(predicate);
        }

        public void Add(T entity)
        {
            Set.Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            Set.AddRange(entities);
        }

        public void Remove(T entity)
        {
            Set.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            Set.RemoveRange(entities);
        }
    }
}
