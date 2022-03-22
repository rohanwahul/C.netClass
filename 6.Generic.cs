/*using System;
using System.Collections.Generic;


namespace dotnetdemo1
{
    class Product
    { private int code;
        private string name;
        private double price;
        public Product(int code, string name, Double price)
        {
            this.code = code;
            this.name = name;
            this.price = price;
        }
        public override string ToString()
        {
            return code + " " + name + " " + price;
        }
    }
    class Program
    {
        public static object Productlist { get; private set; }

        static void Main(string[] args)
        {


            List<int> list1 = new List<int>();
            List<string> list2 = new List<string>();
            List<Product> list3 = new List<Product>();

            Product p1 = new Product(101,"mobile",10000);
            Product p2 = new Product(10, "Watch", 1000);

            list3.Add(p1);
            list3.Add(p2);

            foreach (Product item in list3)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("------------------------------------------------------------------------");
            //-----------------------------OR-WE-can-Initialise-it-In-other-way-----------------------

            List<Product> list4 = new List<Product>
            {
                new Product(101,"mobile",10000),
                 new Product(10, "Watch", 1000)

            };
  
            foreach (Product item in list4)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine("------------------------Dictionary-----------------------"); 
            Dictionary<int, string> Dict = new Dictionary<int, string>();

            Dict.Add(5, "rohan");
            Dict.Add(4, "rohan");
            foreach (KeyValuePair<int, string> item in Dict)
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }
        }

    }
}*/