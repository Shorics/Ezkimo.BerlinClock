using BCException = Ezkimo.BerlinClock.Exceptions;
using System;
using System.Globalization;

namespace Ezkimo.BerlinClock
{
    /// <summary>
    /// Helper class to process clock related IO.
    /// </summary>
    public class Helper
    {
        /// <summary>
        /// Parses an input string in format "hh:mm:ss" into a <c>TimeSpan</c>.
        /// </summary>
        /// <param name="input">Input string.</param>
        /// <returns>Input string as TimeSpan</returns>
        /// <exception cref="Ezkimo.BerlinClock.Exceptions.FormatException">
        /// Thrown if input string is not in format "hh:mm:ss".
        /// </exception>
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