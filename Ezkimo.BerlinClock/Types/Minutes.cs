using System;

namespace Ezkimo.BerlinClock.Types
{
    /// <summary>
    /// Represents minutes of the Berlin Clock.
    /// </summary>
    public struct Minutes
    {
        /// <value>Represents upper active lights of Berlin Clock's minutes.</value>
        public int UpperValue { get; }

        /// <value>Represents lower active lights of Berlin Clock's minutes.</value>
        public int LowerValue { get; }

        /// <summary>
        /// Extracts minutes from a <c>TimeSpan</c> and calculates number of active 
        /// lights in upper and lower row of the Berlin Clock.
        /// </summary>
        /// <param name="time">TimeSpan</param>
        public Minutes(TimeSpan time)
        {
            LowerValue = time.Minutes % 5;
            UpperValue = time.Minutes / 5;
        }

        /// <summary>
        /// Converts the numeric value of this instance to its equivalent string representation.
        /// </summary>
        /// <returns>The string.</returns>
        public override string ToString()
        {
            string lower = "".PadLeft(LowerValue, 'Y').PadRight(4, 'O');
            string upper = "";

            for (int i = 0; i < UpperValue; i++)
            {
                if (0 == (i + 1) % 3)
                {
                    upper += "R";
                }
                else
                {
                    upper += "Y";
                }
            }

            upper = upper.PadRight(11, 'O');

            return $"{upper}\n{lower}";
        }
    }
}