using System.Security.Cryptography.X509Certificates;

namespace LeapYearsKata
{
    public class YearTest
    {
        [Fact]
        public void AllYearsDivisibleBy400AreLeapYears()
        {
            //Arrange 
            Year year = new Year(2000);

            //Act 

            //Assert
            Assert.True(year.IsLeapYear());
        }

        [Fact]
        public void AllYearsDivisibleBy100ButNotBy400AreNotLeapYears()
        {
            //Arrange 
            Year year = new Year(1700);

            //Act 

            //Assert
            Assert.False(year.IsLeapYear());
        }

        [Fact]
        public void AllYearsDivisibleBy4ButNotBy100AreLeapYears()
        {
            //Arrange 
            Year year = new Year(2008);

            //Act 

            //Assert
            Assert.True(year.IsLeapYear());
        }

    }
}