using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> ls = new LinkedList<string>();
            ls.AddFirst("root");
            LinkedListNode<string> root_node = ls.Find("root");
            ls.AddAfter(root_node, "LG");
            ls.AddAfter(root_node, "Sumsung");
            ls.AddAfter(root_node, "Apple");

            LinkedListNode<string> lg_node = ls.Find("LG");
            ls.AddAfter(lg_node, "V10");
            ls.AddAfter(lg_node, "V20");
            ls.AddAfter(lg_node, "V30");

            LinkedListNode<string> Sumsung_node = ls.Find("Sumsung");
            ls.AddAfter(Sumsung_node, "S20");
            ls.AddAfter(Sumsung_node, "S21");
            ls.AddAfter(Sumsung_node, "S22");

            LinkedListNode<string> i_node = ls.Find("Apple");
            ls.AddAfter(i_node, "Iphone11");
            ls.AddAfter(i_node, "Iphone12");
            ls.AddAfter(i_node, "Iphone13");

            foreach (var item in ls)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
    }
}
