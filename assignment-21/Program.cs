Console.WriteLine("Enter array size");
int size = int.Parse(Console.ReadLine());

int[] arr = new int[size];
Console.WriteLine("Enter array elements");
for (int i = 0; i < size; i++)
{
	arr[i] = int.Parse(Console.ReadLine());
}

int[] outputArr = new int[size - 1];
for (int i = 0; i < size - 1; i++)
{
	outputArr[i] = arr[i] * arr[i + 1];
}

Console.WriteLine("Output");
for (int i = 0; i < size - 1; i++)
{
	Console.Write(outputArr[i] + " ");
}