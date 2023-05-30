Console.WriteLine("Enter size of array");
int size = int.Parse(Console.ReadLine());

int[,] arr1 = new int[size, size];
int[,] arr2 = new int[size, size];

Console.WriteLine("Enter values of array1");
for (int i = 0; i < size; i++)
{
	for (int j = 0; j < size; j++)
	{
		int element = int.Parse(Console.ReadLine());
		arr1[i, j] = element;
	}
}

Console.WriteLine("Enter values of array2");
for (int i = 0; i < size; i++)
{
	for (int j = 0; j < size; j++)
	{
		int element = int.Parse(Console.ReadLine());
		arr2[i, j] = element;
	}
}

Console.WriteLine("\nSum array -");
for (int i = 0; i < size; i++)
{
	for (int j = 0; j < size; j++)
	{
		int sum = arr1[i, j] + arr2[i, j];
		Console.Write(sum + " ");
    }
    Console.WriteLine();
}