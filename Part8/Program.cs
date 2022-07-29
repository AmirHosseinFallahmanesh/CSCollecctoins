using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part8
{
    class Program
    {
        static void Main(string[] args)
        {

            SortedDictionary<int, string> sl = new SortedDictionary<int, string>();
            sl.Add(8, "amir");
            sl.Add(10, "reza");
            sl.Add(17, "sina");
            sl[14] = "nima";

            foreach (var item in sl)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            Console.ReadKey();
        }
    }
}
