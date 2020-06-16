using Ezkimo.BerlinClock.Types;
using System;
using System.Collections.Generic;
using Xunit;

namespace Ezkimo.BerlinClock.Tests.Types
{
    public class SecondsTest
    {
        public static IEnumerable<object[]> GetTimeSpan_ExpectedValue()
        {
            yield return new object[] { new TimeSpan(2, 37, 0), true };
            yield return new object[] { new TimeSpan(2, 37, 1), false };
            yield return new object[] { new TimeSpan(13, 17, 2), true };
            yield return new object[] { new TimeSpan(13, 17, 7), false };
            yield return new object[] { new TimeSpan(20, 45, 34), true };
            yield return new object[] { new TimeSpan(24, 12, 60), true };
        }
        public static IEnumerable<object[]> GetTimeSpan_ExpectedString()
        {
            yield return new object[] { new TimeSpan(2, 37, 0), "Y" };
            yield return new object[] { new TimeSpan(2, 37, 1), "O" };
            yield return new object[] { new TimeSpan(13, 17, 2), "Y" };
            yield return new object[] { new TimeSpan(13, 17, 7), "O" };
            yield return new object[] { new TimeSpan(20, 45, 34), "Y" };
            yield return new object[] { new TimeSpan(24, 12, 60), "Y" };
        }

        [Theory]
        [MemberData(nameof(GetTimeSpan_ExpectedValue))]
        public void Value_ValueEven_ReturnTrue(TimeSpan value, bool expectedValue)
        {
            var result = new Seconds(value).Value;

            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [MemberData(nameof(GetTimeSpan_ExpectedString))]
        public void ToString_ValueEven_ReturnStingY(TimeSpan value, string expectedString)
        {
            var result = new Seconds(value).ToString();

            Assert.Equal(expectedString, result);
        }
    }
}