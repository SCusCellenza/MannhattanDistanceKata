using System.Drawing;

namespace MannhattanDistanceKata
{
    public class UnitTest1
    {
        [Fact]
        public void GivenTheSamePoint_DistanceShouldBeZero()
        {
            var point1 = new ManhattanPoint(0, 0);

            var distance = ManhattanDistance.Calculation(point1, point1);

            Assert.Equal(0, distance);
        }

        [Fact]
        public void GivenAPointOnSameAbscissaButZHigherStepsOnOrdinate_DistanceShouldBeZ()
        {
            int X  = 0;
            int Y = 0;
            int Z = 4;

            var point1 = new ManhattanPoint(X, Y + Z);
            var point2 = new ManhattanPoint(X, Y);

            var distance = ManhattanDistance.Calculation(point1, point2);

            Assert.Equal(Z, distance);
        }

        [Fact]
        public void GivenAPointOnSameAbscissaButZLowerStepsOnOrdinate_DistanceShouldBeZ()
        {
            int X = 0;
            int Y = 0;
            int Z = 4;

            var point1 = new ManhattanPoint(X, Y);
            var point2 = new ManhattanPoint(X, Y + Z);

            var distance = ManhattanDistance.Calculation(point1, point2);

            Assert.Equal(Z, distance);
        }

        [Fact]
        public void Test2()
        {
            int Z = 4;

            var point1 = new ManhattanPoint(5, 4);
            var point2 = new ManhattanPoint(3, 2);

            var distance = ManhattanDistance.Calculation(point1, point2);

            Assert.Equal(Z, distance);
        }

        [Fact]
        public void Test3()
        {
            int Z = 3;

            var point1 = new ManhattanPoint(1, 1);
            var point2 = new ManhattanPoint(0, 3);

            var distance = ManhattanDistance.Calculation(point1, point2);

            Assert.Equal(Z, distance);
        }
    }
}