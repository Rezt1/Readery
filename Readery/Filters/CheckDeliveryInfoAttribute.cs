using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Readery.Core.Models.Order;
using Readery.Extenstions;
using System.ComponentModel.DataAnnotations;

namespace Readery.Filters
{
    public class CheckDeliveryInfoAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var info = context.HttpContext.Session.GetObjectFromJson<DeliveryInformationViewModel>(nameof(DeliveryInformationViewModel));

            if (info == null)
            {
                context.Result = new RedirectToActionResult("Index", "Order", null);
            }
            else
            {
                var validationResults = new List<ValidationResult>();
                var validationContext = new ValidationContext(info);

                bool isValid = Validator.TryValidateObject(info, validationContext, validationResults);

                if (!isValid) 
                {
                    context.Result = new RedirectToActionResult("Index", "Order", null);
                }
                else
                {
                    base.OnActionExecuting(context);
                }
            }

        }
    }
}
