using System.Collections;
public class Mainclass
{
    public static void Main(string[] args)
    {
        AdarshsClass adarshsClass = new AdarshsClass();
        adarshsClass.function();
        adarshsClass.function2();
    }
}
public class AdarshsClass
{
    public Dictionary<int, string> glossory = new Dictionary<int, string>();

    public void function()
    {
        glossory[1] = "aditya";
        glossory[2] = "aditya";



        foreach (var item in glossory)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
    }
    public void function2()
    {
        Hashtable ht = new Hashtable();
        ht.Add(1, 2);
        ht.Add("aditya", "adarsh");
        ht.Add(2, 2);
        int k = Math.Max(1,3);

        foreach (var item in ht)
        {
            Console.WriteLine(item);
        }

    }
}
