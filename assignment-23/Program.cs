namespace assignment_23
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter size of array");
			int size = int.Parse(Console.ReadLine());

			TwoDArr arr = new TwoDArr(size);
			arr.GetArray();
			arr.DisplayArray();
		}
	}

	public class TwoDArr
	{
		private int[,] array;
		private int arrSize;

        public TwoDArr(int size)
		{
			this.array = new int[size, size];
			this.arrSize = size;
        }

		public void GetArray()
		{
            Console.WriteLine("Enter array elements");
			for (int i = 0; i < this.arrSize; i++)
			{
				for (int j = 0; j < this.arrSize; j++)
				{
					array[i, j] = int.Parse(Console.ReadLine());
				}
			}
        }

		public void DisplayArray()
		{
			Console.WriteLine("\nArray elements are");
			for (int i = 0; i < this.arrSize; i++)
			{
				for (int j = 0; j < this.arrSize; j++)
				{
					Console.Write(this.array[i, j] + " ");
                }
                Console.WriteLine();
            }
		}
    }
}