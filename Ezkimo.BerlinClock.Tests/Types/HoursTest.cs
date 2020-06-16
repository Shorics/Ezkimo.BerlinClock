using Ezkimo.BerlinClock.Types;
using System;
using System.Collections.Generic;
using Xunit;

namespace Ezkimo.BerlinClock.Tests.Types
{
    public class HoursTest
    {
        public static IEnumerable<object[]> GetTimeSpans_ExpectedUpper()
        {
            yield return new object[] { new TimeSpan(2, 37, 0), 0 };
            yield return new object[] { new TimeSpan(13, 17, 2), 2 };
            yield return new object[] { new TimeSpan(20, 45, 34), 4 };
            yield return new object[] { new TimeSpan(24, 12, 13), 4 };
        }
        public static IEnumerable<object[]> GetTimeSpans_ExpectedLower()
        {
            yield return new object[] { new TimeSpan(2, 37, 0), 2 };
            yield return new object[] { new TimeSpan(13, 17, 2), 3 };
            yield return new object[] { new TimeSpan(20, 45, 34), 0 };
            yield return new object[] { new TimeSpan(24, 12, 13), 4 };
        }
        public static IEnumerable<object[]> GetTimeSpans_ExpectedString()
        {
            yield return new object[] { new TimeSpan(2, 37, 0), "OOOO\nRROO" };
            yield return new object[] { new TimeSpan(13, 17, 2), "RROO\nRRRO" };
            yield return new object[] { new TimeSpan(20, 45, 34), "RRRR\nOOOO" };
            yield return new object[] { new TimeSpan(24, 12, 13), "RRRR\nRRRR" };
        }

        [Theory]
        [MemberData(nameof(GetTimeSpans_ExpectedUpper))]
        public void Upper_Value_ReturnExpected(TimeSpan value, int expectedUpper)
        {
            var result = new Hours(value).UpperValue;

            Assert.Equal(expectedUpper, result);
        }

        [Theory]
        [MemberData(nameof(GetTimeSpans_ExpectedLower))]
        public void Lower_Value_ReturnExpected(TimeSpan value, int expectedLower)
        {
            var result = new Hours(value).LowerValue;

            Assert.Equal(expectedLower, result);
        }

        [Theory]
        [MemberData(nameof(GetTimeSpans_ExpectedString))]
        public void ToString_Value_ReturnExpected(TimeSpan value, string expectedString)
        {
            var result = new Hours(value).ToString();

            Assert.Equal(expectedString, result);
        }
    }
}