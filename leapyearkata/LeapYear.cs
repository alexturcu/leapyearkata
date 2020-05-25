using System;

namespace leapyearkata
{
    public class LeapYear
    {
        private UInt16 currentYear;

        public LeapYear(UInt16 year)
        {
            this.currentYear = year;
        }

        public bool IsLeapYear() => IsDivisibleBy(4) && !(IsDivisibleBy(100) && !IsDivisibleBy(400));

        private bool IsDivisibleBy(UInt16 value)
        {
            return currentYear % value == 0;
        }
    }
}