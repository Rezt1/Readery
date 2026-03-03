using Readery.Core.Models.Address;
using System.ComponentModel.DataAnnotations;
using static Readery.Domain.Data.Constants.PublisherConstants;
using static Readery.Core.ValidationMessages.BasicValidationMessages;

namespace Readery.Core.Models.Publisher
{
	public class AddPublisherViewModel
	{
		[Required(ErrorMessage = RequiredMessage)]
		[StringLength(NameMaxLength,
			MinimumLength = NameMinLength,
			ErrorMessage = InvalidLengthMessage)] 
		public string Name { get; set; } = string.Empty;

		[Required(ErrorMessage = RequiredMessage)]
		[StringLength(NameMaxLength,
			MinimumLength = NameMinLength,
			ErrorMessage = InvalidLengthMessage)]
		[EmailAddress(ErrorMessage = InvalidEmailMessage)]
		public string Email { get; set; } = string.Empty;

		[Required(ErrorMessage = RequiredMessage)]
		[StringLength(PhoneNumberMaxLength,
			MinimumLength = PhoneNumberMinLength,
			ErrorMessage = InvalidLengthMessage)]
		[Display(Name = "Phone number")]
		public string PhoneNumber { get; set; } = string.Empty;

		public AddAddressViewModel Address { get; set; } = new AddAddressViewModel();
	}
}
