namespace assignment_29
{
	public delegate bool CallbackFunction(int[] arr);
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] arr = new int[] { 1, 2, 3, 4 };
			CallbackFunction fn = new CallbackFunction(CheckSum);

			MyFilter(arr, fn);
        }

		public static bool CheckSum(int[] arr)
		{
			int sum = 0;

			foreach(int val in arr)
			{
				sum += val;
			}

			return sum % 2 == 0;
		}

		public static void MyFilter(int[] myArray, CallbackFunction fn)
		{
			if (fn(myArray))
			{
                Console.WriteLine("Sum is even");
            }
			else
			{
                Console.WriteLine("Sum is odd");
            }
		}
	}
}