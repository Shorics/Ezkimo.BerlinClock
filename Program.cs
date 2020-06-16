using System;
using System.Globalization;

namespace Ezkimo.BerlinClock
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            TimeSpan time;

            Console.WriteLine("Enter time (format: hh:mm:ss):");
            input = Console.ReadLine();

            if (!TimeSpan.TryParseExact(input, "hh\\:mm\\:ss", CultureInfo.InvariantCulture, out time)) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Invalid input format");
                return;
            }

            string clock = FormatBerlinClock(time);

            Console.WriteLine("\nBerlin Clock:\n{0}", clock);

            return;
        }

        static string FormatBerlinClock(TimeSpan time)
        {
            int[] hours = GetBCHours(time);
            int[] minutes = GetBCMinutes(time);
            bool isSecondsEven = GetBCSeconds(time);
            string clock = isSecondsEven ? "Y\n" : "O\n";
            string tmp = "";

            foreach(int h in hours)
            {
                for (int i = 0; i < h; i++)
                {
                    tmp += "R";
                }

                tmp = tmp.PadRight(4, 'O');
                clock += tmp + "\n";
                tmp = "";
            }


            for (int i = 0; i < minutes[0]; i++)
            {
                if (0 == (i + 1) % 3)
                {
                    tmp += "R";
                }
                else
                {
                    tmp += "Y";
                }
            }

            tmp = tmp.PadRight(11, 'O');
            clock += tmp.PadRight(11, 'O') + "\n";
            tmp = "";

            for (int i = 0; i < minutes[1]; i++)
            {
                tmp += "Y";
            }

            tmp = tmp.PadRight(4, 'O');
            clock += tmp;

            return clock;
        }

        static bool GetBCSeconds(TimeSpan time)
        {
            int seconds = time.Seconds;

            return 0 == seconds % 2;
        }

        static int[] GetBCMinutes(TimeSpan time)
        {
            int minutes = time.Minutes;
            int[] bcMinutes = new int[2];

            bcMinutes[0] = minutes / 5;
            bcMinutes[1] = minutes % 5;

            return bcMinutes;
        }

        static int[] GetBCHours(TimeSpan time)
        {
            int digits = time.Hours.ToString().Length;
            int hours = time.Hours;
            int[] bcHours = new int[2];

            for (int i = 0; i < digits; i++)
            {
                bcHours[i] = (hours % 5);
                hours = hours / 5;
            }

            Array.Reverse<int>(bcHours);

            return bcHours;
        }
    }
}
