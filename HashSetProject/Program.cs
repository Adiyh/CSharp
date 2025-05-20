//class Myclass
//{
//    public static void Main(String[] args)
//    {
//        HashSet<string> set = new HashSet<string>();
//        HashSet<int> set2 = new HashSet<int>();
//        Console.WriteLine("Enter the student id");
//        for(int i = 0; i < 5; i++)
//        {
//            int id = int.Parse(Console.ReadLine());
//            set2.Add(i);
//        }



//        Console.WriteLine("Enter the items");
//        for(int i =0; i<3;i++)
//        {
//            string name = Console.ReadLine();
//            set.Add(name);
//        }
//        Console.WriteLine("---------------------");
//        Console.WriteLine("\n");
//        foreach(var s in set)
//        {
//            Console.WriteLine(s);
//        }
//        foreach(var ss in set2)
//        {
//            Console.WriteLine(ss);
//        }
//    }
//}


using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<string> students = new HashSet<string>();

        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Enter name of student {i}: ");
            string name = Console.ReadLine();
            bool added = students.Add(name);

            if (!added)
                Console.WriteLine("This student is already in the list. Duplicates not allowed.");
        }

        Console.WriteLine("\nList of unique students:");
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
        Console.ReadKey();
     

        
    }
}
