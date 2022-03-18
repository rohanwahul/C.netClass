/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.netpractice
{
    internal class Dept
    {
        private int id;
        private string name;
         private string loc;

        public Dept (int id, string name , string loc)
        {
            this.id = id;  // this.is represent private int id and same bellow
            this.name = name;
            this.loc = loc;

        }
        public string GetData()
        {
            return $"Department id : {id} NAME : {name} Location : {loc}";

        }
       
        static void Main(string[] args)
        {

            Dept emp = new Dept(3,"sita","usa");
           
            Console.WriteLine(emp.GetData());

        }
    }

}*/