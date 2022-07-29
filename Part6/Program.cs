using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part6
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sl = new SortedList<int, string>();
            sl.Add(8, "amir");
            sl.Add(10, "reza");
            sl.Add(17, "sina");
            sl[14] = "nima";

            foreach (var item in sl)
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }


            SortedList<string, double> sl1 = new SortedList<string, double>();
            sl1.Add("amir", 20);
            sl1.Add("reza",16.4);
            sl1.Add("vahid",10);
            sl1.Add("mahya",5);
         

            foreach (var item in sl1)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            Console.ReadKey();
        }
    }
}
