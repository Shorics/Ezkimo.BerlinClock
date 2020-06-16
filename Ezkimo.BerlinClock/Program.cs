using Ezkimo.BerlinClock.Types;
using System;
using System.Globalization;

namespace Ezkimo.BerlinClock
{
    class Program
    {
        static void Main(string[] args)
        {
            string clock;
            string input;
            TimeSpan time;

            Console.WriteLine("Enter time (format: hh:mm:ss):");
            input = Console.ReadLine();

            try
            {
                time = Helper.ParseInput(input);
            }
            catch(Exception e)
            {
                WriteError(e);
                return;
            }

            clock = new Clock(time).ToString();
            Console.WriteLine("\nBerlin Clock:\n{0}", clock);
        }

        static void WriteError(Exception e)
        {
            var defaultColor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: {0}", e.Message);

            Console.ForegroundColor = defaultColor;
        }
    }
}
