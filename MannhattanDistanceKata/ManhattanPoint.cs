using System.Runtime.CompilerServices;

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
            List<int> myIntList = new List<int>();
            List<int> myIntList2 = new List<int>();
            
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