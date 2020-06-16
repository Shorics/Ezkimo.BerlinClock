using BCException = Ezkimo.BerlinClock.Exceptions;
using System;
using System.Globalization;

namespace Ezkimo.BerlinClock
{
    public class Helper
    {
        public static TimeSpan ParseInput(string input)
        {
            try
            {
                return TimeSpan.ParseExact(input, "hh\\:mm\\:ss", CultureInfo.InvariantCulture);
            }
            catch (System.FormatException e)
            {
                throw new BCException.FormatException(e);
            }
        }
    }
}