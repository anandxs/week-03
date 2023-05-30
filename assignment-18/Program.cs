namespace assignment_18
{
	internal class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Enter written test marks");
			int writtenTestMark = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter lab exam marks");
			int labExamMark = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter assignment marks");
			int assignmentMark = int.Parse(Console.ReadLine());

			double grade = writtenTestMark * 0.7 + labExamMark * 0.2 + assignmentMark * 0.1;

            Console.WriteLine("Grade : {0}", grade);
        }
	}
}