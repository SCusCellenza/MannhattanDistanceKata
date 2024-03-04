namespace MultiplesOf3or5
{
    public class MultiplesOf3or5
    {
        public static int Sum(int number)
        {
            if (number < 0) return 0;
            
            var multiples = new List<int>();

            while (number > 0)
            {
                number--;
                if (number % 3 == 0 || number % 5 == 0) { 
                    multiples.Add(number);
                }
            }

            return multiples.Sum();
        }
    }
}