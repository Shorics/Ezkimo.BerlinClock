using System;

namespace Ezkimo.BerlinClock.Types
{
    /// <summary>
    /// Represents hours of the Berlin Clock.
    /// </summary>
    public struct Hours
    {
        /// <value>Represents upper active lights of Berlin Clock's hours.</value>
        public int UpperValue { get; }

        /// <value>Represents lower active lights of Berlin Clock's hours.</value>
        public int LowerValue { get; }

        /// <summary>
        /// Extracts hours from a <c>TimeSpan</c> and calculates number of active 
        /// lights in upper and lower row of the Berlin Clock.
        /// </summary>
        /// <param name="time">TimeSpan</param>
        public Hours(TimeSpan time)
        {
            int digits = time.Hours.ToString().Length;
            int hours = time.Hours;
            int[] values = new int[2];

            for (int i = 0; i < digits; i++)
            {
                values[i] = (hours % 5);
                hours = hours / 5;
            }

            LowerValue = values[0];
            UpperValue = values[1];
        }

        /// <summary>
        /// Converts the numeric value of this instance to its equivalent string representation.
        /// </summary>
        /// <returns>The string.</returns>
        public override string ToString()
        {
            string lower = "".PadLeft(LowerValue, 'R').PadRight(4, 'O');
            string upper = "".PadLeft(UpperValue, 'R').PadRight(4, 'O');

            return $"{upper}\n{lower}";
        }
    }
}