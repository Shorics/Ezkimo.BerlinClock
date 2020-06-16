using Ezkimo.BerlinClock.Types;
using System;
using System.Collections.Generic;
using Xunit;

namespace Ezkimo.BerlinClock.Tests.Types
{
    public class ClockTest
    {
        public static IEnumerable<object[]> GetTimeSpan_ExpectedString()
        {
            yield return new object[] { new TimeSpan(2, 37, 0), "Y\nOOOO\nRROO\nYYRYYRYOOOO\nYYOO" };
            yield return new object[] { new TimeSpan(13, 17, 2), "Y\nRROO\nRRRO\nYYROOOOOOOO\nYYOO" };
            yield return new object[] { new TimeSpan(20, 45, 34), "Y\nRRRR\nOOOO\nYYRYYRYYROO\nOOOO" };
            yield return new object[] { new TimeSpan(24, 59, 13), "O\nOOOO\nOOOO\nYYRYYRYYRYY\nYYYY" };
            yield return new object[] { new TimeSpan(0, 0, 0), "Y\nOOOO\nOOOO\nOOOOOOOOOOO\nOOOO" };
        }

        [Theory]
        [MemberData(nameof(GetTimeSpan_ExpectedString))]
        public void ToString_ValueEven_ReturnStingY(TimeSpan value, string expectedString)
        {
            var result = new Clock(value).ToString();

            Assert.Equal(expectedString, result);
        }
    }
}