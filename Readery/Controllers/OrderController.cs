using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Readery.Core.Contracts;
using Readery.Core.Models.Order;
using Readery.Domain.Data.Models;
using Readery.Extenstions;
using Readery.Models.Cart;
using System.Security.Claims;

namespace Readery.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IOrderService orderService;

        public OrderController(IOrderService _orderService)
        {
            orderService = _orderService;
        }

        public async Task<IActionResult> Index()
        {
            var cart = HttpContext.Session.GetObjectFromJson<Cart>(nameof(Cart));

            if (cart == null || !cart.Items.Any())
            {
                return RedirectToAction("Index", "Cart");
            }

            var info = await orderService.GetDeliveryInfoAsync(User.Id());
            
            return View(info);
        }
    }
}
