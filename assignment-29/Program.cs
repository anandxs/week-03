namespace assignment_29
{
	public delegate bool CallbackFunction(int x);
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] arr = new int[] { 1, 2, 3, 4, 5 };
			CallbackFunction fn = new CallbackFunction(CheckSum);

			MyFilter(arr, fn);
        }

		public static bool CheckSum(int x)
		{
			if (x % 2 == 0)
			{
				return true;
			}

			return false;
		}

		public static void MyFilter(int[] myArray, CallbackFunction fn)
		{
			int sum = 0;
			foreach (int num in myArray)
			{
				sum += num;
			}

			if (fn(sum))
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