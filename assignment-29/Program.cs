namespace assignment_29
{
	public delegate bool CallbackFunction(int num);
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] arr = new int[] { 1, 2, 3, 4 };
			CallbackFunction fn = new CallbackFunction(CheckSum);

            Console.WriteLine(MyFilter(arr, fn));
        }

		public static bool CheckSum(int num)
		{
			return num % 2 == 0;
		}

		public static int MyFilter(int[] myArray, CallbackFunction fn)
		{
			int sum = 0;

			foreach (int num in myArray)
			{
				sum += num;
			}

            Console.WriteLine(fn(sum));

            return sum;
		}
	}
}