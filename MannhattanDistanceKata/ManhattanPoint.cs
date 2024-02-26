namespace MannhattanDistanceKata
{
    public class ManhattanPoint
    {
        private readonly int _x;
        private readonly int _y;

        public ManhattanPoint(int X, int Y)
        {
            _x = X;
            _y = Y;
        }

        public int GetXPosition()
        {
            return _x;
        }

        public int GetYPosition()
        {
            return _y;
        }
    }
}