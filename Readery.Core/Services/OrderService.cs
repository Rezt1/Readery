using Microsoft.EntityFrameworkCore;
using Readery.Core.Contracts;
using Readery.Core.Models.Country;
using Readery.Core.Models.Order;
using Readery.Domain.Data.Common;
using Readery.Domain.Data.Models;
using Readery.Models.Cart;
using System.Data;

namespace Readery.Core.Services
{
    public class OrderService : IOrderService
    {
        private readonly IRepository repository;
        private readonly ICountryService countryService;

        public OrderService(IRepository _repository, ICountryService _countryService)
        {
            repository = _repository;
            countryService = _countryService;
        }

        public async Task CreateOrderAsync(Cart cart, DeliveryInformationViewModel deliveryInfo, string id)
        {
            var user = await repository.GetByIdAsync<ApplicationUser>(Guid.Parse(id));
            user!.RememberDeliveryInfo = deliveryInfo.RememberDeliveryInfo;

            var order = new Order()
            {
                UserId = Guid.Parse(id),
                OrderDate = DateTime.Now,
                TotalPrice = cart.TotalPrice,
            };

            var latestDeliveryInformation = await repository
                .GetAll<DeliveryInformation>()
                .Where(di => di.UserId == Guid.Parse(id))
                .OrderByDescending(di => di.Version)
                .FirstOrDefaultAsync();

            var deliveryInformation = new DeliveryInformation();

            if (latestDeliveryInformation == null || !AreEqual(latestDeliveryInformation, deliveryInfo))
            {
                deliveryInformation.FirstName = deliveryInfo.FirstName;
                deliveryInformation.LastName = deliveryInfo.LastName;
                deliveryInformation.Email = deliveryInfo.Email;
                deliveryInformation.PhoneNumber = deliveryInfo.PhoneNumber;
                deliveryInformation.Street = deliveryInfo.Street;
                deliveryInformation.City = deliveryInfo.City;
                deliveryInformation.ZipCode = deliveryInfo.ZipCode;
                deliveryInformation.CountryId = deliveryInfo.CountryId;
                deliveryInformation.UserId = Guid.Parse(id);
                deliveryInformation.CreatedAt = DateTime.Now;
                deliveryInformation.Version = latestDeliveryInformation != null ? latestDeliveryInformation.Version + 1 : 1;

                await repository.AddAsync(deliveryInformation);

                order.DeliveryInformation = deliveryInformation;
            } 
            else
            {
                order.DeliveryInformation = latestDeliveryInformation;
            }

            await repository.AddAsync(order);

            var orderBooks = new List<OrderBook>();

            foreach (var item in cart.Items)
            {
                orderBooks.Add(new OrderBook()
                {
                    BookId = item.BookId,
                    Quantity = item.Quantity,
                    Price = item.Price,
                    Order = order,
                });
            }

            await repository.AddRangeAsync(orderBooks);
            await repository.SaveChangesAsync();
        }

        public async Task<DeliveryInformationViewModel> GetDeliveryInfoAsync(string id)
        {
            var user = await repository
                .GetAllReadOnly<ApplicationUser>()
                .Include(au => au.DeliveryInformation)
                .FirstOrDefaultAsync(au => au.Id == Guid.Parse(id));

            var info = new DeliveryInformationViewModel();

            if (user!.RememberDeliveryInfo && user.DeliveryInformation.Any())
            {
                var latestDeliveryInfo = user.DeliveryInformation.OrderByDescending(di => di.Version).First();

                info.FirstName = latestDeliveryInfo.FirstName;
                info.LastName = latestDeliveryInfo.LastName;
                info.Email = latestDeliveryInfo.Email;
                info.PhoneNumber = latestDeliveryInfo.PhoneNumber;
                info.City = latestDeliveryInfo.City;
                info.ZipCode = latestDeliveryInfo.ZipCode;
                info.Street = latestDeliveryInfo.Street;
                info.CountryId = latestDeliveryInfo.CountryId;
            }
            else
            {
                info.Email = user.Email;

                if (user.Author != null)
                {
                    info.PhoneNumber = user.PhoneNumber;
                    info.FirstName = user.Author.FirstName;
                    info.LastName = user.Author.LastName;
                }
            }

            info.Countries = await LoadCountriesAsync();

            return info;
        }

        public async Task<List<CountryViewModel>> LoadCountriesAsync() => await countryService.GetCountriesAsync();

        private bool AreEqual(DeliveryInformation di1, DeliveryInformationViewModel di2) =>
            di1.FirstName == di2.FirstName && di1.LastName == di2.LastName &&
            di1.Email == di2.Email && di1.PhoneNumber == di2.PhoneNumber &&
            di1.City == di2.City && di1.ZipCode == di2.ZipCode &&
            di1.Street == di2.Street && di1.CountryId == di2.CountryId;
    }
}
