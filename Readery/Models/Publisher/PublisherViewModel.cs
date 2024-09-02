using Readery.Models.Address;

namespace Readery.Models.Publisher
{
    public class PublisherViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public AddressViewModel Address { get; set; } = null!;
    }
}
