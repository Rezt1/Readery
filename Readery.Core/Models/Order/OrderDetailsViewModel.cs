using Readery.Models.Cart;

namespace Readery.Core.Models.Order
{
    public class OrderDetailsViewModel : HistoryViewModel
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public string Street { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;

        public string ZipCode { get; set; } = string.Empty;

        public string Country { get; set; } = string.Empty;

        public List<CartItemViewModel> items { get; set; } = new List<CartItemViewModel>();
    }
}
