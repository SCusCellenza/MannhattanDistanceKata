namespace MultiplesOf3or5
{
    public class UnitTest1
    {
        [Fact]
        public void GivenNegativeInput_Return0()
        {
            Assert.Equal(0, MultiplesOf3or5.Sum(-1));
        }

        [Fact]
        public void Given0_Return0()
        {
            Assert.Equal(0, MultiplesOf3or5.Sum(0));
        }

        [Fact]
        public void Given4_Return3()
        {
            Assert.Equal(3, MultiplesOf3or5.Sum(4));
        }

        [Fact]
        public void Given10_Return23()
        {
            Assert.Equal(23, MultiplesOf3or5.Sum(10));
        }

        [Fact]
        public void Given20_Return78()
        {
            Assert.Equal(78, MultiplesOf3or5.Sum(20));
        }

        [Fact]
        public void Given200_Return9168()
        {
            Assert.Equal(9168, MultiplesOf3or5.Sum(200));
        }
    }
}