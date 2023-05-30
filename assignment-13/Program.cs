Console.WriteLine("Enter a string");

string inputString = Console.ReadLine();
string formattedInput = inputString.ToUpper();
int inputLength = formattedInput.Length;
bool isPalindrome = true;

for (int i = 0; i < inputLength / 2; i++)
{
	if (formattedInput[i] != formattedInput[inputLength - 1 - i])
	{
		isPalindrome = false;
		break;
    }
}

if (isPalindrome)
{
    Console.WriteLine("The string is a palindrome");
}
else
{
	Console.WriteLine("The string is not a palindrome");
}