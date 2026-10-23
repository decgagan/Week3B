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
            for(int i= 1; i <= 11; i++)
            {
                try
                {
                    intStack.Push(i);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
               
            }
            for(int i= 1;i <= 11; i++)
            {
                try
                {
                    Console.WriteLine(intStack.Pop());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
               
            }

          
            Console.ReadKey();


        }
    }
}
