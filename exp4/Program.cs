using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        static void MainMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Main Menu");
                Console.WriteLine("1. Form 1");
                Console.WriteLine("2. Form 2");
                Console.WriteLine("3. Exit");
                Console.Write("Select an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Form1();
                        break;
                    case "2":
                        Form2();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }

        static void Form1()
        {
            Console.Clear();
            Console.WriteLine("Form 1");
            Console.WriteLine("This is the first form.");
            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadKey();
        }

        static void Form2()
        {
            Console.Clear();
            Console.WriteLine("Form 2");
            Console.WriteLine("This is the second form.");
            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadKey();
        }
    }
}
