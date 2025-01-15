namespace RecursionProblem
{
    public class ReverseANumber
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(ReverseNumber(1234, ""));
        }
        private static string ReverseNumber(int number, string revNumber)
        {
            // base condition
            if(number % 10 == number)
            {
                return revNumber + number.ToString();
            }

            // recursive case
            int digit = number % 10;
            return revNumber + digit.ToString() + ReverseNumber(number/10, revNumber);
        }
    }
}