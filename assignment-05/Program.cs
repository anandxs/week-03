Console.Write("Enter total marks : ");
float totalMarks = (float)Convert.ToDouble(Console.ReadLine());

if (totalMarks >= 90)
{
	Console.WriteLine("A");
}
else if (totalMarks >= 80)
{
	Console.WriteLine("B");
}
else if (totalMarks >= 70)
{
	Console.WriteLine("C");
}
else if (totalMarks >= 60)
{
	Console.WriteLine("D");
}
else if (totalMarks >= 50)
{
	Console.WriteLine("E");
}
else
{
	Console.WriteLine("Failed");
}