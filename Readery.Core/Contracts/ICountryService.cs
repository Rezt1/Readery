using Readery.Core.Models.Country;

namespace Readery.Core.Contracts
{
    public interface ICountryService
    {
        public Task<List<CountryViewModel>> GetCountriesAsync();
    }
}
