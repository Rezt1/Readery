using Readery.Core.Models.Country;
using Readery.Core.Models.Order;
using Readery.Models.Cart;

namespace Readery.Core.Contracts
{
    public interface IOrderService
    {
        public Task<DeliveryInformationViewModel> GetDeliveryInfoAsync(string id);

        public Task<List<CountryViewModel>> LoadCountriesAsync();

        public Task CreateOrderAsync(Cart cart, DeliveryInformationViewModel deliveryInfo, string id);

        public Task<List<HistoryViewModel>> GetOrdersByUserAsync(string userId);

        public Task<bool> ExistsAsync(int id);

        public Task<bool> IsByUserAsync(string userId, int orderId);

        public Task<OrderDetailsViewModel> GetOrderDetailsAsync(int id);
    }
}
