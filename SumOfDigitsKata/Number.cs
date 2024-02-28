namespace SumOfDigitsKata
{
    public class Number
    {
        
        public static int DigitalRoot(long n)
        {
            long _res = 0;

            while (n > 0)
            {
                _res += n % 10;
                n = (n / 10);
            }

            if (_res > 9)
            {
                _res = Number.DigitalRoot(_res);
            }

            return (int)_res;
        }
    }
}