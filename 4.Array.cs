using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.netpractice
{
    class Class1
    {
        static void Main(string[] args)
        {
            int[] rain =  { 10, 20, 30, 40 };
            int[] rain1 = { 10, 20, 30, 40 };
            for (int i=0;i<rain.Length;i++)
            {
                Console.WriteLine(rain[i]);

            }

            Console.WriteLine("==============================================");
            foreach(int i in rain)
            {
                Console.WriteLine(i);
            }
           
       }
    }
}
