try
{
    Console.WriteLine("Enter height");
    float height = float.Parse(Console.ReadLine());

    if (height > 70)
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