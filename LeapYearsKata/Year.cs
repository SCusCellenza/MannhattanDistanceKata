
using System.Runtime.CompilerServices;

namespace LeapYearsKata
{
    public class Year
    {
        private int _year;
        public Year(int year)
        {
            int _year = year;
            bool _isLeap = false;
        }

        public bool IsLeap()
        {
            if (this.DivisibleBy400())
                return true;
            if (this.DivisibleBy100())
                return false;
            return false;
        }
        
        private bool DivisibleBy400()
        {
            return _year % 400 == 0;
        }

        private bool DivisibleBy100()
        {
            return _year % 100 == 0;
        }

    }
}