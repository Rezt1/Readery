using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Readery.Data;
using Readery.Models;
using System.Diagnostics;

namespace Readery.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ReaderyDbContext context;

        public HomeController(ILogger<HomeController> logger, ReaderyDbContext _context)
        {
            _logger = logger;
            context = _context;
        }

        public IActionResult Index()
        {
            Console.WriteLine(context.Books.Include(b => b.Author).First().Author.FirstName);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
