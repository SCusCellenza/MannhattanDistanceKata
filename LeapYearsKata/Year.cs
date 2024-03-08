
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
            return IsYearDivisibleBy(400) || (IsYearDivisibleBy(4) && !IsYearDivisibleBy(100));
        }

        private bool IsYearDivisibleBy(int toDiviseBy)
        {
            return _year % toDiviseBy == 0;
        }
    }
}