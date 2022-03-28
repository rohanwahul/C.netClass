/*using System;
using System.Threading;

namespace C.netpractice
{
    class ThreadDemo
    {
        public void Test()
        {   
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);

            }
        }

        public void Test2()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Hello");

            }
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            ThreadDemo Th = new ThreadDemo();
            //using thred cls we created thread t1
            Thread t1 = new Thread(new ThreadStart(Th.Test));
            Thread t2 = new Thread(new ThreadStart(Th.Test2));
            t1.Start();
            t2.Start();

        }



    }
}*/
