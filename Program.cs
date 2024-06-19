using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._2_Function_with_parameters_and_return_value
{
    internal class Program
    {
        static int Add(int x, int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            int Result = Add(5, 10);
            Console.WriteLine($"Result of x and y {Result}");
        }
    }
}
