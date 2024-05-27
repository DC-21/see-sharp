using System;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Console Calculator!");

            while (true)
            {
                Console.Write("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter an operator (+, -, *, /): ");
                char op = Convert.ToChar(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = op switch
                {
                    '+' => num1 + num2,
                    '-' => num1 - num2,
                    '*' => num1 * num2,
                    '/' when num2 != 0 => num1 / num2,
                    '/' => throw new DivideByZeroException(),
                    _ => throw new InvalidOperationException("Invalid operator")
                };

                Console.WriteLine($"Result: {num1} {op} {num2} = {result}");

                Console.Write("Do you want to perform another calculation? (yes/no): ");
                if (Console.ReadLine().ToLower() != "yes") break;
            }

            Console.WriteLine("Thank you for using the Console Calculator!");
        }
    }
}
