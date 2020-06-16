using Ezkimo.BerlinClock.Types;
using System;
using System.Globalization;

namespace Ezkimo.BerlinClock
{
    /// <summary>
    /// Main entry point.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Reads input time string from console, parses it and outputs time in
        /// Berlin Clock format.
        /// </summary>
        /// <param name="args">Commandline arguments.</param>
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

        /// <summary>
        /// Writes an exception message red colored to console window.
        /// </summary>
        /// <param name="e">Exception with message to write.</param>
        static void WriteError(Exception e)
        {
            var defaultColor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: {0}", e.Message);

            Console.ForegroundColor = defaultColor;
        }
    }
}
