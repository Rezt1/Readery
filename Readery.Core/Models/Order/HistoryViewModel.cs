namespace Readery.Core.Models.Order
{
    public class HistoryViewModel
    {
        public int Id { get; set; }

        public decimal TotalPrice { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
