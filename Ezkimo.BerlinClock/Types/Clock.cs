using System;

namespace Ezkimo.BerlinClock.Types
{
    public struct Clock
    {
        public Seconds Seconds { get; }
        public Minutes Minutes { get; }
        public Hours Hours { get; }

        public Clock(TimeSpan time)
        {
            Hours = new Hours(time);
            Minutes = new Minutes(time);
            Seconds = new Seconds(time);
        }

        public override string ToString()
        {
            return  Seconds.ToString() + "\n" + Hours.ToString() + "\n" + Minutes.ToString();
        }
    }
}