namespace Readery.Models.Cart
{
    public class CartItemViewModel
    {
        public int BookId { get; set; }

        public string BookTitle { get; set; } = string.Empty;

        public string ImagePath { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public int Quantity { get; set; }
    }
}