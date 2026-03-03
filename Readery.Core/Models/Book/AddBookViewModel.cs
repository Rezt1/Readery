using System.ComponentModel.DataAnnotations;
using static Readery.Domain.Data.Constants.BookConstants;
using static Readery.Core.ValidationMessages.BasicValidationMessages;
using static Readery.Core.Common.RegexPatterns;
using Readery.Core.Models.Publisher;
using Microsoft.AspNetCore.Http;

namespace Readery.Core.Models.Book
{
	public class AddBookViewModel
	{
		[Required(ErrorMessage = RequiredMessage)]
		[StringLength(TitleMaxLength,
			MinimumLength = TitleMinLength,
			ErrorMessage = InvalidLengthMessage)]
		public string Title { get; set; } = string.Empty;

		[Required(ErrorMessage = RequiredMessage)]
		[StringLength(DescriptionMaxLength,
			MinimumLength = DescriptionMinLength,
			ErrorMessage = InvalidLengthMessage)]
		public string Description { get; set; } = string.Empty;

		[Required(ErrorMessage = RequiredMessage)]
		[Range(PagesMinCount, PagesMaxCount, ErrorMessage = InvalidRangeMessage)]
		[Display(Name = "Number of pages")]
		public int PagesCount { get; set; }

		[Required(ErrorMessage = RequiredMessage)]
		[StringLength(LanguageMaxLength,
			MinimumLength = LanguageMinLength,
			ErrorMessage = InvalidLengthMessage)]
		public string Language { get; set; } = string.Empty;

		[Required(ErrorMessage = RequiredMessage)]
		[Range(typeof(decimal), PriceMinValue, PriceMaxValue, ErrorMessage = InvalidRangeMessage)]
		public decimal Price { get; set; }

		[Required(ErrorMessage = ImageRequiredMessage)]
		[DataType(DataType.Upload)]
		[FileExtensions(Extensions = "jpg,jpeg,png", ErrorMessage = WrongExtenstionMessage)]
		public IFormFile Image { get; set; } = null!;

		[Required(ErrorMessage = RequiredMessage)]
		[RegularExpression(DateFormatPattern, ErrorMessage = InvalidDateMessage)]
		[Display(Name = "Creation date")]
		public string WrittenOn { get; set; } = string.Empty;

		public AddPublisherViewModel Publisher { get; set; } = new AddPublisherViewModel();

		public bool NeedNewPublisher { get; set; }

		[Required(ErrorMessage = RequiredMessage)]
		[Display(Name = "Publisher")]
		public int? PublisherId { get; set; }

		public List<PublisherViewModel> Publishers { get; set; } = new List<PublisherViewModel>();
	}
}
