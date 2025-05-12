using System;
class Program
{
    static void Main(string[] args)
    {
       
        Console.WriteLine("Simple Calculator");
        Console.WriteLine("-----------------");

        while (true)
        {
            try
            {
                Console.Write("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter an operator (+, -, *, /): ");
                char op = Console.ReadKey().KeyChar;
                Console.WriteLine();

                Console.Write("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = op switch
                {
                    '+' => num1 + num2,
                    '-' => num1 - num2,
                    '*' => num1 * num2,
                    '/' => num2 != 0 ? num1 / num2 : throw new DivideByZeroException(),
                    _ => throw new InvalidOperationException("Invalid operator")
                };

                Console.WriteLine($"Result: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter numeric values.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }

            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("Do you want to perform another calculation? (y/n): ");
            char choice = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (choice != 'y' && choice != 'Y')
            {
                break;
            }
        }

        Console.WriteLine("Thank you for using the calculator. Goodbye!");
    }
}
