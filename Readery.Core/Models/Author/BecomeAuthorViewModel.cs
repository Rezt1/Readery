using Readery.Core.Models.Address;
using System.ComponentModel.DataAnnotations;
using static Readery.Core.Common.RegexPatterns;
using static Readery.Core.ValidationMessages.BasicValidationMessages;
using static Readery.Domain.Data.Constants.DeliveryInformationConstants;

namespace Readery.Core.Models.Author
{
	public class BecomeAuthorViewModel
    {
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(FirstNameMaxLength,
            MinimumLength = FirstNameMinLength,
            ErrorMessage = InvalidLengthMessage)]
        [Display(Name = "Name")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(LastNameMaxLength,
            MinimumLength = LastNameMinLength,
            ErrorMessage = InvalidLengthMessage)]
        [Display(Name = "Surname")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(PhoneNumberMaxLength,
            MinimumLength = PhoneNumberMinLength,
            ErrorMessage = InvalidLengthMessage)]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [RegularExpression(DateFormatPattern, ErrorMessage = InvalidDateMessage)]
        [Display(Name = "Birth date")]
        public string BirthDate { get; set; } = string.Empty;

        public AddAddressViewModel Address { get; set; } = null!;
    }
}
