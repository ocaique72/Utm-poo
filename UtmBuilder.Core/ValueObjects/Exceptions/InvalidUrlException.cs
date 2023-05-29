using System.Text.RegularExpressions;

namespace UtmBuilder.Core.ValueObjects.Exceptions;

public partial class InvalidUrlException : Exception
{
    private const string UrlRegexPattern = "^https?:\\/\\/(?:www\\.)?[-a-zA-Z0-9@:%._\\+~#=]{1,256}\\.[a-zA-Z0-9()]{1,6}\\b(?:[-a-zA-Z0-9()@:%_\\+.~#?&\\/=]*)$";
    private const string DefaultErrorMessage = "Invalid URL";

    public InvalidUrlException(string message = DefaultErrorMessage)
        : base(message)
    {
    }

    public static void ThrowIfInvalidUrl(
        string adress,
        string message = DefaultErrorMessage)
    {
        if (string.IsNullOrEmpty(adress))
        {
            throw new InvalidUrlException(message);
        }
        if (!Regex.IsMatch(adress, UrlRegexPattern))
        {
            throw new InvalidUrlException();
        }
    }
}