/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.netpractice
{
    class Program
    {

        static void Swap<t>(ref t a, ref t b)
        {

            t temp;
            temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            int a = 2, b = 4;
            Swap<int>(ref a, ref b);
            Console.WriteLine(a+" "+b);

            Double aa = 12.54, bb = 78.44;
            Swap<double>(ref aa, ref bb);
            Console.WriteLine(aa + " " + bb);

        }
    }
}*/