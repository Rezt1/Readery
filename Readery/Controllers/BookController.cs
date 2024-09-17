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

        [HttpGet]
        public async Task<IActionResult> All(int page = 1, string searchTerm = "")
        {
            var paginationModel = await bookService.GetAllBooksAsync(page, searchTerm);

            if (paginationModel.TotalPages != 0 && !paginationModel.PageExists)
            {
                return RedirectToAction(nameof(All));
            }

            ViewData["PageTitle"] = "Latest added books";

            return View(paginationModel);
        }

        [HttpGet]
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
