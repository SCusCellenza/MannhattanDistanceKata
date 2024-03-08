﻿
namespace LeapYearsKata
{
    public class Year
    {
        private int _year;
        public Year(int year)
        {
            _year = year;
        }
        public bool IsLeapYear()
        {
            if (IsYearDivisibleBy(400))
                return true;
            if (IsYearDivisibleBy(100) && !IsYearDivisibleBy(400))
                return false;
            if (IsYearDivisibleBy(4) && !IsYearDivisibleBy(100))
                return true;
            return false;
        }

        private bool IsYearDivisibleBy(int toDiviseBy)
        {
            return _year % toDiviseBy == 0;
        }
    }
}