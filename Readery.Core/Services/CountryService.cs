using Microsoft.EntityFrameworkCore;
using Readery.Core.Contracts;
using Readery.Core.Models.Country;
using Readery.Domain.Data.Common;
using Readery.Domain.Data.Models;

namespace Readery.Core.Services
{
    public class CountryService : ICountryService
    {
        private readonly IRepository repository;

        public CountryService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<List<CountryViewModel>> GetCountriesAsync()
        {
            return await repository.GetAllReadOnly<Country>()
                    .Select(c => new CountryViewModel()
                    {
                        Id = c.Id,
                        Name = c.Name,
                    })
                    .ToListAsync();
        }
    }
}
