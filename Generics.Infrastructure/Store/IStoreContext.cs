using Generics.Infrastructure.Domain;
using System;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace Generics.Infrastructure.Store
{
    public interface IStoreContext : IDisposable
    {
        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        Task<int> SaveChangesAsync();
        void SyncObjectState<T>(T entity) where T : Entity;
        void SyncObjectsStatePostCommit();
        void BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.Unspecified);
        IDbTransaction StartTransaction(IsolationLevel isolationLevel = IsolationLevel.Unspecified);
    }
}
