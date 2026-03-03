using Microsoft.EntityFrameworkCore;
using Readery.Core.Contracts;
using Readery.Core.Models.Address;
using Readery.Core.Models.Publisher;
using Readery.Domain.Data.Common;
using Readery.Domain.Data.Models;

namespace Readery.Core.Services
{
	public class PublisherService : IPublisherService
	{
		private readonly IRepository repository;

        public PublisherService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<List<PublisherViewModel>> GetPublishersAsync()
		{
			return await repository
				.GetAllReadOnly<Publisher>()
				.Select(p => new PublisherViewModel()
				{
					Id = p.Id,
					Name = p.Name,
					Email = p.Email,
					PhoneNumber = p.PhoneNumber,
					Address = new AddressViewModel()
					{
						Street = p.Address.Street,
						City = p.Address.City,
						Country = p.Address.Country.Name
					}
				})
				.ToListAsync();
		}
	}
}
