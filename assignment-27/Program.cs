try
{
    Console.WriteLine("Enter height");

    double height;
    if (!Double.TryParse(Console.ReadLine(), out height))
    {
        throw new Exception("Not a number");
    }
    else if (height > 70)
    {
        throw new Exception("HugeHeightException");
    }
    else if (height <= 0)
    {
        throw new Exception("TinyHeightException");
    }
    Console.WriteLine(height);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}