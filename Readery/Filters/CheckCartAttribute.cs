using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Readery.Extenstions;
using Readery.Models.Cart;

namespace Readery.Filters
{
    public class CheckCartAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var cart = context.HttpContext.Session.GetObjectFromJson<Cart>(nameof(Cart));

            if (cart == null || !cart.Items.Any())
            {
                context.Result = new RedirectToActionResult("Index", "Cart", null);
            }
            else
            {
                base.OnActionExecuting(context);
            }

        }
    }
}
