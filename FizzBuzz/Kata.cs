
namespace FizzBuzz
{
    public class Kata
    {
        private int _input;

        public Kata(int input)
        {
            _input = input;
        }
        public string FizzOrBuzz()
        {
            if (_input % 3 == 0 && _input % 5 == 0)
                return "FizzBuzz";
            if (this.IsDivisibleByAnumberOrContainsIt(3))
                return "Fizz";
            if (this.IsDivisibleByAnumberOrContainsIt(5))
                return "Buzz";

            return _input.ToString();
        }

        private bool IsDivisibleByAnumberOrContainsIt(int intToCompareWith)
        {
            if (_input % intToCompareWith == 0) return true;

            foreach (char c in _input.ToString())
            {
                if (c == intToCompareWith.ToString()[0]) return true;
            }
            return false;
        }
    }
}