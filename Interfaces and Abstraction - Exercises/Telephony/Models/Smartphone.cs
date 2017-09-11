using System.Linq;
using Telephony.Interfaces;

namespace Telephony.Models
{
    public class Smartphone : ICallable, IBrowsable
    {
        public string Call(string number)
        {
            bool allCharactersAreDigits = number.All(char.IsDigit);
            if (!allCharactersAreDigits)
            {
                return "Invalid number!";
            }
            return $"Calling... {number}";
        }

        public string Browse(string url)
        {
            bool containsDigit = url.Any(char.IsDigit);
            if (containsDigit)
            {
                return "Invalid URL!";
            }
            return $"Browsing: {url}!";
        }
    }
}

