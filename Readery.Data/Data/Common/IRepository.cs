namespace Readery.Domain.Data.Common
{
    public interface IRepository
    {
        public IQueryable<T> GetAll<T>() where T : class;

        public IQueryable<T> GetAllReadOnly<T>() where T : class;

        public Task<T?> GetByIdAsync<T>(int id) where T : class;

        public Task<int> SaveChangesAsync();
    }
}
