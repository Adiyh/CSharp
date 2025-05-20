using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacksand_Queues.Models
{
    internal class stacks
    {
        public void stackOperation()
        {
            Stack<String> stack = new Stack<string>();
            Console.WriteLine("Enter the items to the stack");
            for(int i = 0; i < 4; i++)
            {
                
                
                string name = Console.ReadLine();
                
                
                
                stack.Push(name);
            }
            Console.WriteLine("---------------------------------------------------------");
            stack.Pop();
          
            Console.WriteLine("topmost:"+ stack.Peek());
            
            foreach(var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("The total elements in stacks ara");
            Console.WriteLine(stack.Count());
        }
    }
}
