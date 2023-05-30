Console.WriteLine("Enter size of array");
int size = int.Parse(Console.ReadLine());

Console.WriteLine("Enter array values");
int[] arr = new int[size];
for (int i = 0; i < size; i++)
{
	int element = int.Parse(Console.ReadLine());
	arr[i] = element;
}

for (int i = 0; i < size - 1; i++)
{
	for (int j = i + 1; j < size; j++)
	{
		if (arr[i] < arr[j])
		{
			int temp = arr[i];
			arr[i] = arr[j];
			arr[j] = temp;
		}
	}
}

Console.WriteLine("\nArray in decreasing order");
for (int i = 0; i < size; i++)
{
	Console.Write(arr[i] + " ");
}