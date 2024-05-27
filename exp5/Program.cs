using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Input file path:");
        string filepath = Console.ReadLine();
        try
        {
            using (StreamReader reader = new StreamReader(filepath))
            {
                Console.WriteLine("file opened successfully");
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("An unexpected error occured", e);
        }
    }
}
