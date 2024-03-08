
namespace LeapYearsKata
{
    internal class Year
    {
        private int _year;
        public Year(int year)
        {
            _year = year;
        }

        internal bool IsLeapYear()
        {
            if (_year % 400 == 0)
                return true;
            return false;
        }
    }
}