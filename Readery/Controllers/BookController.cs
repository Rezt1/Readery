using Microsoft.AspNetCore.Mvc;
using Readery.Core.Contracts;

namespace Readery.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService bookService;

        public BookController(IBookService _bookService)
        {
            bookService = _bookService;
        }

        public async Task<IActionResult> All()
        {
            var books = await bookService.GetAllBooksAsync();

            return View(books);
        }

        public async Task<IActionResult> Details(int id)
        {
            if (!await bookService.ExistsById(id))
            {
                return NotFound();
            }

            var details = await bookService.GetBookDetailsAsync(id);

            return View(details);
        }
    }
}
