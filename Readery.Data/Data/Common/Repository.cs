using Microsoft.EntityFrameworkCore;

namespace Readery.Domain.Data.Common
{
    public class Repository : IRepository
    {
        private readonly DbContext context;

        public Repository(ReaderyDbContext _context)
        {
            context = _context;
        }

        public IQueryable<T> GetAll<T>() where T : class
        {
            return GetDbSet<T>();
        }

        public IQueryable<T> GetAllReadOnly<T>() where T : class
        {
            return GetDbSet<T>()
                .AsNoTracking();
        }

        public async Task<T?> GetByIdAsync<T>(object id) where T : class
        {
            return await GetDbSet<T>().FindAsync(id);
        }

        public Task<int> SaveChangesAsync()
        {
            return context.SaveChangesAsync();
        }

        private DbSet<T> GetDbSet<T>() where T : class
        {
            return context.Set<T>();
        }
    }
}
