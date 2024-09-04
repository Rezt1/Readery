using Readery.Core.Models.Book;

namespace Readery.Core.Contracts
{
    public interface IBookService
    {
        public Task<List<BasicBookViewModel>> GetAllBooksAsync();

        public Task<DetailsViewModel> GetBookDetailsAsync(int id);

        public Task<bool> ExistsById(int id);
    }
}
