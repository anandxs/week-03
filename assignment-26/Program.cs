string my_string = "1234";
//int my_string = 1234;

try
{
	char[] charArray = my_string.ToArray();
	Array.Reverse(charArray);
	string reversedString = String.Join("", charArray);

	Console.WriteLine("Reversed string is " + reversedString);
}
catch (Exception ex)
{
    Console.WriteLine("Error : " + ex.Message);
}
finally
{
    Console.WriteLine("Type of my_string is : " + my_string.GetType());
}