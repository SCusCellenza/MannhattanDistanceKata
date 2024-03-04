using System.Security.Cryptography.X509Certificates;

namespace LeapYearsKata
{
    public class UnitTest1
    {
        [Fact]
        public void AllYearsDivisibleBy400AreLeapYears()
        {
            Random rnd = new Random();
            int date = rnd.Next(10)*400;
            Year year = new Year(date);

            Assert.True(year.IsLeap());
        }

        [Fact]
        public void AllYearsDivisibleBy100ButNot400AreNotLeapYears()
        {
            Year year = new Year(1700);

            Assert.False(year.IsLeap());
        }

        //[Fact]
        //public void AllYearsDivisibleBy4ButNot100AreLeapYears()
        //{
        //    int year = 2004;

        //    Assert.True(Year.IsLeapYear);
        //}
    }
}