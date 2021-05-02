using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace PopApp.Data.Interfaces
{
    /// <summary>
    /// Represent main repository.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IPopAppRepositoryBase<T>
    {
        /// <summary>
        /// Find all of a entity.
        /// </summary>
        /// <param name="TrackChanges"></param>
        /// <returns>List of T</returns>
        IQueryable<T> FindAll(bool TrackChanges);
        /// <summary>
        /// Find a entity.
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="trackChanges"></param>
        /// <returns>T class</returns>
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges);
        /// <summary>
        /// Create a entity.
        /// </summary>
        /// <param name="entity"></param>
        void Create(T entity);
        /// <summary>
        /// Update a entity.
        /// </summary>
        /// <param name="entity"></param>
        void Update(T entity);
        /// <summary>
        /// Delete a entity.
        /// </summary>
        /// <param name="entity"></param>
        void Delete(T entity);
    }
}
