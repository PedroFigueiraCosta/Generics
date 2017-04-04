using System;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
using Generics.Infrastructure.Domain;
using Generics.Infrastructure.Repository;

// The Unit of Work let the repositories delegate all of their work to a Unit of Work, and then the Unit of Work
// then makes all necessary database calls (or other types of resource calls) on behalf of the
// repositories(Nilsson, Applying Domain - Driven Design and Patterns, With Examples in C# and .NET , 200).
// One major benefit of this approach is that the messages sent to the Unit of Work are invisible to the consumer of the repositories
// since the repositories are reporting what has been asked of them to the Unit of Work.
// This also helps promote persistence ignorance in the domain objects

// UoW enables the change tracking of multiple aggregations of domain entities and the persistence of them in one atomic operation,
// ensuring a valid business domain.


namespace Generics.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork()
        {

        }


        public void BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.Unspecified)
        {
            throw new NotImplementedException();
        }

        public bool Commit()
        {
            throw new NotImplementedException();
        }

        public IRepository<T> RepositoryFactory<T>() where T : Entity
        {
            throw new NotImplementedException();
        }

        public void Rollback()
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
