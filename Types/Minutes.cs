using System;

namespace Ezkimo.BerlinClock.Types
{
    public struct Minutes
    {
        public int UpperValue { get; }
        public int LowerValue { get; }

        public Minutes(TimeSpan time)
        {
            LowerValue = time.Minutes % 5;
            UpperValue = time.Minutes / 5;
        }

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