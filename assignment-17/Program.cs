namespace assignment_17
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Calculator calculator = new Calculator();

			while (true)
			{
				Console.WriteLine("Select an option");
				Console.WriteLine("1. Addition");
				Console.WriteLine("2. Subtraction");
				Console.WriteLine("3. Multiplication");
				Console.WriteLine("4. Division");
				Console.WriteLine("5. Exit");

				int choice = int.Parse(Console.ReadLine());

				switch (choice)
				{
					case 1:
                        Console.WriteLine("Enter first number");
						int numberOne = int.Parse(Console.ReadLine());

						Console.WriteLine("Enter second number");
						int numberTwo = int.Parse(Console.ReadLine());

                        Console.WriteLine("{0} + {1} = {2}", numberOne, numberTwo, calculator.Sum(numberOne, numberTwo));
                        break;

					case 2:
						Console.WriteLine("Enter first number");
						numberOne = int.Parse(Console.ReadLine());

						Console.WriteLine("Enter second number");
						numberTwo = int.Parse(Console.ReadLine());

						Console.WriteLine("{0} - {1} = {2}", numberOne, numberTwo, calculator.Difference(numberOne, numberTwo));
						break;

					case 3:
						Console.WriteLine("Enter first number");
						numberOne = int.Parse(Console.ReadLine());

						Console.WriteLine("Enter second number");
						numberTwo = int.Parse(Console.ReadLine());

						Console.WriteLine("{0} x {1} = {2}", numberOne, numberTwo, calculator.Product(numberOne, numberTwo));
						break;

					case 4:
						Console.WriteLine("Enter first number");
						numberOne = int.Parse(Console.ReadLine());

						Console.WriteLine("Enter second number");
						numberTwo = int.Parse(Console.ReadLine());

						if (numberTwo == 0)
						{
                            Console.WriteLine("Cannot divide by zero!");
                        }
						else
						{
							Console.WriteLine("{0} / {1} = {2}", numberOne, numberTwo, calculator.Quotient(numberOne, numberTwo));

						}
						break;

					case 5:
                        Console.WriteLine("Exiting...");
						return;

                    default:
						Console.WriteLine("Invalid input. Try again");
						break;
				}
			}
        }
	}
}