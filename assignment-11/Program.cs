Console.WriteLine("Enter size of array");
int size = int.Parse(Console.ReadLine());

Console.WriteLine("Enter array elements");
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
	int element = int.Parse(Console.ReadLine());
	array[i] = element;
}

int evenCount = 0;
for (int i = 0; i < size; i++)
{
	if (array[i] % 2 == 0)
	{
		evenCount++;
	}
}

Console.WriteLine($"Number of even numbers in array : {evenCount}");