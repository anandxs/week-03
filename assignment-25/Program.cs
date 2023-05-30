namespace assignment_25
{
	public class Book
	{
		public string title;
		public string author;
		public bool readingStatus;

		public Book(string title, string author, bool readingStatus)
		{
			this.title = title;
			this.author = author;
			this.readingStatus = readingStatus;
		}
	}
	internal class Program
	{
		static void Main(string[] args)
		{
			Book[] books = new Book[]
			{
				new Book("Bill Gates", "The Road Ahead", true),
				new Book("Steve Jobs", "Walter Isaacson", true),
				new Book("Mockingjay: The Final Book of The Hunger Games", "Suzanne Collins", false)
			};

			for (int i = 0; i < books.Length; i++)
			{
				if (books[i].readingStatus)
				{
					Console.WriteLine($"You still need to read {books[i].title} by {books[i].author}");
				}
				else
				{
					Console.WriteLine($"Already read {books[i].title} by {books[i].author}");
				}
			}
		}
	}
}