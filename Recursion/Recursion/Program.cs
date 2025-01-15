namespace RecursionExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Print(1, 5);
            //Console.WriteLine(GetNthFibonacciNumber(5));
            int[] arr = [12, 34, 56, 78];
            BinarySearch(arr, 34);
        }
        private static void Print(int n, int r)
        {
            // base condition
            if(n == r)
            {
                Console.WriteLine(n);
                return;
            }

            // recursive case
            Console.WriteLine(n);
            Print(n+1, r);
        }
        private static long GetNthFibonacciNumber(int n)
        {
            // base condition
            if(n == 0 || n == 1)
            {
                return n;
            }

            // recursive case
            long result = GetNthFibonacciNumber(n - 1) + GetNthFibonacciNumber(n - 2);

            return result;
        }
        private static void BinarySearch(int[] arr, int target)
        {
            int l = 0, r = arr.Length-1;
            int result = BinarySearchRec(arr, target, l, r);
            Console.WriteLine(result);
        }
        private static int BinarySearchRec(int[] arr, int target, int l, int r)
        {
            int mid = l + (r - l) / 2;
            // base condition
            if (l > r) return -1;
            if(arr[mid] == target)
            {
                return mid;
            }
            // recursive case
            if (arr[mid] > target)
            {
                r = mid - 1;
            }
            else if (arr[mid] < target)
            {
                l = mid + 1;
            }
            return BinarySearchRec(arr, target, l, r);
        }
    }
}