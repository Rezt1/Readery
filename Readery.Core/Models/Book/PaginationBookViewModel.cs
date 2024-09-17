namespace Readery.Core.Models.Book
{
    public class PaginationBookViewModel
    {
        public int CurrentPage { get; set; }

        public int TotalPages { get; set; }

        public bool PageExists { get; set; }

        public List<BasicBookViewModel> Books { get; set; } = new List<BasicBookViewModel>();
    }
}
