/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.netpractice
{
    class Dept
    {
        private int id;
        private string name;
         private string loc;

        public Dept() //Contructor doesn't have return type and its name should as same as class name
        {
            id = 1;
            name = "Rohan";
            loc = "pune";

        }
        public string GetData()
        {
            return $"Department id : {id} NAME : {name} Location : {loc}";

        }
        static void Main(string[] args)
        {

            Dept emp = new Dept();
            
            Console.WriteLine(emp.GetData());

        }
    }

}*/