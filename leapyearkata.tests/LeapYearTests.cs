using System;
using Xunit;

namespace leapyearkata.tests
{
    public class LeapYearTests
    {
        [Fact]
        public void IsNot_LeapYear_IfNotDivisibleBy4()
        {
            UInt16 year = 1997;
            var leapYear = new LeapYear(year);

            var result = leapYear.IsLeapYear();

            result.Equals(false);
        }

        [Fact]
        public void Is_LeapYear_IfDivisibleBy4()
        {
            UInt16 year = 1996;
            var leapYear = new LeapYear(year);

            var result = leapYear.IsLeapYear();

            result.Equals(true);
        }

        [Fact]
        public void Is_LeapYear_IfDivisibleBy400()
        {
            UInt16 year = 1600;
            var leapYear = new LeapYear(year);

            var result = leapYear.IsLeapYear();

            result.Equals(true);
        }

        [Fact]
        public void IsNot_LeapYear_IfDivisibleBy4And100ButNot400()
        {
            UInt16 year = 1800;
            var leapYear = new LeapYear(year);

            var result = leapYear.IsLeapYear();

            result.Equals(false);
        }
    }
}