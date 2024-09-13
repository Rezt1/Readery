using Microsoft.AspNetCore.Mvc;
using Readery.Core.Contracts;
using Readery.Core.Models.Order;
using Readery.Extenstions;
using Readery.Models.Cart;

namespace Readery.Controllers
{
    public class CartController : Controller
    {
        private readonly IBookService bookService;

        public CartController(IBookService _bookService)
        {
            bookService = _bookService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var cart = HttpContext.Session.GetObjectFromJson<Cart>(nameof(Cart)) ?? new Cart();

            return View(cart);
        }

        [HttpPost]
        public async Task<IActionResult> AddToCart(int id)
        {
            if (!await bookService.ExistsById(id))
            {
                return NotFound();
            }

            var cart = HttpContext.Session.GetObjectFromJson<Cart>("Cart") ?? new Cart();

            var existingItem = cart.Items.FirstOrDefault(i => i.BookId == id);

            if (existingItem != null)
            {
                existingItem.Quantity++;
            } 
            else
            {
                cart.Items.Add(await bookService.GetCartBookById(id));
            }

            HttpContext.Session.SetObjectAsJson("Cart", cart);

            return Json(new {itemsCount = cart.Items.Sum(i => i.Quantity)});
        }

        [HttpGet]
        public IActionResult GetCartCount()
        {
            var cart = HttpContext.Session.GetObjectFromJson<Cart>(nameof(Cart));
            var itemCount = cart?.Items.Sum(x => x.Quantity) ?? 0;
            return Json(new { count = itemCount });
        }

        [HttpPost]
        public IActionResult DeleteItem(int id)
        {
            var cart = HttpContext.Session.GetObjectFromJson<Cart>(nameof(Cart)) ?? null;

            if (cart == null)
            {
                return BadRequest();
            }

            var item = cart.Items.FirstOrDefault(i => i.BookId == id);

            if (item == null)
            {
                return NotFound();
            }

            cart.Items.Remove(item);

            if (!cart.Items.Any())
            {
                var deliveryInfo = HttpContext.Session.GetObjectFromJson<DeliveryInformationViewModel>(nameof(DeliveryInformationViewModel));

                if (deliveryInfo != null)
                {
                    HttpContext.Session.Remove(nameof(DeliveryInformationViewModel));
                }
            }

            HttpContext.Session.SetObjectAsJson(nameof(Cart), cart);

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult SetCartItemCount(int id, int newCount)
        {
            var cart = HttpContext.Session.GetObjectFromJson<Cart>(nameof(Cart)) ?? null;

            if (cart == null)
            {
                return BadRequest();
            }

            var item = cart.Items.FirstOrDefault(i => i.BookId == id);

            if (item == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid && newCount > 0)
            {
                item.Quantity = newCount;
                HttpContext.Session.SetObjectAsJson(nameof(Cart), cart);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}