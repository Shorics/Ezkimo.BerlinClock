using System;

namespace Ezkimo.BerlinClock.Types
{
    public struct Seconds
    {
        public bool Value { get; }

        public Seconds(TimeSpan time)
        {
            Value = 0 == time.Seconds % 2;
        }

        public override string ToString()
        {
            return Value ? "Y" : "O";
        }
    }
}