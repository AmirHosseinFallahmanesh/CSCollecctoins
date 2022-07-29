using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> appendToData = new List<string>();
            appendToData.Add("appendItem1");
            appendToData.Add("appendItem2");
            appendToData.Add("appendItem3");

            List<string> data = new List<string>(4);
            data.Add("item1");
            data.Add("item2");
            data.Add("item3");
            Console.WriteLine("Count "+data.Count);
            Console.WriteLine("Capacity "+data.Capacity);
            data.AddRange(appendToData);


            foreach (var item in data)
            {
                Console.WriteLine(item);
            }


            //clear data
            data.Clear();
            Console.ReadKey();
        }
    }
}
