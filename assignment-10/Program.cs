Console.WriteLine("Enter size of arrays");
int size = int.Parse(Console.ReadLine());

int[] array1 = new int[size];
int[] array2 = new int[size];

Console.WriteLine("Enter array 1 elements");
for (int i = 0; i < size; i++)
{
	int element = int.Parse(Console.ReadLine()) ;
	array1[i] = element;
}

Console.WriteLine("Enter array 2 elements");
for (int i = 0; i < size; i++)
{
	int element = int.Parse(Console.ReadLine());
	array2[i] = element;
}

Console.Write("\nArray 1 elements are ");
for (int i = 0; i < size; i++)
{
	Console.Write(array1[i] + " ");
}

Console.Write("\nArray 2 elements are ");
for (int i = 0; i < size; i++)
{
	Console.Write(array2[i] + " ");
}

Console.WriteLine("\n\nInterchanging array 1 elements with array 2 elements\n");
int temp;
for (int i = 0; i < size; i++)
{
	temp = array1[i];
	array1[i] = array2[i];
	array2[i] = temp;
}

Console.Write("\nArray 1 elements are ");
for (int i = 0; i < size; i++)
{
	Console.Write(array1[i] + " ");
}

Console.Write("\nArray 2 elements are ");
for (int i = 0; i < size; i++)
{
	Console.Write(array2[i] + " ");
}

Console.WriteLine();