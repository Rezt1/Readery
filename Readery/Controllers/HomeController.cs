using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Readery.Core.Models.Order;
using Readery.Domain.Data;
using Readery.Extenstions;
using Readery.Models;
using Readery.Models.Cart;
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
            var cart = HttpContext.Session.GetObjectFromJson<Cart>(nameof(Cart));
            var deliveryInfo = HttpContext.Session.GetObjectFromJson<DeliveryInformationViewModel>(nameof(DeliveryInformationViewModel));

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
