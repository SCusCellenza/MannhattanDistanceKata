namespace FizzBuzz
{
    public class UnitTest1
    {
        [Fact]
        public void WhenANumberIsDivisibleBy3_ThenReturnFizz()
        {
            var rdm = new Random();
            int input = rdm.Next(1, 34) * 3;
            while (input % 5 == 0)
            {
                input = rdm.Next(1, 34) * 3;
            }
            var fizzBuzz = new Kata(input);
            Assert.Equal("Fizz", fizzBuzz.FizzOrBuzz());
        }

        [Fact]
        public void WhenANumberIsDivisibleBy5_ThenReturnBuzz()
        {
            var rdm = new Random();
            int input = rdm.Next(1, 21) * 5;
            while (input % 3 == 0)
            {
                input = rdm.Next(1, 21) * 5;
            }
            var fizzBuzz = new Kata(input);
            Assert.Equal("Buzz", fizzBuzz.FizzOrBuzz());
        }

        [Fact]
        public void WhenANumberIsDivisibleBy3and5_ThenReturnFizzBuzz()
        {
            var rdm = new Random();
            int input = rdm.Next(1, 8) * 5 * 3;
            var fizzBuzz = new Kata(input);
            Assert.Equal("FizzBuzz", fizzBuzz.FizzOrBuzz());
        }

        [Fact]
        public void WhenANumberNeitherDivisibleBy3and5_ThenReturnItsValue()
        {
            var rdm = new Random();
            int input = rdm.Next(1, 100);
            while (input % 3 == 0 || input % 5 == 0)
            {
                input = rdm.Next(1, 100);
            }
            var fizzBuzz = new Kata(input);
            Assert.Equal(input.ToString(), fizzBuzz.FizzOrBuzz());
        }

        [Fact]
        public void Whenanumbercontainsa3_thenreturnFizz()
        {
            int input = 13;
            var fizzBuzz = new Kata(input);

            Assert.Equal("Fizz", fizzBuzz.FizzOrBuzz());
        }

        [Fact]
        public void Whenanumbercontainsa5_thenreturnBuzz()
        {
            int input = 52;
            var fizzBuzz = new Kata(input);

            Assert.Equal("Buzz", fizzBuzz.FizzOrBuzz());
        }
    }
}