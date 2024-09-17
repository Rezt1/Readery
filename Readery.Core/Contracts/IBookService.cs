using Readery.Core.Models.Book;
using Readery.Models.Cart;

namespace Readery.Core.Contracts
{
    public interface IBookService
    {
        public Task<PaginationBookViewModel> GetAllBooksAsync(int id, string searchTerm);

        public Task<DetailsViewModel> GetBookDetailsAsync(int id);

        public Task<bool> ExistsById(int id);

        public Task<CartItemViewModel> GetCartBookById(int id);
    }
}
