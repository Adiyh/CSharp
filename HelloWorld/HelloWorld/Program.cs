using System;

class Program
{
    public static void Main(string[] args)
    {
       
        Class1 c1 = new Class1();

        c1.adarsh();
        c1.calculator();
        Implicitonstructor c3 = new Implicitonstructor();

        Console.WriteLine(c3.x);
        
    }
}

class Class1
{
    int a;
    bool b;
    public void adarsh()
    {

        Class1 obj = new Class1();
        Console.WriteLine("Adarsh");
        obj.a = 10;
        obj.b = true;
        Console.WriteLine(obj.a);
        Console.WriteLine(obj.b);
        Console.ReadLine();
    }
    public void calculator()
    {
        Console.WriteLine("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter operator (+, -, *, /): ");
        char op = Console.ReadKey().KeyChar;
        Console.WriteLine();
        int result = 0;
        switch (op)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                result = num1 / num2;
                break;
            default:
                Console.WriteLine("Invalid operator");
                return;
        }
        Console.WriteLine("Result: " + result);
    }
}
class Implicitonstructor()
{
    public int x=10;
    

    
}