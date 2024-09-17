using Microsoft.EntityFrameworkCore;
using Readery.Core.Contracts;
using Readery.Core.Models.Address;
using Readery.Core.Models.Author;
using Readery.Core.Models.Book;
using Readery.Core.Models.Publisher;
using Readery.Domain.Data.Common;
using Readery.Domain.Data.Models;
using Readery.Models.Cart;

namespace Readery.Core.Services
{
    public class BookService : IBookService
    {
        private readonly IRepository repository;

        public BookService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<bool> ExistsById(int id)
        {
            return await repository
                .GetAllReadOnly<Book>()
                .AnyAsync(b => b.Id == id);
        }

        public async Task<PaginationBookViewModel> GetAllBooksAsync(int page, string searchTerm)
        {
            int booksPerPage = 8;

            var model = new PaginationBookViewModel();
            model.TotalPages = (int)Math.Ceiling(await repository.GetAllReadOnly<Book>().Where(b => b.Title.ToLower().Contains(searchTerm.ToLower())).CountAsync() / (double)booksPerPage);
            model.CurrentPage = page;
            model.PageExists = page > 0 && page <= model.TotalPages;

            model.Books = await repository.GetAllReadOnly<Book>()
                .Where(b => b.IsRemoved == false && b.Title.ToLower().Contains(searchTerm.ToLower()))
                .OrderByDescending(b => b.AddedOn)
                .Skip((page - 1) * booksPerPage)
                .Take(booksPerPage)
                .Select(b => new BasicBookViewModel()
                {
                    Id = b.Id,
                    Title = b.Title,
                    AuthorName = $"{b.Author.FirstName} {b.Author.LastName}",
                    ImagePath = b.ImagePath,
                    Language = b.Language,
                    Price = b.Price
                })
                .ToListAsync();

            return model;
        }

        public async Task<DetailsViewModel> GetBookDetailsAsync(int id)
        {
            var book = await repository.GetAllReadOnly<Book>()
                .Where(b => b.Id == id)
                .Include(b => b.Author)
                    .ThenInclude(a => a.Address)
                        .ThenInclude(a => a.Country)
                .Include(b => b.Publisher)
                    .ThenInclude(p => p.Address)
                        .ThenInclude(a => a.Country)
                .FirstAsync();

            return new DetailsViewModel()
            {
                Id = book.Id,
                Title = book.Title,
                ShortDescription = string.Join("", book.Description.Take(120)),
                FullDescription = book.Description,
                ImagePath = book.ImagePath,
                Language = book.Language,
                PagesCount = book.PagesCount,
                Price = book.Price,
                WrittenOn = book.WrittenOn,
                Author = new AuthorViewModel()
                {
                    Id = book.Author.Id,
                    Age = DateTime.Now.Year - book.Author.BirthDate.Year,
                    Address = new AddressViewModel()
                    {
                        City = book.Author.Address.City,
                        Street = book.Author.Address.Street,
                        Country = book.Author.Address.Country.Name
                    }
                },
                AuthorName = $"{book.Author.FirstName} {book.Author.LastName}",
                Publisher = new PublisherViewModel()
                {
                    Name = book.Publisher.Name,
                    Email = book.Publisher.Email,
                    Id = book.Publisher.Id,
                    PhoneNumber = book.Publisher.PhoneNumber,
                    Address = new AddressViewModel()
                    {
                        City = book.Publisher.Address.City,
                        Country = book.Publisher.Address.Country.Name,
                        Street = book.Publisher.Address.Street
                    }
                }
            };
        }

        public async Task<CartItemViewModel> GetCartBookById(int id)
        {
            var book = await repository.GetByIdAsync<Book>(id);

            return new CartItemViewModel()
            {
                BookId = book!.Id,
                BookTitle = book.Title,
                ImagePath = book.ImagePath,
                Price = book.Price,
                Quantity = 1
            };
        }
    }
}
