using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part7
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> sl = new Dictionary<string, string>();
            sl.Add("abc1", "amir");
            sl.Add("abvs", "reza");
            sl["qqwe"] = "sina";

            //Console.WriteLine(sl["abc1"]);

            sl.Remove("abc1");
            
            foreach (var item in sl)
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }

            Console.ReadKey();

        }
    }
}
