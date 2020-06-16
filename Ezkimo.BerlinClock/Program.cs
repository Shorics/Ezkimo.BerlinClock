using Ezkimo.BerlinClock.Types;
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
            Hours hours = new Hours(time);
            Minutes minutes = new Minutes(time);
            Seconds seconds = new Seconds(time);

            return seconds.ToString() + "\n" + hours.ToString() + "\n" + minutes.ToString();
        }
    }
}
