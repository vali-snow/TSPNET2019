using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace ServiceAutoClassLibrary.Repositories
{
    /// <summary>
    /// Implementation of the generic repository
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbSet<T> set;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        internal Repository(DbContext context)
        {
            set = context.Set<T>();
        }

        /// <summary>
        /// Returns from a DbSet of type T the item with the primary key "id"
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T GetById(int id) {
            return set.Find(id);
        }

        /// <summary>
        /// Returns from a DbSet of type T all the items
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T> GetAll()
        {
            return set.ToList();
        }

        /// <summary>
        /// Returns from a Dbset of type T all the items that match the predicate
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public IEnumerable<T> GetFiltered(Expression<Func<T, bool>> predicate)
        {
            return set.Where(predicate);
        }

        /// <summary>
        /// Adds a new item to the DbSet of type T
        /// </summary>
        /// <param name="entity"></param>
        public void Add(T entity)
        {
            set.Add(entity);
        }

        /// <summary>
        /// Adds a range of items to the DbSet of type T
        /// </summary>
        /// <param name="entities"></param>
        public void AddRange(IEnumerable<T> entities)
        {
            set.AddRange(entities);
        }

        /// <summary>
        /// Removes an item from the DbSet of type T
        /// </summary>
        /// <param name="entity"></param>
        public void Remove(T entity)
        {
            set.Remove(entity);
        }

        /// <summary>
        /// Removes a range of items from the DbSet of type T
        /// </summary>
        /// <param name="entities"></param>
        public void RemoveRange(IEnumerable<T> entities)
        {
            set.RemoveRange(entities);
        }
    }
}
