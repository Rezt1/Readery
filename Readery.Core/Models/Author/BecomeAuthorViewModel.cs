using Readery.Core.Models.Country;
using System.ComponentModel.DataAnnotations;
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
        [RegularExpression(@"(0[1-9]|[12][0-9]|3[01])\/(0[1-9]|1[0,1,2])\/(19|20)\d{2}", ErrorMessage = InvalidDateMessage)]
        [Display(Name = "Birth date")]
        public string BirthDate { get; set; } = string.Empty;

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
        public int CountryId { get; set; }

        public List<CountryViewModel> Countries { get; set; } = new List<CountryViewModel>();
    }
}
