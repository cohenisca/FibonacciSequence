using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fib = new Fibonacci();
            Console.WriteLine("get length of fibonacci sequence");
            var length = int.Parse(Console.ReadLine());
            Stopwatch sw = new Stopwatch();
            Console.WriteLine("Recorsive:");
            sw.Start();
            fib.fibonacci_Rec(length);
            sw.Stop();
            Console.WriteLine();
            Console.WriteLine("Duration of calculation series: " + sw.ElapsedMilliseconds+"ms");
            Console.WriteLine("Iterative:");
            sw.Restart();
            fib.fibonacciIt(length);
            sw.Stop();
            Console.WriteLine();
            Console.WriteLine("Duration of calculation series: " + sw.ElapsedMilliseconds + "ms");
            Console.ReadKey();
        }
    }
}
