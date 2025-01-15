namespace RecursionProblem
{
    public class DigitSum
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Sum(3245));
        }
        private static int Sum(int n)
        {
            // base condition
            if(n == 0)
            {
                return 0;
            }

            // recursive case
            int digit = n % 10;
            return digit + Sum(n / 10);
        }
    }
}