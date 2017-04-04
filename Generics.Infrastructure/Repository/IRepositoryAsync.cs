using Generics.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace Generics.Infrastructure.Repository
{
    public interface IRepositoryAsync<T> where T : Entity
    {
        #region [ Get Async]
        Task<T> GetAsync(params object[] keyValues);
        Task<T> GetAsync(CancellationToken cancellationToken, params object[] keyValues);
        Task<T> GetAsync(Expression<Func<T, bool>> match);
        Task<T> GetAsync(CancellationToken cancellationToken, Expression<Func<T, bool>> match);
        Task<ICollection<T>> GetAllAsync();
        Task<ICollection<T>> GetAllAsync(CancellationToken cancellationToken);
        Task<ICollection<T>> GetAllAsync(Expression<Func<T, bool>> match);
        Task<ICollection<T>> GetAllAsync(CancellationToken cancellationToken, Expression<Func<T, bool>> match);
        #endregion [ Get Async ]

        #region [ Count Async ]
        Task<int> CountAsync();
        Task<int> CountAsync(Expression<Func<T, bool>> match);
        #endregion [ Count Async ]

        #region [ CRUD Async ]
        Task<bool> DeleteAsync(params object[] keyValues);
        Task<bool> DeleteAsync(CancellationToken cancellationToken, params object[] keyValues);
        #endregion [ CRUD Async ] 
    }
}
