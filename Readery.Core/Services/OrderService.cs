using Readery.Core.Contracts;
using Readery.Core.Models.Order;
using Readery.Domain.Data.Common;
using Readery.Domain.Data.Models;

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

        public async Task<DeliveryInformationViewModel> GetDeliveryInfoAsync(string id)
        {
            //TODO: catch exception
            var user = await repository.GetByIdAsync<ApplicationUser>(Guid.Parse(id)) ?? throw new Exception();

            var info = new DeliveryInformationViewModel();

            if (user.DeliveryInformation.Any())
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

            info.Countries = await countryService.GetCountriesAsync();

            return info;
        }
    }
}
