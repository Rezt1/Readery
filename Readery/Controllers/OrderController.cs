using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Readery.Core.Contracts;
using Readery.Core.Models.Order;
using Readery.Extenstions;
using Readery.Filters;
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

        [HttpGet]
        [CheckCart]
        public async Task<IActionResult> Index()
        {
            var info = HttpContext.Session.GetObjectFromJson<DeliveryInformationViewModel>(nameof(DeliveryInformationViewModel)) 
                ?? await orderService.GetDeliveryInfoAsync(User.Id());

            return View(info);
        }

        [HttpPost]
        [CheckCart]
        public async Task<IActionResult> Index(DeliveryInformationViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            model.Countries = await orderService.LoadCountriesAsync();

            HttpContext.Session.SetObjectAsJson(nameof(DeliveryInformationViewModel), model);

            return RedirectToAction(nameof(Summary));
        }

        [HttpGet]
        [CheckCart]
        [CheckDeliveryInfo]
        public IActionResult Summary()
        {
            var cart = HttpContext.Session.GetObjectFromJson<Cart>(nameof(Cart));
            var deliveryInfo = HttpContext.Session.GetObjectFromJson<DeliveryInformationViewModel>(nameof(DeliveryInformationViewModel));

            var summary = new SummaryViewModel()
            {
                Cart = cart!,
                DeliveryInformation = deliveryInfo!
            };

            return View(summary);
        }

        [HttpPost]
        [CheckCart]
        [CheckDeliveryInfo]
        public async Task<IActionResult> SummaryPost()
        {
            var cart = HttpContext.Session.GetObjectFromJson<Cart>(nameof(Cart));
            var deliveryInfo = HttpContext.Session.GetObjectFromJson<DeliveryInformationViewModel>(nameof(DeliveryInformationViewModel));

            await orderService.CreateOrderAsync(cart!, deliveryInfo!, User.Id());

            HttpContext.Session.Remove(nameof(Cart));
            HttpContext.Session.Remove(nameof(DeliveryInformationViewModel));

            return RedirectToAction("Index", "Home");
        }
    }
}
