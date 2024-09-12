using Readery.Models.Cart;

namespace Readery.Core.Models.Order
{
    public class SummaryViewModel
    {
        public Cart Cart { get; set; } = null!;

        public DeliveryInformationViewModel DeliveryInformation { get; set; } = null!;
    }
}
