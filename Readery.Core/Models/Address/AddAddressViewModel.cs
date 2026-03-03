using Readery.Core.Models.Country;
using System.ComponentModel.DataAnnotations;
using static Readery.Core.ValidationMessages.BasicValidationMessages;
using static Readery.Domain.Data.Constants.DeliveryInformationConstants;

namespace Readery.Core.Models.Address
{
	public class AddAddressViewModel
	{
		[Required(ErrorMessage = RequiredMessage)]
		[StringLength(StreetMaxLength,
			MinimumLength = StreetMinLength,
			ErrorMessage = InvalidLengthMessage)]
		public string Street { get; set; } = string.Empty;

		[Required(ErrorMessage = RequiredMessage)]
		[StringLength(CityMaxLength,
			MinimumLength = CityMinLength,
			ErrorMessage = InvalidLengthMessage)]
		public string City { get; set; } = string.Empty;

		[Required(ErrorMessage = RequiredMessage)]
		[Display(Name = "Country")]
		public int? CountryId { get; set; }

		public List<CountryViewModel> Countries { get; set; } = new List<CountryViewModel>();
	}
}
