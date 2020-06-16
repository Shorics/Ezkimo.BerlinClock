using Ezkimo.BerlinClock.Types;
using System;
using System.Collections.Generic;
using Xunit;

namespace Ezkimo.BerlinClock.Tests.Types
{
    public class MinutesTest
    {
        public static IEnumerable<object[]> GetTimeSpans_ExpectedUpper()
        {
            yield return new object[] { new TimeSpan(2, 37, 0), 7 };
            yield return new object[] { new TimeSpan(13, 17, 2), 3 };
            yield return new object[] { new TimeSpan(20, 45, 34), 9 };
            yield return new object[] { new TimeSpan(24, 59, 13), 11 };
            yield return new object[] { new TimeSpan(0, 0, 56), 0 };
            yield return new object[] { new TimeSpan(0, 60, 22), 0 };
        }
        public static IEnumerable<object[]> GetTimeSpans_ExpectedLower()
        {
            yield return new object[] { new TimeSpan(2, 37, 0), 2 };
            yield return new object[] { new TimeSpan(13, 17, 2), 2 };
            yield return new object[] { new TimeSpan(20, 45, 34), 0 };
            yield return new object[] { new TimeSpan(24, 59, 13), 4 };
            yield return new object[] { new TimeSpan(0, 0, 56), 0 };
            yield return new object[] { new TimeSpan(0, 60, 22), 0 };
        }
        public static IEnumerable<object[]> GetTimeSpans_ExpectedString()
        {
            yield return new object[] { new TimeSpan(2, 37, 0), "YYRYYRYOOOO\nYYOO" };
            yield return new object[] { new TimeSpan(13, 17, 2), "YYROOOOOOOO\nYYOO" };
            yield return new object[] { new TimeSpan(20, 45, 34), "YYRYYRYYROO\nOOOO" };
            yield return new object[] { new TimeSpan(24, 59, 13), "YYRYYRYYRYY\nYYYY" };
            yield return new object[] { new TimeSpan(0, 0, 56), "OOOOOOOOOOO\nOOOO" };
            yield return new object[] { new TimeSpan(0, 60, 22), "OOOOOOOOOOO\nOOOO" };
        }

        [Theory]
        [MemberData(nameof(GetTimeSpans_ExpectedUpper))]
        public void Upper_Value_ReturnExpected(TimeSpan value, int expectedUpper)
        {
            var result = new Minutes(value).UpperValue;

            Assert.Equal(expectedUpper, result);
        }

        [Theory]
        [MemberData(nameof(GetTimeSpans_ExpectedLower))]
        public void Lower_Value_ReturnExpected(TimeSpan value, int expectedLower)
        {
            var result = new Minutes(value).LowerValue;

            Assert.Equal(expectedLower, result);
        }

        [Theory]
        [MemberData(nameof(GetTimeSpans_ExpectedString))]
        public void ToString_Value_ReturnExpected(TimeSpan value, string expectedString)
        {
            var result = new Minutes(value).ToString();

            Assert.Equal(expectedString, result);
        }
    }
}