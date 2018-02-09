using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summation
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = 0.06f;
            float y = 5.94f;
            float sum = x + y;
            
            Console.WriteLine("the sum of two nos is" + sum);
            Console.WriteLine("check if two nos are equal");
            if (sum == 6)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.WriteLine("check which no is greater");
            if (x>y)
            {
                Console.WriteLine("x is greater than y");
            }
            else if (y>x)
            {
                Console.WriteLine("y is greater than x");
            }
        }
    }
}
