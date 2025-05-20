using System.Security.Cryptography.X509Certificates;

class Myclass
{


    public static void Test1()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Test1:"+i);

        }
        Console.WriteLine("Thread 1 exitting");
    }

    public static void Test2()
    {
        for (int i = 1; i <= 50; i++)
        {
            Console.WriteLine("Test2:"+i);
            if (i == 30)
            {
                Console.WriteLine("Thread going to sleep");
                Thread.Sleep(5000);
                Console.WriteLine("Thread going to start");
            }
        }
        Console.WriteLine("Thread 2 exitting");

    }

    public static void Test3(){
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("Test3:"+i);
                }
        Console.WriteLine("Thread 3 exitting");

    }



    public static void Main(String[] args)
    {

        Thread t1 = new Thread(Test1);
        Thread t2 = new Thread(Test2);
        Thread t3 = new Thread(Test3);
        t1.Start();
        t2.Start();
        t3.Start();
        Console.WriteLine("Main thread Exitting");




    }




}