namespace Readery.Domain.Data.Constants
{
	public static class BookConstants
	{
		public const int TitleMinLength = 2;
		public const int TitleMaxLength = 100;

		public const int DescriptionMinLength = 20;
		public const int DescriptionMaxLength = 1000;

		public const int PagesMinCount = 5;
		public const int PagesMaxCount = 10000;

		public const int LanguageMinLength = 2;
		public const int LanguageMaxLength = 20;

		public const string PriceMinValue = "0.00";
		public const string PriceMaxValue = "1000000";

		public const int ImagePathMaxLength = 200;
	}
}
