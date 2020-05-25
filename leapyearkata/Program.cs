using System;

namespace leapyearkata
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintLeapYearInfo(1800);
            PrintLeapYearInfo(1600);
            PrintLeapYearInfo(1997);
            PrintLeapYearInfo(1996);
        }

        static void PrintLeapYearInfo(UInt16 value)
        {
            Console.WriteLine(new LeapYear(value).IsLeapYear() ? $"{value} is leap year" : $"{value} is not leap year");
        }
    }
}
