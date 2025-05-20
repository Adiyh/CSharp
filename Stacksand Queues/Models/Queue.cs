using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacksand_Queues.Models
{
    internal class Queue
    {
        public void OueueOperation()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Adarsh");
            Console.WriteLine("Enter the elements to string");

            for (int i = 0; i < 4; i++)
            {
                string name =Console.ReadLine();
                queue.Enqueue(name);

            }
            queue.Dequeue();
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("The elements in the queue are");
            foreach(var s in queue)
            {
                Console.WriteLine(s);
            }
           

        }
    }
}
