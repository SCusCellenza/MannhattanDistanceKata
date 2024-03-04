namespace LINQ_Kata
{
    public class UnitTest1
    {
        [Fact]
        public void SumOfArrayTest()
        {
            Assert.Equal(6, LinqKata.Sum(new[] { 2, 3, 1 }));
        }

        [Fact]
        public void CountOccurencesOfCharacterTest()
        {
            Assert.Equal(2, LinqKata.CountChar(new[] { 'A', 'B', 'C', 'A' }, 'A'));
        }

        [Fact]
        public void CalculateSquaresTest()
        {
            Assert.Equal(new[] { 1, 4, 9, 16, 25, 36 }, LinqKata.CalculateSquares(1, 6));
        }
    }
}