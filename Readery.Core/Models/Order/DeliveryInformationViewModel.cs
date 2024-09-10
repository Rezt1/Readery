namespace Readery.Core.Models.Order
{
    public class DeliveryInformationViewModel
    {
        public PersonalInformationViewModel PersonalInformation { get; set; } = null!;

        public ShippingAddressViewModel ShippingAddress { get; set; } = null!;
    }
}
