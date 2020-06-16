using Ezkimo.BerlinClock.Types;
using System;
using System.Collections.Generic;
using Xunit;

namespace Ezkimo.BerlinClock.Tests.Types
{
    public class SecondsTest
    {
        public static IEnumerable<object[]> GetTimeSpanSecondsEven()
        {
            yield return new object[] { new TimeSpan(2, 37, 0) };
            yield return new object[] { new TimeSpan(13, 17, 2) };
            yield return new object[] { new TimeSpan(20, 45, 34) };
        }
        public static IEnumerable<object[]> GetTimeSpanSecondsUneven()
        {
            yield return new object[] { new TimeSpan(2, 37, 1) };
            yield return new object[] { new TimeSpan(13, 17, 7) };
            yield return new object[] { new TimeSpan(20, 45, 33) };
        }

        [Theory]
        [MemberData(nameof(GetTimeSpanSecondsEven))]
        public void Value_ValueEven_ReturnTrue(TimeSpan value)
        {
            var result = new Seconds(value).Value;

            Assert.True(result, $"{value} should be even and lead to TRUE");
        }

        [Theory]
        [MemberData(nameof(GetTimeSpanSecondsUneven))]
        public void sValue_ValueUneven_ReturnFalse(TimeSpan value)
        {
            var result = new Seconds(value).Value;

            Assert.False(result, $"{value} should be uneven and lead to FALSE");
        }

        [Theory]
        [MemberData(nameof(GetTimeSpanSecondsEven))]
        public void ToString_ValueEven_ReturnStingY(TimeSpan value)
        {
            var result = new Seconds(value).ToString();

            Assert.Equal("Y", result);
        }

        [Theory]
        [MemberData(nameof(GetTimeSpanSecondsUneven))]
        public void ToString_ValueUneven_ReturnStingO(TimeSpan value)
        {
            var result = new Seconds(value).ToString();

            Assert.Equal("O", result);
        }
    }
}