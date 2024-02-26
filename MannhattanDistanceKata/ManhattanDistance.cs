

namespace MannhattanDistanceKata
{
    public class ManhattanDistance
    {
        public static int Calculation(ManhattanPoint point1, ManhattanPoint point2)
        {
            int xDistance = Math.Abs(point1.GetXPosition() - point2.GetXPosition());
            int yDistance = Math.Abs(point1.GetYPosition() - point2.GetYPosition());

            return xDistance + yDistance;
        }
    }
}