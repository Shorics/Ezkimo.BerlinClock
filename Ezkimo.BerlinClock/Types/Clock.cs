using System;

namespace Ezkimo.BerlinClock.Types
{
    /// <summary>
    /// Represents full time of the Berlin Clock.
    /// </summary>
    public struct Clock
    {
        /// <value><see cref="Seconds" /></value>
        public Seconds Seconds { get; }

        /// <value><see cref="Minutes" /></value>
        public Minutes Minutes { get; }

        /// <value><see cref="Hours" /></value>
        public Hours Hours { get; }

        /// <summary>
        /// Forwards <c>TimeSpan</c> to <see cref="Hours" />, <see cref="Minutes" /> 
        /// and <see cref="Seconds" /> to calculate active lights of different rows of 
        /// the Berlin Clock.
        /// </summary>
        /// <param name="time">TimeSpan</param>
        public Clock(TimeSpan time)
        {
            Hours = new Hours(time);
            Minutes = new Minutes(time);
            Seconds = new Seconds(time);
        }

        /// <summary>
        /// Converts the numeric value of this instance to its equivalent string representation.
        /// </summary>
        /// <returns>The string.</returns>
        public override string ToString()
        {
            return  Seconds.ToString() + "\n" + Hours.ToString() + "\n" + Minutes.ToString();
        }
    }
}