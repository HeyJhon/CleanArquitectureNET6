using Entities.Interfaces;
using RepositoryEFCore.DataContext;

namespace RepositoryEFCore.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly Context _context;
        public UnitOfWork(Context context)
        {
            this._context = context;
        }
        public Task<int> SaveChanges()
        {
           return _context.SaveChangesAsync();
        }
    }
}
