namespace assignment_22
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter array size");
			int size = int.Parse(Console.ReadLine());

			int[,] arr1;
			int[,] arr2;

			arr1 = getArray(size);
			arr2 = getArray(size);

			int[,] sumArr = addArray(arr1, arr2);

			displayArray(sumArr);
		}

		private static void displayArray(int[,] sumArr)
		{
            Console.WriteLine("Displaying array");

            int size = sumArr.GetLength(0);
			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
                    Console.Write(sumArr[i, j] + " ");
                }
                Console.WriteLine();
            }
		}

		private static int[,] addArray(int[,] arr1, int[,] arr2)
		{
			int size = arr1.GetLength(0);
			int[,] sumArr = new int[size, size];
			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					sumArr[i, j] = arr1[i, j] + arr2[i, j];
				}
			}

			return sumArr;
		}

		private static int[,] getArray(int size)
		{
			int[,] arr = new int[size, size];
            Console.WriteLine("Enter array elements");
			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					arr[i, j] = int.Parse(Console.ReadLine());
				}
			}

			return arr;
        }
	}
}