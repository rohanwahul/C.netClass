/*using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetdemo1
{
    class Program
    {
        static void Main(string[] args)
        {


            ArrayList List0 = new ArrayList();

            List0.Add(10);
            List0.Add("ora");
            List0.Add(12.5);
            List0.Add(65);
            List0.Remove(12.5);
            Console.WriteLine("elements of Stack ");
            foreach (object item in List0)// by using forech
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("count of ArraList =" + List0.Count);
            Console.WriteLine("=============================================");


            Stack List = new Stack();

            List.Push(10);
            List.Push("ron");
            List.Push(12.5);
            List.Push(65);
            List.Pop(); // we cannt point to index here coz its work on principle FILO
            Console.WriteLine("elements of Stack ");
            foreach (object item in List)// by using forech
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("count of Stack =" + List.Count);

            Console.WriteLine("=============================================");

            Console.WriteLine("elements of Queue ");
            Queue List1 = new Queue();
            List1.Enqueue(10);
            List1.Enqueue("ron");
            List1.Enqueue(12.5);
            List1.Enqueue(65);
            List1.Dequeue(); // we cannt point to index here coz its work on principle FIFO
            foreach (object item in List1)// by using forech
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("count Of Queue=" + List1.Count);


            Hashtable hat = new Hashtable();// it contain key value pair
            hat.Add(5, "USA");
            hat.Add(4, "iNDIA");
            hat.Add(1, "CHINA");
            hat.Add(6, "AUS");
            hat.Add(7, "DUBAI");
            hat.Remove(1);
            Hashtable hat1 = new Hashtable();
            foreach (DictionaryEntry i in hat)
            {

                // Console.WriteLine(i.Key +" "+ i.Value);
                Console.WriteLine("{0}  {1}", i.Key, i.Value);
                //  Console.WriteLine("Key: {0}, Value: {1}", i.Key, i.Value);
                // Console.WriteLine($"Key: {i.Key}, Value: {i.Value}");


            }


        }

    }
}*/
