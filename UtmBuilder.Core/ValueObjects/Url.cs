using System.Text;
using System.Text.RegularExpressions;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.ValueObjects
{
    public class Url : ValueObject
    {

        /// <summary>
        // Create a new URL
        ///</summary>

        public Url(string adress)
        {
            Adress = adress;
            InvalidUrlException.ThrowIfInvalidUrl(adress);
        }

        /// <summary>
        ///Adress of URL (website link)
        ///</summary>

        public string Adress { get; }

    }
}