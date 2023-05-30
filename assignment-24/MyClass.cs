namespace assignment_24
{
	internal class MyClass: Area
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter your choice");
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Square");
            Console.WriteLine("3. Rectangle");
            Console.WriteLine("4. Triangle");

			int choice = int.Parse(Console.ReadLine());

			switch (choice)
			{
				case 1:
					Circle();
					break;

				case 2:
					Square();
					break;

				case 3:
					Rectangle();
					break;

				case 4:
					Triangle();
					break;

				default:
                    Console.WriteLine("Invalid option. Try again!");
					break;
            }
        }
	}

	public class Area
	{
		public static void Circle()
		{
            Console.WriteLine("Enter radius");
			double radius = Double.Parse(Console.ReadLine());

			double area = Math.PI * radius * radius;
            Console.WriteLine("Area of circle of radius {0} = {1}", radius, area);
        }

		public static void Square()
		{
            Console.WriteLine("Enter length of side");
			double length = Double.Parse(Console.ReadLine());

			double area = length * length;
            Console.WriteLine("Area of square with length {0} = {1}", length, area);
        }

		public static void Rectangle()
		{
            Console.WriteLine("Enter length of rectangle");
			double length = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter breadth of rectangle");
			double breadth = Double.Parse(Console.ReadLine());

			double area = length * breadth;
            Console.WriteLine("Area of rectangle with length of {0} and breadth of {1} = {2}", length, breadth, area);
        }

		public static void Triangle()
		{
            Console.WriteLine("Enter base length");
			double baseLength = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter height");
			double height = Double.Parse(Console.ReadLine());

			double area = 0.5 * baseLength * height;
            Console.WriteLine("Area of triangle with bases {0} and height {1} = {2}", baseLength, height, area);
        }
	}
}