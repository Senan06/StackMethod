using System;
using System.Collections.Generic;

namespace StackMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        static Queue<string> reserve(Queue<string> queue)
        {
            Stack<string> test = new Stack<string>();

            foreach (var item in queue)
            {
                test.Push(item);
            }

            Queue<string> reservecopy = new Queue<string>();

            foreach (var item in test)
            {
                reservecopy.Enqueue(item);
            }

            
            return reservecopy;
        }
    }
}
