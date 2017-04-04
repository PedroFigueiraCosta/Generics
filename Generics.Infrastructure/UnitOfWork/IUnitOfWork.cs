using Generics.Infrastructure.Domain;
using Generics.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Generics.Infrastructure.UnitOfWork
{
    public interface IUnitOfWork
    {
        int SaveChanges();
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        bool Commit();
        void BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.Unspecified);
        void Rollback();
        IRepository<T> RepositoryFactory<T>() where T : Entity;
    }
}
