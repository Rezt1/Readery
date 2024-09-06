namespace Readery.Models.Cart
{
    public class Cart
    {
        public List<CartItemViewModel> Items { get; set; } = new List<CartItemViewModel>();

        public decimal TotalPrice => Items.Sum(i => i.Price * i.Quantity);
    }
}
