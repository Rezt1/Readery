using Readery.Core.Models.Author;
using Readery.Core.Models.Publisher;

namespace Readery.Core.Models.Book
{
    public class DetailsViewModel : BasicBookViewModel
    {
        public string FullDescription { get; set; } = string.Empty;

        public string ShortDescription { get; set; } = string.Empty;

        public int PagesCount { get; set; }

        public DateTime WrittenOn { get; set; }

        public AuthorViewModel Author { get; set; } = null!;

        public PublisherViewModel Publisher { get; set; } = null!;
    }
}
