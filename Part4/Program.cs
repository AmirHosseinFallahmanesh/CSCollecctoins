using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part4
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> ls = new LinkedList<string>();
            ls.AddFirst("item3");
            ls.AddFirst("item2");
            ls.AddFirst("item1");
            ls.AddLast("item4");

            LinkedListNode<string> node1 = ls.Find("item2");
            ls.AddAfter(node1, "item20");



            foreach (var item in ls)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
