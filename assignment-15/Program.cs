namespace assignment_15
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] arr;
			arr = getArray();
			displayArray(arr);
		}

		private static void displayArray(int[] arr)
		{
            Console.WriteLine("Array elements are ");
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + " ");
            }
        }

		private static int[] getArray()
		{
			Console.WriteLine("Enter size of array");
			int size = int.Parse(Console.ReadLine());

			int[] arr = new int[size];
			Console.WriteLine("Enter array elements");
			for (int i = 0; i < size; i++)
			{
				int element = int.Parse(Console.ReadLine());
				arr[i] = element;
			}

			return arr;
		}
	}
}