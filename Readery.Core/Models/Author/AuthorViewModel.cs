using Readery.Core.Models.Address;

namespace Readery.Core.Models.Author
{
    public class AuthorViewModel
    {
        public int Id { get; set; }

        public int Age { get; set; }

        public AddressViewModel Address { get; set; } = null!;
    }
}
