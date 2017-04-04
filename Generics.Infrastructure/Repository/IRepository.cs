using Generics.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace Generics.Infrastructure.Repository
{
    public interface IRepository<T>  where T : Entity
    {
        #region [ CRUD ]
        void Insert(T entity);
        void InsertRange(IEnumerable<T> entities);
        void InsertGraph(T entity);
        void InsertGraphRange(IEnumerable<T> entities);
        void Update(T entity);
        void Delete(T entity);
        void Delete(int id);
        Task<bool> DeleteAsync(params object[] keyValues);
        Task<bool> DeleteAsync(CancellationToken cancellationToken, params object[] keyValues);
        #endregion [ CRUD ]

        #region [ GET ]
        T Get(int id);
        T Get(params object[] keyValues);
        T Get(Expression<Func<T, bool>> match);
        ICollection<T> GetAll();
        ICollection<T> GetAll(Expression<Func<T, bool>> match);
        Task<T> GetAsync(params object[] keyValues);
        Task<T> GetAsync(CancellationToken cancellationToken, params object[] keyValues);
        Task<T> GetAsync(Expression<Func<T, bool>> match);
        Task<T> GetAsync(CancellationToken cancellationToken, Expression<Func<T, bool>> match);
        Task<ICollection<T>> GetAllAsync();
        Task<ICollection<T>> GetAllAsync(CancellationToken cancellationToken);
        Task<ICollection<T>> GetAllAsync(Expression<Func<T, bool>> match);
        Task<ICollection<T>> GetAllAsync(CancellationToken cancellationToken, Expression<Func<T, bool>> match);
        #endregion [ GET ]

        #region [ COUNT ]
        int Count();
        int Count(Expression<Func<T, bool>> match);
        Task<int> CountAsync();
        Task<int> CountAsync(Expression<Func<T, bool>> match);
        #endregion [ COUNT ]

        IRepository<TEntity> GetRepository<TEntity>() where TEntity : Entity;
    }
}
