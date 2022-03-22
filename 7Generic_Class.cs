/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.netpractice
{
    class Product
    {
        private int code;
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
    class MyGenericClass<T>
    {
        private T data;
        public MyGenericClass(T Data)
        {
            this.data = Data;
        }
        public T GetData()
        {
            return data;
        }

    }

    class Program
    {


        static void Main(string[] args)
        {
            MyGenericClass<int> myobj = new MyGenericClass<int>(100);
            Console.WriteLine(myobj.GetData());

          // MyGenericClass<Product> obj1 = new MyGenericClass<Product>(new Product(10, "mbile", 2000));

            Product p1 = new Product(10, "mbile", 2000);
            MyGenericClass<Product> obj2 = new MyGenericClass<Product>(p1);

            Console.WriteLine(obj2.GetData());
        }




    }
}*/