using System;

namespace Ezkimo.BerlinClock.Types
{
    /// <summary>
    /// Represents seconds of the Berlin Clock.
    /// </summary>
    public struct Seconds
    {
        /// <value>Represents whether light of Berlin Clock's second is active.</value>
        public bool Value { get; }

        /// <summary>
        /// Extracts seconds of a <c>TimeSpan</c> and checks whether they are active (even) 
        /// or inactive (uneven).
        /// </summary>
        /// <param name="time">TimeSpan</param>
        public Seconds(TimeSpan time)
        {
            Value = 0 == time.Seconds % 2;
        }

        /// <summary>
        /// Converts the numeric value of this instance to its equivalent string representation.
        /// </summary>
        /// <returns>The string.</returns>
        public override string ToString()
        {
            return Value ? "Y" : "O";
        }
    }
}