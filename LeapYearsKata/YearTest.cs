using System.Security.Cryptography.X509Certificates;

namespace LeapYearsKata
{
    public class YearTest
    {
        [Fact]
        public void AllYearsDivisibleBy400AreLeapYears()
        {
            //Arrange
            Random rdm = new Random();
            int yearToTest = rdm.Next(1, 10) * 400;
            Year year = new Year(yearToTest);

            //Act 

            //Assert
            Assert.True(year.IsLeapYear());
        }

        [Fact]
        public void AllYearsDivisibleBy100ButNotBy400AreNotLeapYears()
        {
            //Arrange 
            Random rdm = new Random();
            int yearToTest;
            do {
                yearToTest = rdm.Next(1, 40) * 100;
            }
            while (yearToTest % 400 == 0);
            Year year = new Year(yearToTest);

            //Act 

            //Assert
            Assert.False(year.IsLeapYear());
        }

        [Fact]
        public void AllYearsDivisibleBy4ButNotBy100AreLeapYears()
        {
            //Arrange
            Random rdm = new Random();
            int yearToTest;
            do
            {
                yearToTest = rdm.Next(1, 1000) * 4;
            }
            while (yearToTest % 100 == 0);
            Year year = new Year(yearToTest);

            //Act 

            //Assert
            Assert.True(year.IsLeapYear());
        }

    }
}