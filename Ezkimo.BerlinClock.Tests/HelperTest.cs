using BCException = Ezkimo.BerlinClock.Exceptions;
using System;
using Xunit;

namespace Ezkimo.BerlinClock.Tests
{
    public class HelperTest
    {
        [Fact]
        public void ParseInput_ValueFormatCorrect_ReturnTimeSpan()
        {
            var result = Helper.ParseInput("12:20:40");

            Assert.IsType<TimeSpan>(result);
        }

        [Fact]
        public void ParseInput_ValueFormatIncorrect_ThrowBCFormatException()
        {
            Assert.Throws<BCException.FormatException>(() => Helper.ParseInput("12.20.40"));
        }
    }
}