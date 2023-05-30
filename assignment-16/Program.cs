namespace assignment_16
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter a number");
			int number = int.Parse(Console.ReadLine());
			bool isPrime = true;

			for (int i = 2; i <= number / 2; i++)
			{
				if (number % i == 0)
				{
					isPrime = false;
					break;
				}
			}

			if (isPrime)
			{
                Console.WriteLine("The number is prime");
            }
			else
			{
                Console.WriteLine("The number is not prime");
            }
		}
	}
}