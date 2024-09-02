using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Readery.Domain.Data;
using Readery.Models.Address;
using Readery.Models.Author;
using Readery.Models.Book;
using Readery.Models.Publisher;

namespace Readery.Controllers
{
    public class BookController : Controller
    {
        private readonly ReaderyDbContext context;

        public BookController(ReaderyDbContext _context)
        {
            context = _context;
        }

        public async Task<IActionResult> All()
        {
            var books = await context.Books
                .AsNoTracking()
                .Select(b => new BasicBookViewModel()
                {
                    Id = b.Id,
                    Title = b.Title,
                    AuthorName = $"{b.Author.FirstName} {b.Author.LastName}",
                    ImagePath = b.ImagePath,
                    Language = b.Language,
                    Price = b.Price,
                })
                .ToListAsync();

            return View(books);
        }

        public async Task<IActionResult> Details(int id)
        {
            var book = await context.Books
                .AsNoTracking()
                .Include(b => b.Author)
                    .ThenInclude(a => a.Address)
                        .ThenInclude(a => a.Country)
                .Include(b => b.Publisher)
                    .ThenInclude(p => p.Address)
                        .ThenInclude(a => a.Country)
                .FirstOrDefaultAsync(b => b.Id == id);

            if (book == null)
            {
                return NotFound();
            }

            var details = new DetailsViewModel()
            {
                Id = book.Id,
                Title = book.Title,
                Description = book.Description,
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

            return View(details);
        }
    }
}
