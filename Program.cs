using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter value of a");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter value of b");
            b = Convert.ToInt16(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"The value of a after swapping is {a} and b is {b} ");


        }
    }
}
