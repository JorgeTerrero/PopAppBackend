using Microsoft.EntityFrameworkCore;
using PopApp.Data.Context;
using PopApp.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace PopApp.Data.Services
{
    /// <summary>
    /// Represen main repository
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class PopAppRepositoryBase<T> : IPopAppRepositoryBase<T> where T : class
    {
        #region Fields
        private readonly PopAppContext _popAppContext;
        #endregion

        #region Ctor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="popAppContext"></param>
        public PopAppRepositoryBase(PopAppContext popAppContext)
        {
            _popAppContext = popAppContext;
        }
        #endregion

        #region Methods
        ///<inheritdoc/>
        public void Create(T entity) => _popAppContext.Set<T>().Add(entity);

        ///<inheritdoc/>
        public void Delete(T entity) => _popAppContext.Set<T>().Remove(entity);

        ///<inheritdoc/>
        public IQueryable<T> FindAll(bool trackChanges) => !trackChanges ? _popAppContext.Set<T>().AsNoTracking() : _popAppContext.Set<T>();

        ///<inheritdoc/>
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges)
        => !trackChanges ? _popAppContext.Set<T>().Where(expression).AsNoTracking() : _popAppContext.Set<T>().Where(expression);

        ///<inheritdoc/>
        public void Update(T entity) => _popAppContext.Set<T>().Update(entity);
        #endregion
    }
}
