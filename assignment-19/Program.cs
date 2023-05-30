Console.WriteLine("Enter annual income");

float annualIncome = Single.Parse(Console.ReadLine());
float taxPercentage;

if (annualIncome <= 250000)
{
	taxPercentage = 0;
}
else if (annualIncome <= 500000)
{
	taxPercentage = 5;
}
else if (annualIncome <= 1000000)
{
	taxPercentage = 20;
}
else
{
	taxPercentage = 30;
}

float incomeTax = annualIncome * taxPercentage / 100;
Console.WriteLine("Income tax amount " + incomeTax);