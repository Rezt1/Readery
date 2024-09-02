using Readery.Models.Author;
using Readery.Models.Publisher;

namespace Readery.Models.Book
{
    public class DetailsViewModel : BasicBookViewModel
    {
        public string Description { get; set; } = string.Empty;

        public int PagesCount { get; set; }

        public DateTime WrittenOn { get; set; }

        public AuthorViewModel Author { get; set; } = null!;

        public PublisherViewModel Publisher { get; set; } = null!;
    }
}
