using Readery.Core.Models.Order;

namespace Readery.Core.Contracts
{
    public interface IOrderService
    {
        public Task<DeliveryInformationViewModel> GetDeliveryInfoAsync(string id);
    }
}
