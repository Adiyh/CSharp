
using System;
using System.Collections;
using System.Transactions;

namespace ATMApp
{
    class ATM
    {
       
        private decimal _balance { get; set; }
        private double _pin = 123;

     public void getdata()
        {
            Console.WriteLine(_balance);
        }
        public void Setdata()
        {
            _balance = 0;
        }
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                _balance += amount;
                Console.WriteLine($"{amount} deposited successfully.");
            }
            else
            {
                Console.WriteLine("Enter a valid amount to deposit.");
            }
        }

      
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= _balance)
            {
                _balance -= amount;
                Console.WriteLine($"{amount} withdrawn successfully.");
            }
            else
            {
                Console.WriteLine("Insufficient balance or invalid amount.");
            }
        }
        public int maths()
        {
          Console.WriteLine("Enter the two numbers");
            int a=Convert.ToInt32(Console.ReadLine());
            int b=Convert.ToInt32(Console.ReadLine());

            return a+b;

        }

       
        public void ShowBalance()
        {
            Console.WriteLine($"Current Balance: {_balance}");
         
        }
        public void adarsh()
        {
            ArrayList arr = new ArrayList();
            arr.Add("Adarsh");
            arr.Add(100);
            Console.WriteLine(arr);
            Stack stack = new Stack();
            stack.Push("Akash");
            stack.Push(1200);
            Queue queue = new Queue();
            queue.Enqueue("Adarsh");
            queue.Enqueue(123);
            Hashtable hashtable = new Hashtable();
            hashtable.Add("Adarsh", 123);
            Dictionary<int,string> dic = new Dictionary<int,string>();
            dic.Add(12, "Adarsh");
            Stack<int> ints = new Stack<int>();
            ints.Push(1);
            Queue queue1 = new Queue();
            queue1.Enqueue(1);
        }
  
    }
}

    
