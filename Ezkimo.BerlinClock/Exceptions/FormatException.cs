using Ezkimo.BerlinClock.Types;
using System;
using System.Globalization;
using BaseFormatException = System.FormatException;

namespace Ezkimo.BerlinClock.Exceptions
{
    /// <summary>
    /// Exception to be thrown on parsing error includes predefined message.
    /// </summary>
    public class FormatException : BaseFormatException
    {
        public override string Message { get; } = "Invalid input format. Required format: \"hh:mm:ss\"";

        public FormatException() : base() { }

        public FormatException(Exception inner) : base(null, inner)  { }
    }
}