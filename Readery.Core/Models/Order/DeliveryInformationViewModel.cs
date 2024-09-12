using Readery.Core.Models.Country;
using System.ComponentModel.DataAnnotations;
using static Readery.Core.ValidationMessages.BasicValidationMessages;
using static Readery.Domain.Data.Constants.DeliveryInformationConstants;

namespace Readery.Core.Models.Order
{
    public class DeliveryInformationViewModel
    {
        public int Id { get; set; }

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
        [EmailAddress(ErrorMessage = InvalidEmailMessage)]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(PhoneNumberMaxLength,
            MinimumLength = PhoneNumberMinLength,
            ErrorMessage = InvalidLengthMessage)]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; } = string.Empty;

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
        [StringLength(ZipCodeMaxLength,
            MinimumLength = ZipCodeMinLength,
            ErrorMessage = InvalidLengthMessage)]
        [Display(Name = "Zip")]
        public string ZipCode { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Country")]
        public int CountryId { get; set; } 

        public List<CountryViewModel> Countries { get; set; } = new List<CountryViewModel>();
    }
}
