using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        Dictionary<string, string> adarsh = new Dictionary<string, string>();
        adarsh.Add("aditya", "A");
        adarsh.Add("Akash","B");
        adarsh["Anup"] ="C";

        foreach (string key in adarsh.Keys)
        {
            Console.WriteLine("Name:"+ key);
        }
        if (adarsh.ContainsKey("Anup"))
        {
            Console.WriteLine("Anup's name is :" + adarsh["Anup"]);
        }
    }
}
