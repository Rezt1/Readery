using System.Reflection.Metadata;

namespace Readery.Core.ValidationMessages
{
    internal static class BasicValidationMessages
    {
        public const string InvalidLengthMessage = "{0} must be between {2} and {1} characters";

        public const string InvalidRangeMessage = "{0} must be in range {1} - {2}";

        public const string RequiredMessage = "{0} is required";

        public const string ImageRequiredMessage = "Please upload an image";

        public const string WrongExtenstionMessage = ".jpg .jpeg and .png only";

        public const string InvalidEmailMessage = "Invalid email address";

        public const string InvalidDateMessage = "Date format is incorrect";
    }
}
