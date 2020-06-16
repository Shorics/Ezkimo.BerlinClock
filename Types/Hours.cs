using System;

namespace Ezkimo.BerlinClock.Types
{
    public struct Hours
    {
        public int UpperValue { get; }
        public int LowerValue { get; }

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

        public override string ToString()
        {
            string lower = "".PadLeft(LowerValue, 'R').PadRight(4, 'O');
            string upper = "".PadLeft(UpperValue, 'R').PadRight(4, 'O');

            return $"{upper}\n{lower}";
        }
    }
}