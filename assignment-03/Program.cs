namespace assignment_03
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter principal amount : ");
			int principal = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter interest rate : ");
			float interestRate = (float)Convert.ToDouble(Console.ReadLine());

			Console.Write("Enter number of years : ");
			float numberOfYears = (float)Convert.ToDouble(Console.ReadLine());

			float simpleInterest = principal * interestRate * numberOfYears / 100;
			Console.WriteLine("Simple Interest : " + simpleInterest);
		}
	}
}