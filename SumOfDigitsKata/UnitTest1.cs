using System.Reflection.Metadata.Ecma335;

namespace SumOfDigitsKata
{
    public class UnitTest1
    {
        [Fact]
        public void Given0_ResultShouldBe0()
        {
            long num = 0;
            int expectedRes = 0;

            int res = Number.DigitalRoot(num);

            Assert.Equal(expectedRes, res);
        }

        [Fact]
        public void Given10_ResultShouldBe1()
        {
            long num = 10;
            int expectedRes = 1;

            int res = Number.DigitalRoot(num);

            Assert.Equal(expectedRes, res);
        }

        [Fact]
        public void Given16_ResultShouldBe7()
        {
            long num = 16;
            int expectedRes = 7;

            int res = Number.DigitalRoot(num);

            Assert.Equal(expectedRes, res);
        }

        [Fact]
        public void Given195_ResultShouldBe6()
        {
            long num = 195;
            int expectedRes = 6;

            int res = Number.DigitalRoot(num);

            Assert.Equal(expectedRes, res);
        }

        [Fact]
        public void Given992_ResultShouldBe2()
        {
            long num = 992;
            int expectedRes = 2;

            int res = Number.DigitalRoot(num);

            Assert.Equal(expectedRes, res);
        }

        [Fact]
        public void Given167346_ResultShouldBe9()
        {
            long num = 167346;
            int expectedRes = 9;

            int res = Number.DigitalRoot(num);

            Assert.Equal(expectedRes, res);
        }

        [Fact]
        public void Given999999999999_ResultShouldBe9()
        {
            long num = 999999999999;
            int expectedRes = 9;

            int res = Number.DigitalRoot(num);

            Assert.Equal(expectedRes, res);
        }
    }
}