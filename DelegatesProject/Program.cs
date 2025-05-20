namespace Adarsh
{
    public delegate int Mydelegate(int a, int b);
    public delegate void Notify();
    class Myclass
    { 
        public static void Email()
        {
            Console.WriteLine("Email sent");
        }
        public static void SMS()
        {
            Console.WriteLine("SMS sent");
        }
        public static int Add(int n, int m)
        {
            Console.WriteLine( n + m);
            return 0;
        }
        public static void Main(String[] args)
        {
            int n, m;
            //Mydelegate myd = new Mydelegate(Add);
            //myd.Invoke(2, 5);
            Notify notify = new Notify(SMS);
            notify();

         
            Notify notify1 = new Notify(Email);
            notify1();


        }
    }
}