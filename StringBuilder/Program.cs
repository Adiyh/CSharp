using System;
using System.Text;

class Program
{
    public static void Shower()
    {
        StringBuilder s = new StringBuilder();
        s.Append(234);
       
        s.Append(123);
        Console.WriteLine(s);
    }
    static void Main(String[] parameter)
    {
        Shower();
        Console.WriteLine("This string is mutable");
       

       
    }
}
