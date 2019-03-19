using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ServiceAutoClassLibrary.Repositories
{
    /// <summary>
    /// Interface for the generic repository
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetFiltered(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
