using Readery.Models.Address;
using Readery.Models.Book;

namespace Readery.Models.Author
{
    public class AuthorViewModel
    {
        public int Id { get; set; }

        public int Age { get; set; }

        public AddressViewModel Address { get; set; } = null!;
    }
}
