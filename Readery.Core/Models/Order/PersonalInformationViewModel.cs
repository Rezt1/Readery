using System.ComponentModel.DataAnnotations;
using static Readery.Core.ValidationMessages.BasicValidationMessages;
using static Readery.Domain.Data.Constants.PersonalDeliveryInformationConstants;

namespace Readery.Core.Models.Order
{
    public class PersonalInformationViewModel
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
    }
}
