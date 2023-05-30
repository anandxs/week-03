Console.Write("Enter a number : ");
int number = Int32.Parse(Console.ReadLine());

for (int i = 1; i < 11; i++)
{
	Console.WriteLine(i + " x " + number + " = " + i * number);
}