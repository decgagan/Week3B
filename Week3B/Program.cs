using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenStack<int> 
            intStack=new GenStack<int>();
            intStack.Push(1);
            intStack.Push(2);
            intStack.Push(3);

            Console.WriteLine(intStack.Pop()); // Output: 3
            Console.WriteLine(intStack.Pop()); // Output: 2
            Console.WriteLine(intStack.Pop()); // Output: 1
            Console.ReadKey();
        }
    }
}
