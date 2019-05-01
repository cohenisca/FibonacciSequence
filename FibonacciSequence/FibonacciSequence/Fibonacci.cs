using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    class Fibonacci
    {
        //recorsive
        public int fibonacciRec(int count)
        {
            if (count < 2)
                return 1;
            else
                return fibonacciRec(count - 1) + fibonacciRec(count - 2);
        }
        public void fibonacci_Rec(int num)
        {
            for (int i = 0; i < num; i++)
                Console.Write(fibonacciRec(i).ToString() + " ");
        }

        //iterative
        public void fibonacciIt(int count)
        {
            int prev1 = 1, prev2 = 1;
            Console.Write("1 1 ");
            for(int i=0; i<count-2; i++)
            {
                int temp = prev1 + prev2;
                Console.Write(temp + " ");
                prev1 = prev2;
                prev2 = temp;
            }
        }
    }
}
