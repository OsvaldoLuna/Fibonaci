using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonaci
{
    class Program
    {
        static void Main(string[] args)
        {
            int pnum = 1, snum = 1, res;
            Console.WriteLine("Ingrese los digitos deseados para la serie:");
            int fib = int.Parse(Console.ReadLine());
            Console.WriteLine("---La serie Fibonacci es--- ");
            Console.Write(pnum + " , " + snum);
            while (fib != 0)
            {
                res = snum;
                Console.Write(" , " + (pnum + snum));
                snum = res + pnum;
                pnum = res;
                fib--;
            }
            Console.Write(".");
            Console.ReadKey();
        }
    }
}
