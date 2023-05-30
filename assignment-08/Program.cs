Console.Write("Enter limit : ");
int limit = Int32.Parse(Console.ReadLine());

int sum = 0;

for (int i = 1; i <= limit; i++)
{
	if (i % 2 == 1)
	{
		sum += i;
	}
}

Console.WriteLine("Sum of odd numbers : " + sum);