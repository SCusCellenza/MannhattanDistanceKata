


namespace LINQ_Kata
{
    public class LinqKata
    {
        public static int Sum(int[] ints)
        {
            return ints.Sum();
        }

        internal static int[] CalculateSquares(int start, int end)
        {
            return Enumerable.Range(start, end - start + 1)
                         .Select(x => x * x)
                         .ToArray();
        }

        internal static int CountChar(char[] chars, char charToCount)
        {
            var occurences = chars.Where(c => charToCount == c).Count();

            return occurences;
        }
    }
}