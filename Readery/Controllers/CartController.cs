using Microsoft.AspNetCore.Mvc;
using Readery.Core.Contracts;
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
        public IActionResult Items()
        {
            var cart = HttpContext.Session.GetObjectFromJson<Cart>(nameof(Cart)) ?? new Cart();

            return View(cart);
        }

        [HttpPost]
        public async Task<IActionResult> AddToCart(int id)
        {
            if (!await bookService.ExistsById(id))
            {
                return BadRequest();
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
                return BadRequest();
            }

            cart.Items.Remove(item);

            HttpContext.Session.SetObjectAsJson(nameof(Cart), cart);

            return RedirectToAction(nameof(Items));
        }

        public IActionResult SetCartItemCount(int id,  int count)
        {
            return RedirectToAction(nameof(Items));
        }
    }
}
